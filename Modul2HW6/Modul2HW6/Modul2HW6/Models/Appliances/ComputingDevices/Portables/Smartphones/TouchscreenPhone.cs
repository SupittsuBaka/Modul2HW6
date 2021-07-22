using Modul2HW6.Enums;
using Appliances.Models.Abstractions;

namespace Appliances.Models.Appliances.ComputingDevices.Portables.Smartphones
{
    public class TouchscreenPhone : Smartphone, ITouchscreen
    {
        public int TouchQuantity { get; set; }
        public MatrixType MatrixType { get; set; }
        public bool FingerPrintScaner { get; set; }
    }
}