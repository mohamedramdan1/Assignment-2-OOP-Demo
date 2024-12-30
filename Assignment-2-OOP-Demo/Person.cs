using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_OOP_Demo
{
    internal struct Person
    {
       
        #region Attribute
        public string Name { get; set; }
        public int Age { get; set; }
        #endregion

        #region Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{Name} : {Age}";
        }
        #endregion
    }
}
