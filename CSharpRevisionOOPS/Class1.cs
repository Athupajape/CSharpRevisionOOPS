using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRevisionOOPS
{
    public class Employee
    {
        string _firstName;
        string _lastName;

        //Constructor overdiding
        public Employee() :this("firstname not provided","lastname not provided")
        {
        }

        public Employee(string firstName, string LastName)
        {
            this._firstName = firstName;
            this._lastName = LastName;
        }

        public void print()
        {
            Console.WriteLine("The FirrstName is {0} and the Lastname is {0}",this._firstName, this._lastName);
        }
    }
    public class Class1
    {
        public static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.print();
            Employee emp1=new Employee("automation","website");
            emp1.print();
        }        
    }
}
