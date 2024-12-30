using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_OOP_Demo
{
    enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }
    internal class HiringDate
    {
       
        #region Atrributes
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        #endregion

        #region Constructor
        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }

        public static int Compare(HiringDate d1 , HiringDate d2)
        {
            if (d1 == null || d2 == null)
            {
                return -1;

            }
            DateTime date01 = new DateTime(d1.Year ,d1.Month ,d1.Day);
            DateTime date02 = new DateTime(d2.Year , d2.Month, d2.Day);
            return date01.CompareTo(date02);
        }
        #endregion
    }
    internal class Employees
    {
        #region Attrubutes
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public HiringDate Hiredate { get; set; }
        public SecurityLevel Security{ get; set; }

        private string gender;
        #endregion

        #region Constructor
        public Employees(int iD, string name, decimal salary, HiringDate hiredate, SecurityLevel security, string gender)
        {
            ID = iD;
            Name = name;
            Salary = salary;
            Hiredate = hiredate;
            Security = security;
            Gender = gender;
        }
        #endregion

        #region Methods
        public string Gender // full property 
        {
            get
            {
                return gender;
            }
            set
            {
                if (value == "M" || value == "F")
                {
                    gender = value;
                }
                else
                {
                    Console.WriteLine("Gender must be 'M' or 'F'.");
                }
            }
        }

        public override string ToString()
        {
            return $"ID : {ID} , Name : {Name} , Security Level : {Security} , Salary : {Salary.ToString("C", CultureInfo.CurrentCulture)} , Hire Date : {Hiredate} , Gender : {Gender} ";
        }
        #endregion
    }
}
