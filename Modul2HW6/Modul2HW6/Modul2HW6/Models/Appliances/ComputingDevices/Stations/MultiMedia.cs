using Modul2HW6.Enums;

namespace Modul2HW6.Models.Appliances.ComputingDevices.Stations
{
    public abstract class MultiMedia : Station
    {
        public PortType[] Ports { get; set; }
    }
}