using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_OOP_Demo.Encapsulation
{
    internal struct Employee
    {
        #region Attribute
        public int Id;
        private string? EmpName;//nullable
        private decimal salary;// make it private and first char is small to usung propery
        #endregion

        #region Constructor
        public Employee(int id, string name, decimal _salary)
        {
            Id = id;
            EmpName = name;
            salary = _salary;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Id : {Id}\nName : {EmpName}\nSalary : {salary:c}";
        }
        #endregion

        #region Setter-Getter
        public string GetName()
        {
            return EmpName;
        }
        public void SetName(string? name)
        {
            EmpName = name?.Length > 5 ? name.Substring(0, 5) : name;
            //this.Name = name ;
        }
        #endregion

        #region Property
        // Types of property in c#
        //1. full property : have validation in set 
        //2. automatic property : dont have validaton 
        //3. indexer

        #region full property
        public decimal Salary // full proprty becouse it is have validation
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value > 5000 ? 5000 : value; // value take value we set in proprty 
            }
        }
        #endregion

        #region automatic property
        public int Age { get; set; }// it is automatic property we canot add validation
                                    // note the Age is property and assmbly file make the attribute is hidden attribute name backing field
        #endregion

        #region EX
        private decimal deduction;

        public decimal Deduction
        {
            get
            {
                return Salary * 0.2m;
            }
        }
        #endregion
        #endregion
    }
}
