using Appliances.Models.Appliances.ComputingDevices.Portables;
using Appliances.Models.Appliances.ComputingDevices.Portables.Laptops;
using Appliances.Models.Appliances.ComputingDevices.Portables.Smartphones;
using Modul2HW6.Enums;
using Modul2HW6.Models;
using Modul2HW6.Models.Appliances.ComputingDevices.Stations;
using Modul2HW6.Models.Appliances.ComputingDevices.Stations.MultiMedias;
using Modul2HW6.Models.Appliances.KitchenDevices.HeatDevices;
using Modul2HW6.Models.Appliances.KitchenDevices.ShreddingDevices;

namespace Modul2HW6.Providers
{
   public class AppliancesProvider
    {
        private Appliance[] _data;
        public AppliancesProvider()
        {
            _data = new Appliance[]
            {
                new Stove()
                {
                    BurnersCount = 4,
                    Color = Color.Black,
                    MaxTemperature = 300,
                    Power = 5000,
                    Price = 8999,
                    Producer = Company.Braun
                },

                new Teapot()
            {
                Color = Color.Green,
                MaxTemperature = 120,
                Power = 700,
                Noise = 20,
                Price = 700,
                Producer = Company.Electrolux,
                Volume = 2.5,
            },
                new Blender()
                {
                    BladesCount = 3,
                    Color = Color.White,
                    Noise = 45,
                    Type = BlenderType.Stationary,
                    Power = 200,
                    Price = 1399,
                    Producer = Company.Moulinex,
                },

                new MeatGrinder()
                {
                    BladesCount = 5,
                    Color = Color.Grey,
                    Noise = 58,
                    NozzlesCount = 3,
                    Power = 340,
                    Price = 2300,
                    Producer = Company.Fujitsu,
                },

                new AudioSystem()
                {
                    Color = Color.Yellow,
                    MaxFrequency = 1000,
                    MinFrequency = 150,
                    OS = OperatingSystem.Other,
                    ProcessorFrequency = 400,
                    Ports = new PortType[] { PortType.AUX, PortType.USB },
                    Power = 200,
                    PowerSupply = PowerSupply.Linear,
                    Price = 10000,
                    Producer = Company.JBL,
                },

                new Projector()
                {
                    Color = Color.Grey,
                    ProcessorFrequency = 1000,
                    InstallationRange = 7,
                    OS = OperatingSystem.Linux,
                    Ports = new PortType[]
                    {
                        PortType.AUX,
                        PortType.DisplayPort,
                        PortType.HDMI,
                        PortType.USB,
                        PortType.LAN,
                    },
                    Power = 80,
                    PowerSupply = PowerSupply.Impulse,
                    Price = 6700,
                    Producer = Company.Xiaomi,
                },

                new PersonalComputer()
                {
                    Color = Color.White,
                    ProcessorFrequency = 3900,
                    IsMonoBlock = false,
                    OS = OperatingSystem.Windows,
                    Power = 800,
                    PowerSupply = PowerSupply.Linear,
                    Price = 19999,
                    Producer = Company.Asus,
                },

                new PersonalComputer()
                {
                    Color = Color.White,
                    ProcessorFrequency = 2700,
                    IsMonoBlock = true,
                    OS = OperatingSystem.MacOs,
                    Power = 500,
                    PowerSupply = PowerSupply.Linear,
                    Price = 40000,
                    Producer = Company.Apple,
                },

                new Notebook()
                {
                    DegreeOfOpening = 140,
                    BateryCapacity = 25000,
                    Color = Color.Green,
                    OS = OperatingSystem.Ubuntu,
                    Power = 400,
                    Price = 28000,
                    ProcessorFrequency = 3100,
                    Producer = Company.HewlettPackard
                },

                new TouchLaptop()
                {
                    DegreeOfOpening = 120,
                    TouchQuantity = 6,
                    MatrixType = MatrixType.IPS,
                    FingerPrintScaner = false,
                    BateryCapacity = 13800,
                    Color = Color.Black,
                    OS = OperatingSystem.Windows,
                    Power = 200,
                    Price = 23000,
                    ProcessorFrequency = 1600,
                    Producer = Company.Lenovo
                },

                new PushButtonPhone()
                {
                    KeyboardType = KeyboardType.Rubber,
                    BateryCapacity = 1000,
                    Color = Color.Violet,
                    ProcessorFrequency = 300,
                    OS = OperatingSystem.Symbian,
                    Power = 10,
                    Price = 800,
                    SimCardQuantity = 2,
                    Producer = Company.Nokia
                },

                new TouchscreenPhone()
                {
                    BateryCapacity = 6000,
                    Color = Color.Black,
                    FingerPrintScaner = true,
                    ProcessorFrequency = 1600,
                    MatrixType = MatrixType.AMOLED,
                    OS = OperatingSystem.Android,
                    Power = 10,
                    TouchQuantity = 5,
                    Price = 15999,
                    Producer = Company.Google,
                    SimCardQuantity = 2
                }
            };
        }

        public Appliance[] GetData()
        {
            return _data;
        }
    }
}
