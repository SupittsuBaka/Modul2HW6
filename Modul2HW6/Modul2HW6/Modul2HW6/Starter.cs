using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW6.Services.Abstracts;
using Modul2HW6.Providers;
using Modul2HW6.Configs;
using Modul2HW6.Helpers;
namespace Modul2HW6
{
    public class Starter
    {
        private readonly ISocketService _socketService;
        private readonly AppliancesProvider _appliencesProvider;
        private readonly IConfigService _configService;
        private readonly double _capacity;
        public Starter(
            ISocketService socketService,
            IConfigService configService,
            AppliancesProvider appliancesProvider)
        {
            _configService = configService;
            _capacity = configService.GetConfig().MaxSocketCapacity;
            _socketService = socketService;
            _appliencesProvider = appliancesProvider;
        }

        public void Run()
        {
            var rnd = new Random();
            for (var i = 0; i < _capacity - 1; i++)
            {
                var num = rnd.Next(_appliencesProvider.GetData().Length);
                InsertToSocket(num);
            }

            _socketService.SortByPower();
            var power = _socketService.GetFullPower();
            var result = _socketService.GetAllAppliances().FindByColor(Enums.Color.Black);
        }

        private void InsertToSocket(int index)
        {
            _socketService.Add(_appliencesProvider.GetData()[index]);
        }
    }
}
