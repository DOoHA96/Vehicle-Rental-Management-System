using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalDataAccess;

namespace RentalBusinessLayer
{
    public class clsCategories
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode? Mode = null;
        public int? CategoryID { set; get; }
        public string CategoryName { set; get; }
        public clsCategories()
        {
            this.CategoryID = null;
            this.CategoryName = null;

            Mode = enMode.AddNew;
        }
        private clsCategories(int? CategoryID, string CategoryName)
        {
            this.CategoryID = CategoryID;
            this.CategoryName = CategoryName;

            Mode = enMode.Update;
        }
        private bool _AddNew()
        {
            this.CategoryID = clsCategoryData.AddNewCategory(this.CategoryName);

            return (this.CategoryID != null);
        }
        private bool _Update()
        {
            return clsCategoryData.UpdateCategory(this.CategoryID, this.CategoryName);
        }
        public static clsCategories Find(int? CategoryID)
        {
            string CategoryName = null;

            bool? IsFound = clsCategoryData.GetCategoryInfoByID(CategoryID, ref CategoryName);

            if (IsFound.HasValue)
                return new clsCategories(CategoryID, CategoryName);
            else
                return null;
        }

        public static clsCategories FindByName(string CategoryName)
        {
            int? CategoryID = null;

            bool? IsFound = clsCategoryData.GetCategoryInfoByName(ref CategoryID, CategoryName);

            if (IsFound.HasValue)
                return new clsCategories(CategoryID, CategoryName);
            else
                return null;
        }
        public static bool Delete(int? CategoryID)
        {
            return clsCategoryData.DeleteCategory(CategoryID);
        }
        public static DataTable GetAll()
        {
            return clsCategoryData.GetAllCategory();
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
    }
}
