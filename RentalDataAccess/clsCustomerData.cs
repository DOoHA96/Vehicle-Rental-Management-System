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
    public class clsCustomerData
    {
        public static bool? GetCustomerInfoByID(int? CustomerID,ref string Name,ref string PhoneNumber,
            ref string Email,ref string Address,ref DateTime DateOfBirth,ref short Gender,
            ref string LicenseNumber,ref string ImagePath)
        {
            bool? IsFound = null;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "select * from Customers where CustomerID = @CustomerID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                Name = (string)reader["Name"];
                                PhoneNumber = (string)reader["PhoneNumber"];
                                Email = (string)reader["Email"];
                                Address = (string)reader["Address"];
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                Gender = (byte)reader["Gender"];
                                LicenseNumber = (string)reader["LicenseNumber"];
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

        public static int? AddNewCustomer(string Name,string PhoneNumber,
            string Email,string Address,DateTime DateOfBirth,short Gender,
            string LicenseNumber,string ImagePath)
        {
            int? CustomerID = null;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Insert Into Customers (Name,PhoneNumber,Email,Address,
                                    DateOfBirth,Gender,LicenseNumber,ImagePath)
                            Values (@Name,@PhoneNumber,@Email,@Address,@DateOfBirth,@Gender,
                                        @LicenseNumber,@ImagePath)
                            
                                SELECT SCOPE_IDENTITY();";

                    using(SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@Address", Address);
                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        command.Parameters.AddWithValue("@Gender", Gender);
                        command.Parameters.AddWithValue("@LicenseNumber", LicenseNumber);
                        if (ImagePath != null)
                            command.Parameters.AddWithValue("@ImagePath", ImagePath);
                        else
                            command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            CustomerID = insertedID;
                        }

                    }

                }

            }
            catch(SqlException ex)
            {
                clsEventLog.SaveEventLog(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            return CustomerID;
        }

        public static DataTable GetAllCustomer()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"select * from Customers ";

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

        public static bool UpdateCustomer(int? CustomerID,string Name,string PhoneNumber,
            string Email,string Address,DateTime DateOfBirth,short Gender,
            string LicenseNumber,string ImagePath)
        {
            int? rowsAffected = null;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Update  Customers  
                            set Name = @Name,
                                PhoneNumber = @PhoneNumber,
                                Email = @Email,
                                Address = @Address, 
                                DateOfBirth = @DateOfBirth,
                                Gender=@Gender,
                                LicenseNumber = @LicenseNumber,  
                                ImagePath = @ImagePath

                                where CustomerID = @CustomerID";

                    using(SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@Address", @Address);
                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        command.Parameters.AddWithValue("@Gender", Gender);
                        command.Parameters.AddWithValue("@LicenseNumber", LicenseNumber);
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

        public static bool DeleteCustomer(int? CustomerID)
        {
            int? rowsAffected = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"delete Customers where CustomerID = @CustomerID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);

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

        public static bool IsCustomerExist(int? CustomerID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"SELECT Found=1 FROM Customers WHERE CustomerID = @CustomerID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);

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
