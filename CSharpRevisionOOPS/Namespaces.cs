using System;
using AI = AIAutomation;
using UI = UIAutomation;

namespace CSharpRevisionOOPS
{
    class Program
    {
        public static void Main(string[] args)
        {
            AI.Class1 c1= new AI.Class1();
            c1.print();
            UI.Class1 c2= new UI.Class1();
            c2.print();
        }
    }
    
}

namespace AIAutomation
{
    class Class1
    {
        public void print()
        {
            Console.WriteLine("This class is from AI Automation");
        }
    }

}

namespace UIAutomation
{
    class Class1
    {
        public void print()
        {
            Console.WriteLine("This class is from UI Automation");
        }
    }
}