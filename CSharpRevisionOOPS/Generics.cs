using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRevisionOOPS
{
    public class Generics
    {
         public static void Main(string[] args)
        {
            bool result = Compare.Equal<string>("A","A");
            if (result == true)
            {
                Console.WriteLine("Value are equal");
            }
            else
            {
                Console.WriteLine("Value are not equal");
            }
        }   
    }

    public class Compare
    {
        public static bool Equal<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
