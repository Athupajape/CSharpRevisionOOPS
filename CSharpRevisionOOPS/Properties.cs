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
        private string _employeeType="FullTime";

        public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Name cannot be null");
            }
            else
            {
                this._name = Name;
            }     
        }

        public string GetName()
        {
            return this._name;
        }

        public void SetAge(int Age)
        {
            if (Age <= 18)
            {
                throw new Exception("You are not eligible");
            }
            else
            {
                this._age = Age;
            }
        }

        public int GetAge()
        {
            return this._age;
        }

        public string GetEmployeeType()
        {
            return this._employeeType;
        }
    }

    
    public class Properties
    {
        public static void Main()
        {
            Employee employee = new Employee();
            employee.SetName("Abhinav");
            employee.SetAge(20);
            Console.WriteLine("The details are : " + employee.GetName() + " " + employee.GetAge() + " " + employee.GetEmployeeType());
        }
    }
}
