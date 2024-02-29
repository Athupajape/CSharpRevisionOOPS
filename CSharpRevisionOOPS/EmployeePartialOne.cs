using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRevisionOOPS
{
    public partial class EmployeePartial
    {
        string _firstName;
        string _lastName;

        public string FirstName {
            get { return this._firstName; }
            set { this._firstName = value; }
        }
        public string LastName {
            get { return this._lastName; }
            set { this._lastName = value; }
        }
    }
}
