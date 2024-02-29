using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRevisionOOPS
{
  
    public class Delegates
    {
        public delegate void HelloWorldDelegate(string msg);

        public static void HelloWorld(string message)
        {
            Console.WriteLine(message);
        }


        public static void Main(string[] args)
        {
            HelloWorldDelegate helloworld = new HelloWorldDelegate(HelloWorld);
            helloworld("Delegates");
        }
    }
}
