using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Class_Practice
{
    public partial class PartialClass
    {
        public string GetFullName()
        {
            return FirstName + ", " + LastName;
        }
    }
}
