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
    public class clsCategoryData
    {
        public static bool? GetCategoryInfoByID(int? CategoryID,ref string Category)
        {
            bool? IsFound = null;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "select * from Categories where CategoryID = @CategoryID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CategoryID", CategoryID);
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                Category = (string)reader["Category"];


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

        public static bool? GetCategoryInfoByName(ref int? CategoryID,string Category)
        {
            bool? IsFound = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "select * from Categories where Category = @Category";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Category", Category);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                CategoryID = (int)reader["CategoryID"];

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

        public static int? AddNewCategory(string Category)
        {
            int? CategoryID = null;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Insert Into Categories (Category)
                            Values (@Category)
                            
                                SELECT SCOPE_IDENTITY();";

                    using(SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@Category", Category);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            CategoryID = insertedID;
                        }

                    }

                }

            }
            catch(SqlException ex)
            {
                clsEventLog.SaveEventLog(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            return CategoryID;
        }

        public static DataTable GetAllCategory()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"select * from Categories ";

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

        public static bool UpdateCategory(int? CategoryID,string Category)
        {
            int? rowsAffected = null;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Update  Categories  
                            set Category = @Category

                             where CategoryID = @CategoryID";

                    using(SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@CategoryID", CategoryID);
                        command.Parameters.AddWithValue("@Category", Category);

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

        public static bool DeleteCategory(int? CategoryID)
        {
            int? rowsAffected = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"delete Categories where CategoryID = @CategoryID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CategoryID", CategoryID);

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

        public static bool IsCategoryNameExist(string CategoryName)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"SELECT Found=1 FROM Categories WHERE Category = @Category";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Category", CategoryName);

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            isFound = reader.HasRows;
                        }

                    }
                }
            }
            catch (SqlException ex)
            {
                clsEventLog.SaveEventLog(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }

            return isFound;

        }

    }
}
