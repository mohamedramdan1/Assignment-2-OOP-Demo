using System.Transactions;
using Assignment_2_OOP_Demo.Encapsulation;

namespace Assignment_2_OOP_Demo
{
    internal class Program
    {
        static int count = 0;
        public static int Compare_Employees_By_HireDate(Employees e1, Employees e2)
        {
            count += 2; // Count boxing/unboxing when comparing
            return HiringDate.Compare(e1.Hiredate, e2.Hiredate);
        }
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

            #region Assignment
            #region Part01
            #region Q1
            //the Demo we try all what we learned in lec
            #endregion
            #endregion

            #region Part02
            #region Q1
            //Person[] person = new Person[3];
            //person[0] = new Person("Ali",23);
            //person[1] = new Person("Mohamed",30);
            //person[2] = new Person("Nora",15);
            //Console.WriteLine("Details of Persons Name : Age >> ");
            //for (int i = 0; i < person.Length; i++)
            //{
            //    Console.WriteLine(person[i]);
            //}
            #endregion

            #region Q2
            //Person[] person = new Person[3];
            //string name;
            //int age;
            //bool Flag;
            //for (int i = 0; i < person.Length;)
            //{
            //    Console.WriteLine($"Enter the person {i+1} details : ");
            //    Console.Write($"Name [{i+1}] : "); 
            //    name = Console.ReadLine();
            //    Console.Write($"Age [{i+1}] : ");
            //    Flag = int.TryParse(Console.ReadLine(), out age);
            //    if ( Flag && age > 0 )
            //    {
            //        person[i] = new Person(name, age);
            //        i++;
            //    }
            //    else
            //    {
            //        Console.WriteLine(" ");
            //        Console.WriteLine("Invalid input. Please enter a valid name and a positive integer for age.");
            //        Console.WriteLine(" ");
            //    }
            //}

            //Person oldestperson = person[0];
            //for (int i = 0; i < person.Length; i++)
            //{
            //    if (person[i].Age > oldestperson.Age)
            //    {
            //        oldestperson = person[i];
            //    }
            //}
            //Console.WriteLine(" ");
            //Console.WriteLine($"The oldest person is: {oldestperson.Name} , Age: {oldestperson.Age}");
            #endregion
            #endregion

            #region Part03
            #region Q1, Q2 , Q3 , Q4 , Q5 
            //all in Class Emolpyees.cs 
            #endregion

            #region Q6 , Q7
            //Employees[] EmpArr = new Employees[3];
            //EmpArr[0] = new Employees(1, "Mohamed", 80000, new HiringDate(15, 5, 2010), SecurityLevel.DBA, "M");
            //EmpArr[1] = new Employees(2, "Gamal", 40000, new HiringDate(10, 3, 2000), SecurityLevel.Guest, "M");
            //EmpArr[2] = new Employees(3, "Mona", 60000, new HiringDate(25, 12, 2023), SecurityLevel.Secretary, "F");

            //Console.WriteLine("Employees before sorting By HireDate : ");
            //for (int i = 0; i < EmpArr.Length; i++)
            //{
            //    Console.WriteLine(EmpArr[i]);
            //}

            //Array.Sort(EmpArr,Compare_Employees_By_HireDate);
            //Console.WriteLine("");
            //Console.WriteLine("Employees After sorting By HireDate : ");
            //for (int i = 0; i < EmpArr.Length; i++)
            //{
            //    Console.WriteLine(EmpArr[i]);
            //}
            //Console.WriteLine("");
            //Console.WriteLine($"Times Boxing and Unboxing process has occurred :  {count}");


            #endregion
            #endregion
            #endregion
        } 
    }
} 
