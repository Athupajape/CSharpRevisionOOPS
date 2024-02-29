using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRevisionOOPS
{
    public class Enums
    {
        public static void Main(string[] args)
        {
            short[] emp = (short[])Enum.GetValues(typeof(Gender));
            foreach (int i in emp)
            {
                Console.WriteLine("Employee type is : {0}", i);
            }

            string[] empnames = Enum.GetNames(typeof(Gender));
            foreach (string i in empnames)
            {
                Console.WriteLine("Employee gender is : {0}", i);
            }
        }

        public enum Gender :short
        {
            Unknown=1,
            Male,
            Female=6
        }
    }    
}
