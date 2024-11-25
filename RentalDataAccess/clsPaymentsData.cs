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
    public class clsPaymentsData
    {
        public static bool? GetPaymentsInfoByID(int? PaymentID,ref int? BookingID,ref int? ReturnID,
            ref string Details,ref decimal? InitialPaidTotalDueAmount,ref decimal? ActualTotalDueAmount,
            ref decimal? TotalRemaining,ref decimal? TotalRefundedAmount,
            ref DateTime? PaymentDate, ref DateTime? UpdatedPaymentDate, ref int? CreatedByUserID)
        {
            bool? IsFound = null;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "select * from Payments where PaymentID = @PaymentsID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentsID", PaymentID);
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                BookingID = (int)reader["BookingID"];
                                if (reader["ReturnID"] != DBNull.Value)
                                    ReturnID = (int?)reader["ReturnID"];
                                else
                                    ReturnID = null;

                                Details = reader["Details"] != DBNull.Value ? (string)reader["Details"] : null;

                                InitialPaidTotalDueAmount = (decimal)reader["InitialPaidTotalDueAmount"];
                                if (reader["ActualTotalDueAmount"] !=DBNull.Value)
                                    ActualTotalDueAmount = (decimal)reader["ActualTotalDueAmount"];
                                else
                                    ActualTotalDueAmount = null;
                                if (reader["TotalRemaining"] !=DBNull.Value)
                                    TotalRemaining = (decimal)reader["TotalRemaining"];
                                else
                                    TotalRemaining = null;
                                if (reader["TotalRefundedAmount"] !=DBNull.Value)
                                    TotalRefundedAmount =(decimal) reader["TotalRefundedAmount"];
                                else
                                    TotalRefundedAmount = null;
                                PaymentDate = (DateTime)reader["PaymentDate"];
                                UpdatedPaymentDate = (DateTime)reader["UpdatedPaymentDate"];
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


        public static bool? FindByBookingID(ref int? PaymentID,int? BookingID, ref int? ReturnID,
            ref string Details, ref decimal? InitialPaidTotalDueAmount, ref decimal? ActualTotalDueAmount,
            ref decimal? TotalRemaining, ref decimal? TotalRefundedAmount,
            ref DateTime? PaymentDate, ref DateTime? UpdatedPaymentDate, ref int? CreatedByUserID)
        {
            bool? IsFound = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "select * from Payments where BookingID = @BookingID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookingID", BookingID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                PaymentID = (int)reader["PaymentID"];
                                Details = reader["Details"] != DBNull.Value ? (string)reader["Details"] : null;

                                if (reader["ReturnID"] != DBNull.Value)
                                    ReturnID = (int?)reader["ReturnID"];
                                else
                                    ReturnID = null;

                                InitialPaidTotalDueAmount = (decimal)reader["InitialPaidTotalDueAmount"];
                                
                                if (reader["ActualTotalDueAmount"] != DBNull.Value)
                                    ActualTotalDueAmount = (decimal)reader["ActualTotalDueAmount"];
                                else
                                    ActualTotalDueAmount = null;
                                
                                if (reader["TotalRemaining"] != DBNull.Value)
                                    TotalRemaining = (decimal)reader["TotalRemaining"];
                                else
                                    TotalRemaining = null;
                                
                                if (reader["TotalRefundedAmount"] != DBNull.Value)
                                    TotalRefundedAmount = (decimal)reader["TotalRefundedAmount"];
                                else
                                    TotalRefundedAmount = null;
                                
                                PaymentDate = (DateTime)reader["PaymentDate"];

                                UpdatedPaymentDate = (DateTime)reader["UpdatedPaymentDate"] ;

                                CreatedByUserID = (int)reader["CreatedByUserID"];
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                clsEventLog.SaveEventLog(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }

            return IsFound;
        }


        public static int? AddNewPayments(int? BookingID,int? ReturnID,
            string Details,decimal? InitialPaidTotalDueAmount,decimal? ActualTotalDueAmount,
            decimal? TotalRemaining,decimal? TotalRefundedAmount,
            DateTime? PaymentDate,DateTime? UpdatedPaymentDate,int? CreatedByUserID)
        {
            int? PaymentsID = null;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Insert Into Payments (BookingID,ReturnID,Details,InitialPaidTotalDueAmount,
                                    ActualTotalDueAmount,TotalRemaining,TotalRefundedAmount,PaymentDate,
                                        UpdatedPaymentDate,CreatedByUserID)
                            Values (@BookingID,@ReturnID,@Details,@InitialPaidTotalDueAmount,@ActualTotalDueAmount,
                                        @TotalRemaining,@TotalRefundedAmount,@PaymentDate,
                                    @UpdatedPaymentDate,@CreatedByUserID)
                            
                                SELECT SCOPE_IDENTITY();";

                    using(SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@BookingID", BookingID);
                        command.Parameters.AddWithValue("@ReturnID", ReturnID == null ? (object)DBNull.Value : ReturnID);
                        command.Parameters.AddWithValue("@Details", Details == null ? (object)DBNull.Value : Details);
                        command.Parameters.AddWithValue("@InitialPaidTotalDueAmount", InitialPaidTotalDueAmount);
                        command.Parameters.AddWithValue("@ActualTotalDueAmount", ActualTotalDueAmount == null ? (object)DBNull.Value : ActualTotalDueAmount);
                        command.Parameters.AddWithValue("@TotalRemaining", TotalRemaining == null ? (object)DBNull.Value : TotalRemaining);
                        command.Parameters.AddWithValue("@TotalRefundedAmount", TotalRefundedAmount == null ? (object)DBNull.Value : TotalRefundedAmount);
                        command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
                        command.Parameters.AddWithValue("@UpdatedPaymentDate", UpdatedPaymentDate == null ? (object)DBNull.Value : UpdatedPaymentDate);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            PaymentsID = insertedID;
                        }

                    }

                }

            }
            catch(SqlException ex)
            {
                clsEventLog.SaveEventLog(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            return PaymentsID;
        }

        public static DataTable GetAllPayments()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"select * from Payments ";

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

        public static bool UpdatePayments(int? PaymentsID, int? BookingID, int? ReturnID,
            string Details, decimal? InitialPaidTotalDueAmount,  decimal? ActualTotalDueAmount,
            decimal? TotalRemaining,decimal? TotalRefundedAmount,
            DateTime? PaymentDate, DateTime? UpdatedPaymentDate, int? CreatedByUserID)
        {
            int? rowsAffected = null;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Update  Payments  
                            set BookingID = @BookingID,
                                ReturnID = @ReturnID,
                                Details = @Details,
                                InitialPaidTotalDueAmount = @InitialPaidTotalDueAmount, 
                                ActualTotalDueAmount=@ActualTotalDueAmount,
                                TotalRemaining = @TotalRemaining,  
                                TotalRefundedAmount = @TotalRefundedAmount,
                                PaymentDate = @PaymentDate,
                                UpdatedPaymentDate = @UpdatedPaymentDate,
                                CreatedByUserID = @CreatedByUserID

                                where PaymentID = @PaymentID";

                    using(SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@PaymentID", PaymentsID);
                        command.Parameters.AddWithValue("@BookingID", BookingID);
                        command.Parameters.AddWithValue("@ReturnID", ReturnID == null ? (object)DBNull.Value : ReturnID);
                        command.Parameters.AddWithValue("@Details", Details == null ? (object)DBNull.Value : Details);
                        command.Parameters.AddWithValue("@InitialPaidTotalDueAmount", InitialPaidTotalDueAmount);
                        command.Parameters.AddWithValue("@ActualTotalDueAmount", ActualTotalDueAmount == null ? (object)DBNull.Value : ActualTotalDueAmount);
                        command.Parameters.AddWithValue("@TotalRemaining", TotalRemaining == null ? (object)DBNull.Value : TotalRemaining);
                        command.Parameters.AddWithValue("@TotalRefundedAmount", TotalRefundedAmount == null ? (object)DBNull.Value : TotalRefundedAmount);
                        command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
                        command.Parameters.AddWithValue("@UpdatedPaymentDate", UpdatedPaymentDate);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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

        public static bool DeletePayments(int? PaymentsID)
        {
            int? rowsAffected = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"delete Payments where PaymentsID = @PaymentsID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentsID", PaymentsID);

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

        public static int CountReturns()
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    string query = "select count(*) from Payments where ReturnID is not null;";
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        rowsAffected = (int)Command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                clsEventLog.SaveEventLog(ex.Message,System.Diagnostics.EventLogEntryType.Error);
            }

            return rowsAffected;
        }


        public static decimal GetTotalRevenueByMonth(int Month)
        {
            decimal rowsAffected = 0;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    string query = @" select sum(ActualTotalDueAmount) from payments where ActualTotalDueAmount is not null  
										and Month(UpdatedPaymentDate)=@Month";

                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@Month", Month);

                        if (Command.ExecuteScalar() != DBNull.Value)
                            rowsAffected = (decimal)Command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                clsEventLog.SaveEventLog(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }

            return rowsAffected;
        }


        public static bool UpdateReturnsForPayments(int? PaymentsID,int? ReturnID)
        {
            int? rowsAffected = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Update  Payments  
                            set 
                                ReturnID = @ReturnID

                                where PaymentID = @PaymentID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentID", PaymentsID);
                        command.Parameters.AddWithValue("@ReturnID", ReturnID == null ? (object)DBNull.Value : ReturnID);


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


        public static bool UpdatePaymentsAfterReturn(int? ReturnID, decimal? ActualTotalDueAmount,
            decimal? TotalRemaining, decimal? TotalRefundedAmount,DateTime? UpdatedPaymentDate)
        {
            int? rowsAffected = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Update  Payments  
                            set  
                                ActualTotalDueAmount=@ActualTotalDueAmount,
                                TotalRemaining = @TotalRemaining,  
                                TotalRefundedAmount = @TotalRefundedAmount,
                                UpdatedPaymentDate = @UpdatedPaymentDate

                                where ReturnID = @ReturnID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReturnID", ReturnID);

                        command.Parameters.AddWithValue("@ActualTotalDueAmount", ActualTotalDueAmount == null ? (object)DBNull.Value : ActualTotalDueAmount);
                        command.Parameters.AddWithValue("@TotalRemaining", TotalRemaining == null ? (object)DBNull.Value : TotalRemaining);
                        command.Parameters.AddWithValue("@TotalRefundedAmount", TotalRefundedAmount == null ? (object)DBNull.Value : TotalRefundedAmount);
                        command.Parameters.AddWithValue("@UpdatedPaymentDate", UpdatedPaymentDate);

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
