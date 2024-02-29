using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRevisionOOPS
{
    public interface IEmployee
    {
        public void Print();
        //int i=5 we cannot initialize instance variables.
        // but we can initialize static varibales.
        static int i = 5;
        
    }

    public class Employee : IEmployee
    {
        public void Print()
        {
            Console.WriteLine("HELLO"); 
        }
    }


    public class Interfaces
    {
        public static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Print();
        }
    }
}
