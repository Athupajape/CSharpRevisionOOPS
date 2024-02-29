using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRevisionOOPS
{
    public class Employee
    {
        private string _name;
        private int _age;
        private string _employeeType = "FullTime";
        private string _email;

        //Automimplemented property
        public string Email { get; set; }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be null");
                }
                else
                {
                    this._name = value;
                }
            }
            get
            {
                return this._name;
            }
        }
        
        public int Age
        {
            set
            {
                if (value <= 18)
                {
                    throw new Exception("You are not eligible");
                }
                else
                {
                    this._age = value;
                }
            }
            get
            {
                return this._age;
            }
        }

        public string EmployeeType
        {
            get
            {
                return this._employeeType;
            }
        }
    }

    public class GetterSetter
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "Abhinav";
            employee.Age = 22;
            employee.Email = "test@gmail.com";
            Console.WriteLine("The details are : " + employee.Name + " " + employee.Age + " " + employee.EmployeeType+" "+ employee.Email);
        }
    }
}
