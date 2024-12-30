using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_OOP_Demo
{
    internal class Cars
    {

        #region Attributes
        public int ID { get; set; }
        public string Model { get; set; }
        public Double Speed { get; set; }
        #endregion

        #region Constructor
      
        public Cars(int iD, string model, double speed)
        {
            ID = iD;
            Model = model;
            Speed = speed;
            Console.WriteLine("1");

        }

        public Cars(int iD, string model): this(iD,model,290) //constructor channing
        {
            //ID = iD;
            //Model = model;
            Console.WriteLine("2");
        }

        public Cars(int iD):this(iD,"Audi",350)
        {
            //ID = iD;
            Console.WriteLine("3");

        }
        #endregion

        #region Method
        public override string ToString()
        {
            return $"ID : {ID}\nMode : {Model}\nSpeed : {Speed}";
        }
        #endregion

    }
}
