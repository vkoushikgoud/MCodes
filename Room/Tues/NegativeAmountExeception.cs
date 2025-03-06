using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tues
{
    public class NegativeAmountExeception : ApplicationException
    {
        public NegativeAmountExeception(string message) : base(message)
        {
        }
    }
}
