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
    public class clsUserData
    {
        public static bool? GetUserInfoByID(int? UserID,ref string FullName,ref string PhoneNumber,
            ref string UserName,ref string Password,ref bool Status,
            ref string Address,ref string ImagePath)
        {
            bool? IsFound = null;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "select * from Users where UserID = @UserID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                FullName = (string)reader["FullName"];
                                PhoneNumber = (string)reader["PhoneNumber"];
                                UserName = (string)reader["UserName"];
                                Password = (string)reader["Password"];
                                Status = (bool)reader["Status"];
                                Address = (string)reader["Address"];
                                ImagePath = reader["ImagePath"] != DBNull.Value ? (string)reader["ImagePath"] : null;

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

        public static bool? GetUserInfoByUserNameAndPassword(ref int? UserID, ref string FullName, ref string PhoneNumber,
            string UserName,string Password, ref bool Status,
            ref string Address, ref string ImagePath)
        {
            bool? IsFound = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "select * from Users where Username = @Username and Password = @Password;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", UserName);
                        command.Parameters.AddWithValue("@Password", Password);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                UserID = (int)reader["UserID"];
                                FullName = (string)reader["FullName"];
                                PhoneNumber = (string)reader["PhoneNumber"];

                                Status = (bool)reader["Status"];
                                Address = (string)reader["Address"];
                                ImagePath = reader["ImagePath"] != DBNull.Value ? (string)reader["ImagePath"] : null;

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

        public static int? AddNewUser(string FullName,string PhoneNumber,
            string UserName,string Password,bool Status,
            string Address,string ImagePath)
        {
            int? UserID = null;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Insert Into Users (FullName,PhoneNumber,UserName,Password,
                                    Status,Address,ImagePath)
                            Values (@FullName,@PhoneNumber,@UserName,@Password,@Status,
                                        @Address,@ImagePath)
                            
                                SELECT SCOPE_IDENTITY();";

                    using(SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@FullName", FullName);
                        command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                        command.Parameters.AddWithValue("@UserName", UserName);
                        command.Parameters.AddWithValue("@Password", Password);
                        command.Parameters.AddWithValue("@Status", Status);
                        command.Parameters.AddWithValue("@Address", Address);
                        if (ImagePath != null)
                            command.Parameters.AddWithValue("@ImagePath", ImagePath);
                        else
                            command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            UserID = insertedID;
                        }

                    }

                }

            }
            catch(SqlException ex)
            {
                clsEventLog.SaveEventLog(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            return UserID;
        }

        public static DataTable GetAllUser()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"select * from Users ";

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

        public static bool UpdateUser(int? UserID,string FullName,string PhoneNumber,
            string UserName,string Password,bool Status,
            string Address,string ImagePath)
        {
            int? rowsAffected = null;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Update  Users  
                            set FullName = @FullName,
                                PhoneNumber = @PhoneNumber,
                                UserName = @UserName,
                                Password = @Password, 
                                Status=@Status,
                                Address = @Address,  
                                ImagePath = @ImagePath

                                where UserID = @UserID";

                    using(SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@FullName", FullName);
                        command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                        command.Parameters.AddWithValue("@UserName", UserName);
                        command.Parameters.AddWithValue("@Password", @Password);
                        command.Parameters.AddWithValue("@Status", Status);
                        command.Parameters.AddWithValue("@Address", Address);
                        if (ImagePath != null)
                            command.Parameters.AddWithValue("@ImagePath", ImagePath);
                        else
                            command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

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

        public static bool DeleteUser(int? UserID)
        {
            int? rowsAffected = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"delete Users where UserID = @UserID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);

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

        public static bool IsUserNameExist(string UserName)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"SELECT Found=1 FROM Users WHERE FullName = @User";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@User", UserName);

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
