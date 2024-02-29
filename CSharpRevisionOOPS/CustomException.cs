using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRevisionOOPS
{
    public class CustomException
    {
        public static void Main(string[] args)
        {
            throw new StudentNameException("Invalid student name");
        }
    }

    public class StudentNameException:Exception
    {
        public StudentNameException(string message) : base(message) { 
                Console.WriteLine(message);
        }
    }
}
