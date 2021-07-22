using Modul2HW6.Enums;

namespace Modul2HW6.Models.Appliances.ComputingDevices
{
    public abstract class Station : ComputingDevice
    {
        public PowerSupply PowerSupply { get; set; }
    }
}