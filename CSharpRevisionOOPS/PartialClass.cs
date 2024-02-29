using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRevisionOOPS
{
    public class PartialClass
    {
        public static void Main(string[] args)
        {
            EmployeePartial ep = new EmployeePartial();
            ep.FirstName = "Subhman";
            ep.LastName = "Gill";
            ep.GetFullName();
        }
    }
}
