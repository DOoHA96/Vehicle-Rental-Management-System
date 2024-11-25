using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalDataAccess;

namespace RentalBusinessLayer
{
    public class clsCustomer
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode? Mode = null;
        public int? CustomerID { set; get; }
        public string Name { set; get; }
        public string PhoneNumber { set; get; }
        public string Email { set; get; }
        public string Address { set; get; }
        public DateTime DateOfBirth { set; get; }
        public short Gender { set; get; }
        public string LicenseNumber { set; get; }
        public string ImagePath { set; get; }

        public clsCustomer()
        {
            this.CustomerID = null;
            this.Name = string.Empty;
            this.PhoneNumber = string.Empty;
            this.Email = string.Empty;
            this.Address = string.Empty;
            this.DateOfBirth = DateTime.Now.AddYears(-16);
            this.Gender = 0 ;
            this.LicenseNumber = string.Empty;
            this.ImagePath = null;

            Mode = enMode.AddNew;
        }

        private clsCustomer(int? customerID, string name, string phoneNumber, string email,
            string address, DateTime dateOfBirth, short gender, string licenseNumber, string imagePath)
        {
            CustomerID = customerID;
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            LicenseNumber = licenseNumber;
            ImagePath = imagePath;

            Mode = enMode.Update;
        }

        private bool _AddNew()
        {
            this.CustomerID = clsCustomerData.AddNewCustomer(this.Name, this.PhoneNumber, this.Email,
                this.Address, this.DateOfBirth, this.Gender, this.LicenseNumber, this.ImagePath);

            return (this.CustomerID != null);
        }

        public static clsCustomer Find(int? customerID)
        {
            string Name = null;
            string PhoneNumber = null;
            string Email = null;
            string Address = null;
            DateTime DateOfBirth = DateTime.Now;
            short Gender = 0;
            string LicenseNumber = null;
            string ImagePath = null;

            bool? Isfound = clsCustomerData.GetCustomerInfoByID(customerID, ref Name, ref PhoneNumber, ref Email,
                ref Address, ref DateOfBirth, ref Gender, ref LicenseNumber, ref ImagePath);

            if (Isfound.HasValue)
                return new clsCustomer(customerID, Name, PhoneNumber, Email, Address, DateOfBirth, Gender,
                    LicenseNumber, ImagePath);
            else
                return null;

        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNew())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _Update();

            }

            return false;
        }

        public static DataTable GetAllCustomers()
        {
            return clsCustomerData.GetAllCustomer();
        }

        private bool _Update()
        {
            return clsCustomerData.UpdateCustomer(this.CustomerID, this.Name, this.PhoneNumber,
                this.Email, this.Address, this.DateOfBirth, this.Gender, this.LicenseNumber, this.ImagePath);
        }

        public static bool DeleteCustomer(int? customerID)
        {
            return clsCustomerData.DeleteCustomer(customerID);
        }

        public static bool IsCustomerExist(int? customerID)
        {
            return clsCustomerData.IsCustomerExist(customerID);
        }
    }
}
