using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRevisionOOPS
{
    public abstract class Employee
    {
        public abstract void print();
        public void draw()
        {
            Console.WriteLine("Drawing");
        }
    }

    public class AbstractEmployee :Employee
    {
        public override void print()
        {
            Console.WriteLine("Printing");
        }

        public static void Main(string[] args)
        {
            Employee employee = new AbstractEmployee();
            employee.print();
            employee.draw();
        }
    }
}
