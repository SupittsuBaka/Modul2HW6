using System.IO;
using Modul2HW6.Configs;
using Modul2HW6.Services.Abstracts;
using Newtonsoft.Json;
namespace Modul2HW6.Services
{
    public class ConfigService : IConfigService
    {
        private Config _config;
        public ConfigService()
        {
            var configText = File.ReadAllText("config.json");
            _config = JsonConvert.DeserializeObject<Config>(configText);
        }

        public Config GetConfig()
        {
            return _config;
        }
    }
}