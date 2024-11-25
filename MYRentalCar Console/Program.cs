using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using RentalBusinessLayer;
using System.Data;
using RentalDataAccess;


namespace MYRentalCar_Console
{
    internal class Program
    {
        public static void AddNewCustomer()
        {
            clsCustomer customer = new clsCustomer();

            customer.Name = "Ahmed Hussien";
            //customer.PhoneNumber = "1234567890";
            customer.Email = "Email";
            customer.Address = "Address";
            customer.DateOfBirth = DateTime.Now;
            customer.Gender = 1;
            customer.LicenseNumber = "1234567890";

            if (customer.Save())
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }

        public static void GetAllCustomers()
        {
            DataTable dt = clsCustomer.GetAllCustomers();

            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine($"Name {dr["Name"]}");
            }
        }

        public static void FindCustomer(int CustomerID)
        {
            clsCustomer customer = clsCustomer.Find(CustomerID);

            if(customer != null)
            {
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.PhoneNumber);
            }
        }

        public static void UpdateCustomers(int CustomerID)
        {
            clsCustomer customer = clsCustomer.Find(CustomerID);

            if (customer != null)
            {
                customer.Name = "Dooha ";

                if (customer.Save())
                    Console.WriteLine("True");
                else
                    Console.WriteLine("False");
            }
            else
                Console.WriteLine("Null");

        }

        public static void DeleteCustomer(int CustomerID)
        {
            if (clsCustomer.DeleteCustomer(CustomerID))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }    

        public static void IsCustomerExist(int CustomerID)
        {
            if(clsCustomer.IsCustomerExist(CustomerID))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }

        public static void findCustomer()
        {
            clsCustomer customer = clsCustomer.Find(3);
            if (customer == null)
                Console.WriteLine("NULL");
            else
                Console.WriteLine("Not NULL");
        }

        public static void AddUser()
        {
            clsUser User = new clsUser();

            User.Name = "Abas";
            User.PhoneNumber = "123123321123";
            User.UserName = "User1";
            User.Password = "1234";
            User.Address = "ElRooda Street";
            User.IsActive = true;
           
            if(User.Save())
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }

        public static void FindUser(int UserID)
        {
            clsUser user = clsUser.Find(UserID);

            if (user == null)
                Console.WriteLine("NULL");
            else
                Console.WriteLine("Not NULL");
        }

        public static void UpdateUser(int UserID)
        {
            clsUser user = clsUser.Find(UserID);

            if (user != null)
            {
                user.UserName = "User10";
                user.IsActive = false;

                if (user.Save())
                    Console.WriteLine("True");
                else
                    Console.WriteLine("False");
            }
            else
                Console.WriteLine("NULL");
        }

        public static void GetAllUsers()
        {
            DataTable dt = clsUser.GetAllUsers();

            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine($"{dr["FullName"]}");
            }
        }

        public static void FindByuserNameAndPassword(string userName, string password)
        {
            clsUser user = clsUser.Find(userName, password);

            if (user != null)
                Console.WriteLine("NOT NULL");
            else
                Console.WriteLine("NULL");
        }

        public static void AddNewFuelType()
        {
            clsFuelTypes fuel = new clsFuelTypes();
            fuel.FuelType = "Desal";

            if (fuel.Save())
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }

        public static void FindFuelType(int FuelTypeID)
        {
            clsFuelTypes fuel = clsFuelTypes.Find(FuelTypeID);

            if (fuel != null)
                Console.WriteLine(fuel.FuelType);
            else
                Console.WriteLine("NULL");
        }

        public static void UpdateFuelType(int FuelTypeID)
        {
            clsFuelTypes fuel = clsFuelTypes.Find(FuelTypeID);

            if (fuel != null)
            {
                fuel.FuelType = "Desal22";

                if (fuel.Save())
                    Console.WriteLine("True");
                else
                    Console.WriteLine("False");
            }    
            else
                Console.WriteLine("NULL");
        }

        public static void AddNewVehicles()
        {
            clsVehicle vehicle = new clsVehicle();

            vehicle.Make = "Make1";
            vehicle.Model = "Model1";
            vehicle.Year = 303;
            vehicle.Milage = 3;
            vehicle.FuelTypeID = 1;
            vehicle.PlateNumber = "lkjdf";
            vehicle.VehicleCategoryID = 1;
            vehicle.PricePerDay = 1;
            vehicle.IsAvailable = true;
            vehicle.ImagePath = "Image";

            if (vehicle.Save())
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

        }

        public static void UpdateVehicle(int VehicleTypeID)
        {
            clsVehicle vehicle = clsVehicle.Find(VehicleTypeID);

            if (vehicle != null)
            {
                vehicle.IsAvailable = false;
                vehicle.Make = "Update";

                if (vehicle.Save())
                    Console.WriteLine("True");
                else
                    Console.WriteLine("False");
            }
            else
                Console.WriteLine("NULL");
        }

        public static void AddNewMaintance()
        {
            clsMaintenances maintenances = new clsMaintenances();

            maintenances.VehicleID = 1;
            maintenances.Description = "Sescription";
            maintenances.MaintenanceDate = DateTime.Now;
            maintenances.Cost = 10;
            maintenances.Status = "NOt Complete";
            maintenances.CreatedByUserID = 1;

            if (maintenances.Save())
            {

                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        public static void UpdateMaintenance(int MaintanceID)
        {
            clsMaintenances Maintance = clsMaintenances.Find(MaintanceID);

            if (Maintance != null)
            {
                Maintance.Cost= 100;
                Maintance.Status = "Maintance";

                if(Maintance.Save())
                    Console.WriteLine("True");
                else
                    Console.WriteLine("False");
            }
            else
                Console.WriteLine("NULL");


        }

        public static void GetAllMaintanceByVehicleID(int vehicleID)
        {
            DataTable dt = clsMaintenances.GetAllByVehicleID(vehicleID);

            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine($" {dr[0]}");
            }
        }

        public static void ReleaseVehicleAfterMaintenance(int MaintenanceID, int VehicleID)
        {
            if (clsMaintenances.ReleaseVehicleAfterMaintenance(MaintenanceID, VehicleID))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }

        public static void IsMaintenanceCompleted(int MaintenanceID)
        {
            if(clsMaintenances.IsMaintenanceCompleted(MaintenanceID))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }

        public static void AddNewDocument()
        {
            clsDocuments documents = new clsDocuments();

            documents.CustomerID = 1;
            documents.Name = "Test";
            documents.Path = "Path";
            documents.CreatedBy = 1;

            if (documents.Save())
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }

        public static void UpdateDocument(int DocumentID)
        {
            clsDocuments Document = clsDocuments.Find(DocumentID);

            if (Document != null)
            {
                Document.Name = "UPdated Name";
                Document.Path = "UPdated Path";

                if (Document.Save())
                    Console.WriteLine("True");
                else
                    Console.WriteLine("False");
            }
            else
                Console.WriteLine("NULL");
        }

        public static void GetAllDocuments(int CustomerID)
        {
            DataTable dt = clsDocuments.GetAll(CustomerID);

            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine($"{dr["Name"]}");
            }
        }

        public static void AddNewBookings()
        {
            clsBookings book = new clsBookings();

            book.CustomerID = 1;
            book.VehicleID = 1;
            book.StartDate = new DateTime(2024, 11, 1);
            book.EndDate = new DateTime(2024, 11, 4);
            book.DropoffLocation = "Location1";
            book.PickupLocation = "Localtion2";
            book.PricePerDay = 10;
            book.InitialTotalDueAmount = 50;
            book.Status = "oningin";
            book.Notes = "Notes";
            book.CreatedByUserID = 1;

            if (book.Save())
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }

        public static void UpdateBookings(int bookID)
        {
           clsBookings book = clsBookings.Find(bookID);

            if (book != null)
            {
                book.Status = "ongoing";

                if (book.Save())
                    Console.WriteLine("True");
                else
                    Console.WriteLine("False");
            }    
            else
                Console.WriteLine("NULL");
        }

        public static void AddNewReturns()
        {
            clsReturns returns = new clsReturns(); 

            returns.ActualReturnDate = DateTime.Now;
            returns.ActualRentalDays = 1;
            returns.ConsumedMilage = 300;
            returns.FinalCheckNotes = "Final Notes";
            returns.AdditionalCharges = 10;
            returns.ActualTotalDueAmount = 50;
            returns.CreatedByUserID = 1;

            if(returns.Save())
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }

        public static void UpdateReturns(int returns)
        {
            clsReturns Returns = clsReturns.Find(returns);

            if (Returns != null)
            {
                Returns.FinalCheckNotes = "Updated Notes";
                Returns.ConsumedMilage = 1000;

                if(Returns.Save())
                    Console.WriteLine("True");
                else
                    Console.WriteLine("False");
            }    
            else
                Console.WriteLine("NULL");
        }

       public static void GetAppBook()
        {
            DataTable dt = clsBookings.GetAll();

            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine($"{dr["BookingID"]}  Customer: {dr["Customer"]}");
            }
       }

        public static void GetAppBookByCustomer(string Customer)
        {
            DataTable dt = clsBookings.GetAllByCustomer(Customer);

            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine($"{dr["BookingID"]}  Customer: {dr["Customer"]}");
            }
        }

        public static void GetAllRreturns()
        {
            DataTable dt = clsReturns.GetAll();

            foreach(DataRow dr in dt.Rows)
            {
                Console.WriteLine($"{dr["ReturnID"]}  {dr["ActualRentalDays"]} {dr["ConsumedMilage"]}");
            }
        }

        public static void AddNewPayment()
        {
            clsPayments payment = new clsPayments();

            payment.BookingID = 1;
            //payment.ReturnID = 1;
            payment.Details = "NO Details";
            payment.InitialPaidTotalDueAmount = 300;
            //payment.ActualTotalDueAmount = 30;
            //payment.TotalRemaining = 10;
            //payment.TotalRefundedAmount = 30;
            payment.PaymentDate = DateTime.Now;
            //payment.UpdatedPaymentDate = DateTime.Now;
            payment.CreatedByUserID = 1;

            if (payment.Save())
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

        }

        public static void UpdatePayment(int PaymentID)
        {
            clsPayments payment = clsPayments.Find(PaymentID);

            if (payment != null)
            {
                payment.ReturnID = null;
                payment.Details = null;
                payment.ActualTotalDueAmount = null;
                payment.TotalRemaining = null;
                payment.TotalRefundedAmount = null;


                if(payment.Save())
                    Console.WriteLine("True");
                else
                    Console.WriteLine("False");
            }    
            else
                Console.WriteLine("NULL");
        }

        public static void GetAllReservation(int VehicleID)
        {
            DataTable dt = clsVehicle.GetAllReservationsByVehicleID(VehicleID);

            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine($"{dr["bookingID"]}");
            }
        }

        public static void FindPayment(int paymentID)
        {
            clsPayments payment= clsPayments.Find(paymentID);
            if (payment != null)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }

        public static void ReturnUpdate()
        {
            clsBookings book = clsBookings.Find(1);
            if(book == null)
            {
                Console.WriteLine("book is NULL");
                return;
            }
            clsPayments payments = clsPayments.Find(1);
            if (payments == null)
            {
                Console.WriteLine("payment is NULL");
                return;
            }
            clsReturnAndUpdate Return = new clsReturnAndUpdate();

            Return.ActualReturnDate = DateTime.Now;
            Return.ActualRentalDays = 5;
            Return.ConsumedMilage = 505;
            Return.FinalCheckNotes = "Final Notes";
            Return.AdditionalCharges = 5;
            Return.ActualTotalDueAmount = 999;
            Return.CreatedByUserID = 1;
            Return.InitialPaidTotalDueAmount = payments.InitialPaidTotalDueAmount;
            Return.VehicleID=book.VehicleID;
            Return.Milage=book.VehicleInfo.Milage;
            Return.PaymentID=payments.PaymentID;
            Return.BookingID=book.BookingID;

            if (Return.Save())
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            
        }

        

        static void Main(string[] args)
        {
            //AddNewCustomer();
            //GetAllCustomers();
            //UpdateCustomers(1);
            //DeleteCustomer(3);
            //IsCustomerExist(3);
            //findCustomer();
            //AddUser();
            //FindUser(2);
            //UpdateUser(1);
            //GetAllUsers();
            //FindByuserNameAndPassword("User1", "1234");
            //AddNewFuelType();
            //FindFuelType(1);
            //UpdateFuelType(1);
            //AddNewVehicles();
            //UpdateVehicle(1);
            //AddNewMaintance();
            //UpdateMaintenance(1);
            //GetAllMaintanceByVehicleID(1);
            //ReleaseVehicleAfterMaintenance(1, 1);
            //IsMaintenanceCompleted(1);
            //Console.WriteLine(clsMaintenances.CountUnderMaintenance());
            //AddNewDocument();
            //UpdateDocument(1);
            //GetAllDocuments();
            //AddNewBookings();
            //UpdateBookings(1);
            //GetAppBook();
            //GetAppBookByCustomer("Dooha");
            //Console.WriteLine(clsBookings.CountBookings());
            //AddNewReturns();
            //UpdateReturns(1);
            //GetAllRreturns();
            //AddNewPayment();
            //UpdatePayment(1);
            //Console.WriteLine(clsPayments.GetTotalRevenueByMonth(11));
            //GetAllReservation(1);
            //ReturnUpdate();
            // FindPayment(1);
            //Console.WriteLine(clsVehicle.CountVehiclesByCategory("Sedan"));
            //AddNewPayment();
            Console.WriteLine(clsBookings.CountOnRent());


        }
    }
}
