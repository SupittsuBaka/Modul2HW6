using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW6.Models;

namespace Modul2HW6.Helpers
{
    public class PowerComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            var first = (x as Appliance)?.Power;
            var second = (y as Appliance)?.Power;
            if (!(x is Appliance))
            {
                first = 0;
            }

            if (!(y is Appliance))
            {
                second = 0;
            }

            if (first > second)
            {
                return 1;
            }
            else if (first < second)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
