using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRevisionOOPS
{
    public class Trainer
    {
        public string _firstName;
        public string _lastName;

        public void printFullName()
        {
            Console.WriteLine("The firtsname is : {0} and the lastname is : {1}",this._firstName,this._lastName);
        }
    }

    public class FullTimeTrainer : Trainer
    {
        public int _annualSalary;
    }

    public class PartTimeTrainer :Trainer
    {
        public int _partTimeSalary;
    }

    public class Inheritance
    {
        public static void Main(string[] args)
        {
            FullTimeTrainer f1 = new FullTimeTrainer();
            f1._firstName = "Roger";
            f1._lastName = "Binny";
            f1._annualSalary = 10000;
            f1.printFullName();
            Console.WriteLine("The AnnualSalary is :"+f1._annualSalary);

            PartTimeTrainer p1 = new PartTimeTrainer();
            p1._firstName = "Stuart";
            p1._lastName = "Binny";
            p1._partTimeSalary = 5000;
            p1.printFullName();
            Console.WriteLine("The PartTimeSalary is :" + p1._partTimeSalary);
        }
    }
}
