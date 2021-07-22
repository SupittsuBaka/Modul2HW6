using Modul2HW6.Enums;
using Modul2HW6.Models;

namespace Modul2HW6.Helpers
{
    public static class ApplianceExtensions
    {
        public static Appliance[] FindByColor(this Appliance[] appliances, Color color)
        {
            var counter = 0;
            foreach (var item in appliances)
            {
                if (item != null && item.Color == color)
                {
                    counter++;
                }
            }

            var result = new Appliance[counter];

            foreach (var item in appliances)
            {
                if (item != null && item.Color == color)
                {
                    result[--counter] = item;
                }
            }

            return result;
        }
    }
}
