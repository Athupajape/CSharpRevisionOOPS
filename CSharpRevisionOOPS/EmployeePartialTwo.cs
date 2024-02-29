using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRevisionOOPS
{
    public partial class EmployeePartial
    {
        public void GetFullName()
        {
            Console.WriteLine("The FullName is : "+_firstName+" "+_lastName);
        }
    }
}
