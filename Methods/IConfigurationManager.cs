using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvningarCleanCode.Methods
{
    public interface IConfigurationManager
    {
        string GetSetting(string key);
        void SetSetting(string key, string value);
    }
    public class ConfigurationSettings
    {
        private readonly IConfigurationManager _configurationManager;
        public ConfigurationSettings(IConfigurationManager configurationManager)
        {
            _configurationManager = configurationManager;
        }
        public string GetSettingByKey(string key)
        {
            return _configurationManager.GetSetting(key);
        }
        public void AdjustSetting(string key, string setting)
        {
            _configurationManager.SetSetting(key, setting);
        }
    }
}
