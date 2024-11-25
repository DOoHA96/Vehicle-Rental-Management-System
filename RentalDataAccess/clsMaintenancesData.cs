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
    public class clsMaintenancesData
    {
        public static bool? GetMaintenancesInfoByID(int? MaintenancesID,ref int? VehicleID,ref string Description,
            ref DateTime? MaintenanceDate,ref decimal? Cost,ref string Status,
            ref int? CreatedByUserID)
        {
            bool? IsFound = null;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "select * from Maintenances where MaintenanceID = @MaintenanceID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaintenanceID", MaintenancesID);
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                VehicleID = (int?)reader["VehicleID"];
                                Description = (string)reader["Description"];
                                MaintenanceDate = (DateTime?)reader["MaintenanceDate"];
                                Cost = (decimal?)reader["Cost"];
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


        public static int? AddNewMaintenances(int? VehicleID,string Description,
            DateTime? MaintenanceDate,decimal? Cost,string Status,
            int? CreatedByUserID)
        {
            int? MaintenancesID = null;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Insert Into Maintenances (VehicleID,Description,MaintenanceDate,Cost,
                                    Status,CreatedByUserID)
                            Values (@VehicleID,@Description,@MaintenanceDate,@Cost,@Status,
                                        @CreatedByUserID)
                            
                                SELECT SCOPE_IDENTITY();";

                    using(SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@VehicleID", VehicleID);
                        command.Parameters.AddWithValue("@Description", Description);
                        command.Parameters.AddWithValue("@MaintenanceDate", MaintenanceDate);
                        command.Parameters.AddWithValue("@Cost", Cost);
                        command.Parameters.AddWithValue("@Status", Status);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            MaintenancesID = insertedID;
                        }

                    }

                }

            }
            catch(SqlException ex)
            {
                clsEventLog.SaveEventLog(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            return MaintenancesID;
        }

        public static bool UpdateMaintenances(int? MaintenancesID, int? VehicleID, string Description,
            DateTime? MaintenanceDate, decimal? Cost, string Status,
            int? CreatedByUserID)
        {
            int? rowsAffected = null;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Update  Maintenances  
                            set VehicleID = @VehicleID,
                                Description = @Description,
                                MaintenanceDate = @MaintenanceDate,
                                Cost = @Cost, 
                                Status=@Status,
                                CreatedByUserID = @CreatedByUserID  

                                where MaintenanceID = @MaintenancesID";

                    using(SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@MaintenancesID", MaintenancesID);
                        command.Parameters.AddWithValue("@VehicleID", VehicleID);
                        command.Parameters.AddWithValue("@Description", Description);
                        command.Parameters.AddWithValue("@MaintenanceDate", MaintenanceDate);
                        command.Parameters.AddWithValue("@Cost", @Cost);
                        command.Parameters.AddWithValue("@Status", Status);
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

        public static DataTable GetAll()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @" SELECT Maintenances.MaintenanceID, (Vehicles.Make + ' ' + Vehicles.Model + ' ' + CAST(Vehicles.Year AS NVARCHAR)) AS Vehicle,
                                         Maintenances.Description, Maintenances.MaintenanceDate, Maintenances.Cost, Maintenances.Status,   
                                          Users.Username AS 'Created By'  
                                        FROM Maintenances INNER JOIN  
                                        Vehicles ON Maintenances.VehicleID = Vehicles.VehicleID INNER JOIN  
                                        Users ON Maintenances.CreatedByUserID = Users.UserID ";

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

        public static DataTable GetAllByVehicleID(int VehicleID)
        {

            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @" SELECT Maintenances.MaintenanceID, (Vehicles.Make + ' ' + Vehicles.Model + ' ' + CAST(Vehicles.Year AS NVARCHAR)) AS Vehicle,
                                         Maintenances.Description, Maintenances.MaintenanceDate, Maintenances.Cost, Maintenances.Status,   
                                         Users.Username AS 'Created By'  
                                         FROM Maintenances INNER JOIN  
                                        Vehicles ON Maintenances.VehicleID = Vehicles.VehicleID INNER JOIN  
                                        Users ON Maintenances.CreatedByUserID = Users.UserID  
                                         where Vehicles.VehicleID = @VehicleID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@VehicleID", VehicleID);

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
                clsEventLog.SaveEventLog(ex.Message,System.Diagnostics.EventLogEntryType.Error);
            }

            return dt;

        }


        public static bool? ReleaseVehicleAfterMaintenance(int MaintenanceID, int VehicleID)
        {
            object Release = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"Update Maintenances 
                                    set status = @status from Maintenances
                                    Where MaintenanceID = @MaintenanceID and VehicleID = @VehicleID 

                                    Update Vehicles set IsAvailable =@IsAvailable
                                    where Vehicles.VehicleID=@VehicleID";


                    using (SqlCommand commandRelease = new SqlCommand(query, connection))
                    {
                        commandRelease.Parameters.AddWithValue("@MaintenanceID", MaintenanceID);
                        commandRelease.Parameters.AddWithValue("@Status", "Completed");
                        commandRelease.Parameters.AddWithValue("@VehicleID", VehicleID);
                        commandRelease.Parameters.AddWithValue("@IsAvailable", true);

                        Release = commandRelease.ExecuteNonQuery();

                    }
                }

            }
            catch(SqlException ex)
            {
                clsEventLog.SaveEventLog(ex.Message,EventLogEntryType.Error);
            }



            return (Release != null);
        }

        public static bool IsMaintenanceCompleted(int MaintenanceID)
        {
            bool IsCompleted = false;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    Connection.Open();
                    string query = "SELECT * FROM Maintenances WHERE MaintenanceID =@MaintenanceID  AND Status = 'Completed'";
                    using (SqlCommand Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@MaintenanceID", MaintenanceID);

                        using (SqlDataReader reader = Command.ExecuteReader())
                        {
                            IsCompleted = reader.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsEventLog.SaveEventLog(ex.Message, EventLogEntryType.Error);
            }

            return IsCompleted;
        }

        public static int CountUnderMaintenance()
        {
            int count = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = " select count(*) from Maintenances where Status = 'On Process'  ";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        count = (int)command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                clsEventLog.SaveEventLog(ex.Message, EventLogEntryType.Error);
            }

            return count;
        }


        public static bool DeleteMaintenances(int? MaintenancesID)
        {
            int? rowsAffected = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"delete Maintenances where MaintenancesID = @MaintenancesID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaintenancesID", MaintenancesID);

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

        public static bool IsMaintenanceDateExist(string MaintenanceDate)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"SELECT Found=1 FROM Maintenances WHERE VehicleID = @Maintenances";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Maintenances", MaintenanceDate);

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
