using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RentalDataAccess
{
    public class clsBookingsData
    {
        public static bool? GetBookingsInfoByID(int? BookingID,ref int? CustomerID,ref int? VehicleID,
            ref DateTime StartDate,ref DateTime EndDate,ref string DropoffLocation,
            ref string PickupLocation,ref decimal? PricePerDay,ref decimal? InitialTotalDueAmount,
            ref string Notes,ref string Status, ref int? CreatedByUserID)
        {
            bool? IsFound = null;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "select * from Bookings where BookingID = @BookingsID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookingsID", BookingID);
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                CustomerID = (int?)reader["CustomerID"];
                                VehicleID = (int?)reader["VehicleID"];
                                StartDate = (DateTime)reader["StartDate"];
                                EndDate = (DateTime)reader["EndDate"];
                                DropoffLocation = (string)reader["DropoffLocation"];
                                PickupLocation = (string)reader["PickupLocation"];
                                PricePerDay = (decimal?)reader["PricePerDay"];
                                InitialTotalDueAmount = (decimal?)reader["InitialTotalDueAmount"];
                                Notes = reader["Notes"] != DBNull.Value ? (string)reader["Notes"] : null;
                                Status = (string)reader["Status"];
                                CreatedByUserID = (int?)reader["CreatedByUserID"];

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


        public static int? AddNewBookings(int? CustomerID, int? VehicleID, DateTime StartDate, DateTime EndDate, string DropoffLocation,
            string PickupLocation, decimal? PricePerDay, decimal? InitialTotalDueAmount, string Notes,
            string status, int? CreatedByUserID)
        {
            int? BookingsID = null;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Insert Into Bookings (CustomerID,VehicleID,StartDate,EndDate,
                                    DropoffLocation,PickupLocation,PricePerDay,InitialTotalDueAmount,
                                    Notes,status,CreatedByUserID)
                            Values (@CustomerID,@VehicleID,@StartDate,@EndDate,@DropoffLocation,
                                        @PickupLocation,@PricePerDay,@InitialTotalDueAmount,
                                    @Notes,@status,@CreatedByUserID)
                            
                                SELECT SCOPE_IDENTITY();";

                    using(SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        command.Parameters.AddWithValue("@VehicleID", VehicleID);
                        command.Parameters.AddWithValue("@StartDate", StartDate);
                        command.Parameters.AddWithValue("@EndDate", EndDate);
                        command.Parameters.AddWithValue("@DropoffLocation", DropoffLocation);
                        command.Parameters.AddWithValue("@PickupLocation", PickupLocation);
                        command.Parameters.AddWithValue("@PricePerDay", PricePerDay);
                        command.Parameters.AddWithValue("@InitialTotalDueAmount", InitialTotalDueAmount);
                        command.Parameters.AddWithValue("@Notes", Notes == null ? (object)DBNull.Value : Notes);
                        command.Parameters.AddWithValue("@Status", status);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            BookingsID = insertedID;
                        }

                    }

                }

            }
            catch(SqlException ex)
            {
                clsEventLog.SaveEventLog(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            return BookingsID;
        }

        public static DataTable GetAllBookings()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"SELECT dbo.Bookings.BookingID, dbo.Customers.Name AS Customer, dbo.Vehicles.Make + ' ' + dbo.Vehicles.Model + ' ' + CAST(dbo.Vehicles.Year AS nchar) AS Vehicle, dbo.Bookings.StartDate AS [Start Date], dbo.Bookings.EndDate AS [End Date], 
                                    dbo.Bookings.DropoffLocation AS [Drop Off Location], dbo.Bookings.PickupLocation AS [Pick Up Location], dbo.Bookings.InitialRentalDays AS [Initial Rental Days], dbo.Bookings.PricePerDay AS [Price Per Day], 
                                    dbo.Bookings.InitialTotalDueAmount AS [Initial Total Amount], dbo.Bookings.Status, dbo.Users.Username AS [Created By]
                                    FROM     dbo.Bookings INNER JOIN
                                    dbo.Customers ON dbo.Bookings.CustomerID = dbo.Customers.CustomerID INNER JOIN
                                    dbo.Vehicles ON dbo.Bookings.VehicleID = dbo.Vehicles.VehicleID INNER JOIN
                                    dbo.Users ON dbo.Bookings.CreatedByUserID = dbo.Users.UserID ";

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

        public static DataTable GetAllByCustomer(string Customer)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"SELECT dbo.Bookings.BookingID, dbo.Customers.Name AS Customer, dbo.Vehicles.Make + ' ' + dbo.Vehicles.Model + ' ' + CAST(dbo.Vehicles.Year AS nchar) AS Vehicle, dbo.Bookings.StartDate AS [Start Date], dbo.Bookings.EndDate AS [End Date], 
                  dbo.Bookings.DropoffLocation AS [Drop Off Location], dbo.Bookings.PickupLocation AS [Pick Up Location], dbo.Bookings.InitialRentalDays AS [Initial Rental Days], dbo.Bookings.PricePerDay AS [Price Per Day], 
                  dbo.Bookings.InitialTotalDueAmount AS [Initial Total Amount], dbo.Bookings.Status, dbo.Users.Username AS [Created By]
                   FROM     dbo.Bookings INNER JOIN
                  dbo.Customers ON dbo.Bookings.CustomerID = dbo.Customers.CustomerID INNER JOIN
                  dbo.Vehicles ON dbo.Bookings.VehicleID = dbo.Vehicles.VehicleID INNER JOIN
                  dbo.Users ON dbo.Bookings.CreatedByUserID = dbo.Users.UserID
                    where Customers.Name = @Customer";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Customer", Customer);

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


        public static bool UpdateBookings(int? BookingID, int? CustomerID, int? VehicleID, DateTime StartDate, DateTime EndDate, string DropoffLocation,
            string PickupLocation, decimal? PricePerDay, decimal? InitialTotalDueAmount, string Notes,
            string status, int? CreatedByUserID)
        {
            int? rowsAffected = null;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Update  Bookings 
                            set CustomerID = @CustomerID,
                                VehicleID = @VehicleID,
                                StartDate = @StartDate,
                                EndDate = @EndDate, 
                                DropoffLocation=@DropoffLocation,
                                PickupLocation = @PickupLocation,  
                                PricePerDay = @PricePerDay,
                                InitialTotalDueAmount =@InitialTotalDueAmount,
                                Notes = @Notes,
                                status = @status,
                                CreatedByUserID =@CreatedByUserID

                                where BookingID = @BookingID";

                    using(SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@BookingID", BookingID);
                        command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        command.Parameters.AddWithValue("@VehicleID", VehicleID);
                        command.Parameters.AddWithValue("@StartDate", StartDate);
                        command.Parameters.AddWithValue("@EndDate", EndDate);
                        command.Parameters.AddWithValue("@DropoffLocation", DropoffLocation);
                        command.Parameters.AddWithValue("@PickupLocation", PickupLocation);
                        command.Parameters.AddWithValue("@PricePerDay", PricePerDay);
                        command.Parameters.AddWithValue("@InitialTotalDueAmount", InitialTotalDueAmount);
                        command.Parameters.AddWithValue("@Notes", Notes == null ? (object)DBNull.Value : Notes);
                        command.Parameters.AddWithValue("@Status", status);
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

        public static bool DeleteBookings(int? BookingsID)
        {
            int? rowsAffected = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"delete Bookings where BookingID = @BookingsID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookingsID", BookingsID);

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



        public static int CountBookings()
        {
            int CountBookings = 0;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "select count(*) from Bookings";
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        CountBookings = (int)Command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                clsEventLog.SaveEventLog(ex.Message,EventLogEntryType.Error);
            }

            return CountBookings;
        }

        public static int CountOnRent()
        {
            int CountOnRent = 0;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @" select OnRents = count(*) from bookings where status = 'ongoing'";
                    Connection.Open();
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        CountOnRent = (int)Command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                clsEventLog.SaveEventLog(ex.Message, EventLogEntryType.Error);            }

            return CountOnRent;
        }

        public static bool UpdateBookingAfterReturn(int? BookingID,string status)
        {
            int? rowsAffected = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Update  Bookings 
                            set 
                                status = @status

                                where BookingID = @BookingID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookingID", BookingID);

                        command.Parameters.AddWithValue("@Status", status);

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
