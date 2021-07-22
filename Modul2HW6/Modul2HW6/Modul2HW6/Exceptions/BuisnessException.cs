using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW6.Exceptions
{
    public class BuisnessException : Exception
    {
        public BuisnessException(string message)
            : base(message)
        {
        }
    }
}
