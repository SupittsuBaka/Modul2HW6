using Modul2HW6.Services.Abstracts;
using Modul2HW6.Services;
using Microsoft.Extensions.DependencyInjection;
using Modul2HW6.Providers;

namespace Modul2HW6
{
    public class AppStarter
    {
        public void Run()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IConfigService, ConfigService>()
                .AddTransient<ISocketService, SocketService>()
                .AddTransient<AppliancesProvider>()
                .AddTransient<Starter>().BuildServiceProvider();

            serviceProvider.GetService<Starter>().Run();
        }
    }
}
