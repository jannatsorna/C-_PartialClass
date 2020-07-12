using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Class
{
    class Program
    {
        //passing value by constructor in partial class
        public partial class Student
        {
            public int id { get; set; }
            public string name { get; set; }
        }
        public partial class Student
        {
            public Student()
            {
                id = 2;
                name = "Sorna";
                cg = 3.65;
            }
        }
        public partial class Student
        {
            public double cg { get; set; }
            public void Get_Details()
            {
                Console.WriteLine("Student Id : {0}", id);
                Console.WriteLine("Student Name : {0}", name);
                Console.WriteLine("Student CG : {0}", cg);
            }
        }



        //pushing value in a list in partial class
        public partial class Employee
        {
            public string name { get; set; }
            public int id { get; set; }
        }
        public partial class Employee
        {
            public double salary { get; set; }
            public string address { get; set; }
        }
        public partial class Employee
        {
            public List<Employee> Employee_Details()
            {
                Employee elist_1 = new Employee();
                elist_1.name = "John";
                elist_1.id = 2;
                elist_1.salary = 75000;
                elist_1.address = "Bashundhara,Dhaka";
                
                Employee elist_2 = new Employee();
                elist_2.name = "John";
                elist_2.id = 34;
                elist_2.salary = 75000;
                elist_2.address = "Banani";

                List<Employee> eobj = new List<Employee>();
                {
                    eobj.Add(elist_1);
                    eobj.Add(elist_2);
                }
                foreach (Employee data in eobj)
                {
                    Console.WriteLine("Employee Name : {0},Employee Id : {1},Employee Salary : {2},Address : {3}", data.name, data.id, data.salary,data.address);
                }
                return eobj;
            }
        }

            static void Main(string[] args)
            {
                Student _std = new Student();
                _std.Get_Details();

                Employee e = new Employee();
                List<Employee> elist = new List<Employee>();
                elist = e.Employee_Details();

                Console.ReadLine();
            }
        }
    }
