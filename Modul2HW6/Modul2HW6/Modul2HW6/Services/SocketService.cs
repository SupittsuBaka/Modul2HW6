using System;
using Modul2HW6.Exceptions;
using Modul2HW6.Helpers;
using Modul2HW6.Models;
using Modul2HW6.Services.Abstracts;

namespace Modul2HW6.Services
{
    public class SocketService : ISocketService
    {
        private readonly IConfigService _configService;
        private readonly int _capacity;
        private Appliance[] _appliances;
        public SocketService(IConfigService configService)
        {
            _configService = configService;
            _capacity = configService.GetConfig().MaxSocketCapacity;
            _appliances = new Appliance[_capacity];
        }

        public void Add(Appliance item)
        {
            for (var i = 0; i < _capacity; i++)
            {
                if (_appliances[i] == null)
                {
                    _appliances[i] = item;
                    return;
                }
            }

            throw new BuisnessException("There is not free place at socket");
        }

        public void Clean()
        {
            _appliances = new Appliance[_capacity];
        }

        public Appliance[] GetAllAppliances()
        {
            return _appliances;
        }

        public void Remove(int index)
        {
            _appliances[index] = null;
        }

        public void SortByPower()
        {
            Array.Sort(_appliances, new PowerComparer());
            Array.Reverse(_appliances);
        }

        public double GetFullPower()
        {
            var sum = 0d;
            foreach (var item in _appliances)
            {
                if (item != null)
                {
                    sum += item.Power;
                }
            }

            return sum;
        }
    }
}