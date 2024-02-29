using System;

namespace CSharpRevisionOOPS
{
    class Program
    {
        public static void Main(string[] args)
        {
            Program p=new Program();
            p.EvenNumber();
        }

        //Method
        public void EvenNumber()
        {
            int start = 0;
            while (start<=10)

            {
                Console.WriteLine(start);
                start = start + 2;
            }
        }
    }
}
