using Modul2HW6.Models;

namespace Modul2HW6.Services.Abstracts
{
    public interface ISocketService
    {
        public double GetFullPower();
        public void SortByPower();
        public Appliance[] GetAllAppliances();
        public void Add(Appliance item);
        public void Remove(int index);
        public void Clean();
    }
}