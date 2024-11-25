using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RentalDataAccess
{
    public class clsReturnsData
    {
        public static bool? Find(int? ReturnID,ref DateTime? ActualReturnDate,ref byte? ActualRentalDays,
            ref int? ConsumedMilage,ref string FinalCheckNotes,ref decimal? AdditionalCharges,
            ref decimal? ActualTotalDueAmount,ref int? CreatedByUserID)
        {
            bool? IsFound = null;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "select * from Returns where ReturnID = @ReturnID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReturnID", ReturnID);
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                ActualReturnDate = (DateTime)reader["ActualReturnDate"];
                                ActualRentalDays = (byte)reader["ActualRentalDays"];
                                ConsumedMilage = (int)reader["ConsumedMilage"];
                                FinalCheckNotes = (string)reader["FinalCheckNotes"];
                                AdditionalCharges = (decimal)reader["AdditionalCharges"];
                                ActualTotalDueAmount = (decimal)reader["ActualTotalDueAmount"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];

                            }
                        }
                    }
                }
            }
            catch(SqlException ex)
            {
                clsEventLog.SaveEventLog(ex.Message,System.Diagnostics.EventLogEntryType.Error);
            }

            return IsFound;
        }


        public static int? AddNew(DateTime? ActualReturnDate,byte? ActualRentalDays,
            int? ConsumedMilage,string FinalCheckNotes,decimal? AdditionalCharges,
            decimal? ActualTotalDueAmount,int? CreatedByUserID)
        {
            int? ReturnID = null;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Insert Into Returns (ActualReturnDate,ActualRentalDays,ConsumedMilage,FinalCheckNotes,
                                    AdditionalCharges,ActualTotalDueAmount,CreatedByUserID)
                            Values (@ActualReturnDate,@ActualRentalDays,@ConsumedMilage,@FinalCheckNotes,@AdditionalCharges,
                                        @ActualTotalDueAmount,@CreatedByUserID)
                            
                                SELECT SCOPE_IDENTITY();";

                    using(SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@ActualReturnDate", ActualReturnDate);
                        command.Parameters.AddWithValue("@ActualRentalDays", ActualRentalDays);
                        command.Parameters.AddWithValue("@ConsumedMilage", ConsumedMilage);
                        command.Parameters.AddWithValue("@FinalCheckNotes", FinalCheckNotes);
                        command.Parameters.AddWithValue("@AdditionalCharges", AdditionalCharges);
                        command.Parameters.AddWithValue("@ActualTotalDueAmount", ActualTotalDueAmount);
                        if (CreatedByUserID != null)
                            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        else
                            command.Parameters.AddWithValue("@CreatedByUserID", DBNull.Value);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            ReturnID = insertedID;
                        }

                    }

                }

            }
            catch(SqlException ex)
            {
                clsEventLog.SaveEventLog(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            return ReturnID;
        }

        public static DataTable GetAll()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"select * from Returns ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dataTable.Load(reader);
                            }
                        }
                    }

                }
            }
            catch (SqlException ex)
            {
                clsEventLog.SaveEventLog(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            return dataTable;
            
        }

        public static bool Update(int? ReturnID, DateTime? ActualReturnDate, byte? ActualRentalDays,
            int? ConsumedMilage, string FinalCheckNotes, decimal? AdditionalCharges,
            decimal? ActualTotalDueAmount, int? CreatedByUserID)
        {
            int? rowsAffected = null;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Update  Returns  
                            set ActualReturnDate = @ActualReturnDate,
                                ActualRentalDays = @ActualRentalDays,
                                ConsumedMilage = @ConsumedMilage,
                                FinalCheckNotes = @FinalCheckNotes, 
                                AdditionalCharges=@AdditionalCharges,
                                ActualTotalDueAmount = @ActualTotalDueAmount,  
                                CreatedByUserID = @CreatedByUserID

                                where ReturnID = @ReturnID";

                    using(SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@ReturnID", ReturnID);
                        command.Parameters.AddWithValue("@ActualReturnDate", ActualReturnDate);
                        command.Parameters.AddWithValue("@ActualRentalDays", ActualRentalDays);
                        command.Parameters.AddWithValue("@ConsumedMilage", ConsumedMilage);
                        command.Parameters.AddWithValue("@FinalCheckNotes", @FinalCheckNotes);
                        command.Parameters.AddWithValue("@AdditionalCharges", AdditionalCharges);
                        command.Parameters.AddWithValue("@ActualTotalDueAmount", ActualTotalDueAmount);
                        if (CreatedByUserID != null)
                            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        else
                            command.Parameters.AddWithValue("@CreatedByUserID", System.DBNull.Value);

                        rowsAffected = command.ExecuteNonQuery();

                    }


                }
            }
            catch (SqlException ex)
            {
                clsEventLog.SaveEventLog(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }

            return (rowsAffected > 0);
        }

        public static bool Delete(int? ReturnID)
        {
            int? rowsAffected = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"delete Returns where ReturnID = @ReturnID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReturnID", ReturnID);

                        rowsAffected = command.ExecuteNonQuery();

                    }
                }
            }
            catch (SqlException ex)
            {
                clsEventLog.SaveEventLog(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }

            return (rowsAffected > 0);

        }

    }
}
