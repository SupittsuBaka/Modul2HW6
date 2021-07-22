using Modul2HW6.Enums;

namespace Appliances.Models.Abstractions
{
    public interface ITouchscreen
    {
        public int TouchQuantity { get; set; }
        public MatrixType MatrixType { get; set; }
        public bool FingerPrintScaner { get; set; }
    }
}
