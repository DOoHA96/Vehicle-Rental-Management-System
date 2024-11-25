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
    public class clsDocumentData
    {
        public static bool? GetDocumentInfoByID(int? DocumentID,ref int? CustomerID,ref string Name,
            ref string Path,ref int? CreatedBy)
        {
            bool? IsFound = null;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "select * from Documents where DocumentID = @DocumentID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DocumentID", DocumentID);
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                CustomerID = (int)reader["CustomerID"];
                                Name = (string)reader["Name"];
                                Path = (string)reader["Path"];
                                CreatedBy = (int)reader["CreatedBy"];


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


        public static int? AddNewDocument(int? CustomerID,string Name,
            string Path,int? CreatedBy)
        {
            int? DocumentID = null;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Insert Into Documents (CustomerID,Name,Path,CreatedBy)
                            Values (@CustomerID,@Name,@Path,@CreatedBy)
                            
                                SELECT SCOPE_IDENTITY();";

                    using(SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@Path", Path);
                        command.Parameters.AddWithValue("@CreatedBy", CreatedBy);


                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            DocumentID = insertedID;
                        }

                    }

                }

            }
            catch(SqlException ex)
            {
                clsEventLog.SaveEventLog(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            return DocumentID;
        }

        public static DataTable GetAllDocument(int CustomerID)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"SELECT dbo.Documents.DocumentID, dbo.Customers.CustomerID,
                                        dbo.Documents.Name, dbo.Documents.Path, dbo.Users.Username AS [Created By]
                                        FROM     dbo.Customers INNER JOIN
                                        dbo.Documents ON dbo.Customers.CustomerID = dbo.Documents.CustomerID INNER JOIN
                                        dbo.Users ON dbo.Documents.CreatedBy = dbo.Users.UserID where 
                                        Customers.CustomerID = @CustomerID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);
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

        public static bool UpdateDocument(int? DocumentID,int? CustomerID,string Name,
            string Path,int? CreatedBy)
        {
            int? rowsAffected = null;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Update  Documents  
                            set CustomerID = @CustomerID,
                                Name = @Name,
                                Path = @Path,
                                CreatedBy = @CreatedBy

                                where DocumentID = @DocumentID";

                    using(SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@DocumentID", DocumentID);
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@Path", Path);
                        command.Parameters.AddWithValue("@CreatedBy", @CreatedBy);

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

        public static bool DeleteDocument(int? DocumentID)
        {
            int? rowsAffected = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"delete Documents where DocumentID = @DocumentID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DocumentID", DocumentID);

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

        public static bool IsPathExist(string Path)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"SELECT Found=1 FROM Documents WHERE CustomerID = @Document";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Document", Path);

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
