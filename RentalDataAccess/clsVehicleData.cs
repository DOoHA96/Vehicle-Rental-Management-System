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
    public class clsVehicleData
    {
        public static bool? GetVehicleInfoByID(int? VehicleID,ref string Make,ref string Model,
            ref int? Year,ref int? Milage,ref int? FuelTypeID,
            ref string PlateNumber,ref int? CategoryID,ref decimal? PricePerDay,
            ref bool? IsAvailable, ref string ImagePath)
        {
            bool? IsFound = null;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "select * from Vehicles where VehicleID = @VehicleID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@VehicleID", VehicleID);
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                Make = (string)reader["Make"];
                                Model = (string)reader["Model"];
                                Year = (int)reader["Year"];
                                Milage = (int)reader["Milage"];
                                FuelTypeID = (int)reader["FuelTypeID"];
                                PlateNumber = (string)reader["PlateNumber"];
                                CategoryID = (int)reader["CategoryID"];
                                PricePerDay = (decimal)reader["PricePerDay"];
                                IsAvailable = (bool)reader["IsAvailable"];
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

        public static bool? FindIfAvailable(int? VehicleID, ref string Make, ref string Model,
            ref int? Year, ref int? Milage, ref int? FuelTypeID,
            ref string PlateNumber, ref int? CategoryID, ref decimal? PricePerDay,
            ref bool? IsAvailable, ref string ImagePath)
        {
            bool? IsFound = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"select * from Vehicles where VehicleID = @VehicleID
                                        and IsAvailable = 1";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@VehicleID", VehicleID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                Make = (string)reader["Make"];
                                Model = (string)reader["Model"];
                                Year = (int)reader["Year"];
                                Milage = (int)reader["Milage"];
                                FuelTypeID = (int)reader["FuelTypeID"];
                                PlateNumber = (string)reader["PlateNumber"];
                                CategoryID = (int)reader["CategoryID"];
                                PricePerDay = (decimal)reader["PricePerDay"];
                                IsAvailable = (bool)reader["IsAvailable"];
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

        public static int? AddNewVehicle(string Make,string Model,
            int? Year,int? Milage,int? FuelTypeID,
            string PlateNumber,int? CategoryID,decimal? PricePerDay,
            bool? IsAvailable,string ImagePath)
        {
            int? VehicleID = null;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Insert Into Vehicles (Make,Model,Year,Milage,
                                    FuelTypeID,PlateNumber,CategoryID,PricePerDay,IsAvailable,ImagePath)
                            Values (@Make,@Model,@Year,@Milage,@FuelTypeID,
                                        @PlateNumber,@CategoryID,@PricePerDay,@IsAvailable,@ImagePath)
                            
                                SELECT SCOPE_IDENTITY();";

                    using(SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@Make", Make);
                        command.Parameters.AddWithValue("@Model", Model);
                        command.Parameters.AddWithValue("@Year", Year);
                        command.Parameters.AddWithValue("@Milage", Milage);
                        command.Parameters.AddWithValue("@FuelTypeID", FuelTypeID);
                        command.Parameters.AddWithValue("@PlateNumber", PlateNumber);
                        command.Parameters.AddWithValue("@CategoryID", CategoryID);
                        command.Parameters.AddWithValue("@PricePerDay", PricePerDay);
                        command.Parameters.AddWithValue("@IsAvailable", IsAvailable);
                        if (ImagePath != null)
                            command.Parameters.AddWithValue("@ImagePath", ImagePath);
                        else
                            command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            VehicleID = insertedID;
                        }

                    }

                }

            }
            catch(SqlException ex)
            {
                clsEventLog.SaveEventLog(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            return VehicleID;
        }

        public static DataTable GetAll()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"SELECT vehicles.VehicleID, Vehicles.Make+' ' + Vehicles.Model+' ' + CONVERT(nvarchar(4), Vehicles.Year )as Name,
                                    Vehicles.Milage, FuelTypes.FuelType, vehicles.PlateNumber,
                                    Categories.Category, Vehicles.PricePerDay,
                                    case when   Vehicles.IsAvailable = 1 then 'Yes' else 'No' end as IsAvailable
                                    FROM     Vehicles INNER JOIN
                                    Categories ON Vehicles.CategoryID = Categories.CategoryID INNER JOIN
                                    FuelTypes ON vehicles.FuelTypeID = FuelTypes.FuelTypeID; ";

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

        public static DataTable GetAllAvailable()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"SELECT Vehicles.VehicleID, Vehicles.Make+' ' + Vehicles.Model+' ' + CONVERT(nvarchar(4), Vehicles.Year )as Name,
                                        Vehicles.Milage, FuelTypes.FuelType, Vehicles.PlateNumber,
                                        VehicleCategories.CategoryName, Vehicles.PricePerDay,
                                        case when   Vehicles.IsAvailable = 1 then 'Yes' else 'No' end
                                        FROM     Vehicles INNER JOIN
                                        VehicleCategories ON Vehicles.VehicleCategoryID = VehicleCategories.CategoryID INNER JOIN
                                        FuelTypes ON Vehicles.FuelTypeID = FuelTypes.ID
                                        where Vehicles.IsAvailable = 1;";

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

        public static DataTable GetAllReservationsByVehicleID(int VehicleID)
        {

            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"SELECT dbo.Bookings.BookingID, dbo.Customers.Name AS Customer, dbo.Vehicles.VehicleID, dbo.Bookings.StartDate AS [Start Date],   
					dbo.Bookings.EndDate AS [End Date], dbo.Bookings.Status, dbo.Users.Username AS [Created By]  
					FROM dbo.Bookings INNER JOIN  
					dbo.Customers ON dbo.Bookings.CustomerID = dbo.Customers.CustomerID INNER JOIN  
					dbo.Vehicles ON dbo.Bookings.VehicleID = dbo.Vehicles.VehicleID INNER JOIN  
					dbo.Users ON dbo.Bookings.CreatedByUserID = dbo.Users.UserID WHERE dbo.Vehicles.VehicleID =@vehicleID";
                    using (SqlCommand command = new SqlCommand(query, connection)) 
                    {
                        connection.Open();
                        //command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@vehicleID", VehicleID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                clsEventLog.SaveEventLog(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }

            return dt;

        }



        public static bool UpdateVehicle(int? VehicleID, string Make, string Model,
            int? Year, int? Milage, int? FuelTypeID,
            string PlateNumber, int? CategoryID, decimal? PricePerDay,
            bool? IsAvailable, string ImagePath)
        {
            int? rowsAffected = null;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Update  Vehicles  
                            set Make = @Make,
                                Model = @Model,
                                Year = @Year,
                                Milage = @Milage, 
                                FuelTypeID=@FuelTypeID,
                                PlateNumber = @PlateNumber, 
                                CategoryID = @CategoryID,
                                PricePerDay = @PricePerDay,
                                IsAvailable = @IsAvailable,
                                ImagePath = @ImagePath

                                where VehicleID = @VehicleID";

                    using(SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@VehicleID", VehicleID);
                        command.Parameters.AddWithValue("@Make", Make);
                        command.Parameters.AddWithValue("@Model", Model);
                        command.Parameters.AddWithValue("@Year", Year);
                        command.Parameters.AddWithValue("@Milage", @Milage);
                        command.Parameters.AddWithValue("@FuelTypeID", FuelTypeID);
                        command.Parameters.AddWithValue("@PlateNumber", PlateNumber);
                        command.Parameters.AddWithValue("@CategoryID", CategoryID);
                        command.Parameters.AddWithValue("@PricePerDay", PricePerDay);
                        command.Parameters.AddWithValue("@IsAvailable", IsAvailable);
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

        public static bool DeleteVehicle(int? VehicleID)
        {
            int? rowsAffected = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"delete Vehicles where VehicleID = @VehicleID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@VehicleID", VehicleID);

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

        public static int CountVehiclesByCategory(string Category)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"select CountVehicles = count(*) from vehicles inner join Categories  
                            On Vehicles.CategoryID = Categories.CategoryID Where Categories.Category = @CategoryName";
                   
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@CategoryName", Category);

                        rowsAffected = (int)command.ExecuteScalar();
                    }
                }
            }
            catch (SqlException ex)
            {
                clsEventLog.SaveEventLog(ex.Message,System.Diagnostics.EventLogEntryType.Error);
            }

            return rowsAffected;
        }

        public static int GetNumberOfRentals(int? VehicleID)
        {
            int NumberOfResults = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"select COUNT(*) from Bookings where VehicleID = @VehicleID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@VehicleID", VehicleID);

                        NumberOfResults = (int)command.ExecuteScalar();
                    }
                }
            }
            catch (SqlException ex)
            {
                clsEventLog.SaveEventLog(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }

            return NumberOfResults;
        }



        public static bool UpdateVehicleAfterReturn(int? VehicleID, int? Milage, bool? IsAvailable)
        {
            int? rowsAffected = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Update  Vehicles  
                            set 
                                Milage = @Milage, 
                                IsAvailable = @IsAvailable

                                where VehicleID = @VehicleID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@VehicleID", VehicleID);

                        command.Parameters.AddWithValue("@Milage", @Milage);

                        command.Parameters.AddWithValue("@IsAvailable", IsAvailable);


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
