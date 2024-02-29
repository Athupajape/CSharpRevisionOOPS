using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRevisionOOPS
{
    public class SavingsAccount :ISavingsAccount
    {
        public void printDetails()
        {
            Console.WriteLine("Here are the details");
        }
    }

    public class Account : IAccount
    {
        public ISavingsAccount _savingsacc;

        public Account(ISavingsAccount savingsAccount)
        {
            //tight coupling
            //SavingsAccount sa = new SavingsAccount();

            //Dependancy injection
            _savingsacc = savingsAccount;
            
        }

        public void PrintSavingsDetails()
        {
            _savingsacc.printDetails();
        }
    }

    public class DependancyInjection
    {
        public static void Main()
        {
            // Still there is tight coupling due to new keyword.
            //ISavingsAccount savingsAccount = new SavingsAccount();
            //IAccount account = new Account(savingsAccount);

            //Account account = new Account();

            IAccount account=Container.ContainerConfig().GetRequiredService<IAccount>();

            account.PrintSavingsDetails();
        }
    }
}
