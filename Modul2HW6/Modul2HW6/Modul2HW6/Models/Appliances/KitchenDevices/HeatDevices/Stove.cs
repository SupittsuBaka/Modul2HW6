namespace Modul2HW6.Models.Appliances.KitchenDevices.HeatDevices
{
    public class Stove : HeatDevice
    {
        public override double Noise { get => 0; }
        public int BurnersCount { get; set; }
    }
}
