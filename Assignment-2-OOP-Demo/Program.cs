using Assignment_2_OOP_Demo.Encapsulation;

namespace Assignment_2_OOP_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Demo
            #region Encapsulation
            //Employee employee = new Employee(10, "mohamed", 6000);
            //Console.WriteLine(employee);// it will return object it will case to use boxing and un boxing but we use it for redabilty
            //Console.WriteLine(employee.ToString());// it is the best becouse it will return string 

            #region Before Encapsulation
            //employee.Id = 100;
            //Console.WriteLine(employee.Id);
            #endregion

            #region After Encapsulation
            #region Setter - Getter
            //employee.SetName("Ali");
            //Console.WriteLine(employee.GetName());
            #endregion

            #region Property
            // Types of property in c#
            //1. full property : have validation in set 
            //2. automatic property: dont have validaton 
            //3. indexer
            //employee.Salary = 5000;
            //Console.WriteLine(employee.Salary);
            //Console.WriteLine(employee.Deduction);
            #endregion
            #endregion
            #endregion

            #region PhoneBook Ex
            //PhoneBook Notes = new PhoneBook(3);
            //Notes.Addperson(0, "Ali", 123);
            //Notes.Addperson(1, "Nora", 456);
            //Notes.Addperson(2, "Mohamed", 789);

            //Console.WriteLine(Notes.Getnumber("nora"));
            //Notes.setNumber("Nora", 999);
            //Console.WriteLine(Notes.Getnumber("Nora"));

            //Notes["Nora"] = 999;//Indexer
            //Console.WriteLine(Notes["Nora"]);

            //for (int i = 0; i < Notes.Size; i++)
            //{
            //    Console.WriteLine(Notes[i]);
            //}
            #endregion

            #region Cars
            //Cars c01 = new Cars(10, "BMW" , 250);
            //Cars c01 = new Cars(10);
            //Console.WriteLine(c01);
            #endregion
            #endregion
        }
    }
}
