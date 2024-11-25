using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalDataAccess;

namespace RentalBusinessLayer
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode? Mode = null;
        public int? UserID { set; get; }
        public string Name { set; get; }
        public string PhoneNumber { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public bool IsActive { set; get; }
        public string Address { set; get; }
        public string ImagePath { set; get; }

        public clsUser()
        {
            this.UserID = null;
            this.Name = string.Empty;
            this.PhoneNumber = string.Empty;
            this.UserName = string.Empty;
            this.Password = string.Empty;
            this.IsActive = false;
            this.Address = string.Empty;
            this.ImagePath = null;

            Mode = enMode.AddNew;
        }

        private clsUser(int? UserID, string name, string phoneNumber, string UserName,
            string Password, bool IsActive,string Address, string imagePath)
        {
            this.UserID = UserID;
            Name = name;
            this.PhoneNumber = phoneNumber;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
            this.Address = Address;
            ImagePath = imagePath;

            Mode = enMode.Update;
        }

        private bool _AddNew()
        {
            this.UserID = clsUserData.AddNewUser(this.Name, this.PhoneNumber, this.UserName,
                this.Password,this.IsActive, this.Address, this.ImagePath);

            return (this.UserID != null);
        }

        public static clsUser Find(int? UserID)
        {
            string Name = null;
            string PhoneNumber = null;
            string username = null;
            string password = null;
            bool IsActive = false;
            string addres = null;
            string ImagePath = null;

            bool? Isfound = clsUserData.GetUserInfoByID(UserID, ref Name, ref PhoneNumber, ref username,
                ref password,ref IsActive, ref addres, ref ImagePath);

            if (Isfound.HasValue)
                return new clsUser(UserID, Name, PhoneNumber, username, password,IsActive,
                    addres, ImagePath);
            else
                return null;

        }

        public static clsUser Find(string UserName,string Password)
        {
            int? UserID = null;
            string Name = null;
            string PhoneNumber = null;
            bool IsActive = false;
            string addres = null;
            string ImagePath = null;

            bool? Isfound = clsUserData.GetUserInfoByUserNameAndPassword(ref UserID, ref Name, ref PhoneNumber,UserName,
                Password, ref IsActive, ref addres, ref ImagePath);

            if (Isfound.HasValue)
                return new clsUser(UserID, Name, PhoneNumber, UserName, Password, IsActive,
                    addres, ImagePath);
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

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUser();
        }

        private bool _Update()
        {
            return clsUserData.UpdateUser(this.UserID, this.Name, this.PhoneNumber,
                this.UserName, this.Password,this.IsActive, this.Address, this.ImagePath);
        }

        public static bool DeleteUser(int? UserID)
        {
            return clsUserData.DeleteUser(UserID);
        }

        public static bool IsUserNameExist(string UserName)
        {
            return clsUserData.IsUserNameExist(UserName);
        }
    }
}
