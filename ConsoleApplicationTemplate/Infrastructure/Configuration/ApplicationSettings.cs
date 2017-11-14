using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationTemplate.Infrastructure.Configuration
{
    public class ApplicationSettings
    {
        private readonly IConfigurationRoot _SettingsConfigurationRoot;
        public ApplicationSettings(ISettingsConfiguration settingsConfiguration)
        {
            _SettingsConfigurationRoot = settingsConfiguration.GetConfiguration();
        }

        public ApplicationSettingsModel Get()
        {
            var bool_Recur1AfterMs = int.TryParse(_SettingsConfigurationRoot.GetSection("Test1_Settings")["RecurAfterMs"], out int Recur1_ms);
            var bool_Recur2AfterMs = int.TryParse(_SettingsConfigurationRoot.GetSection("Test2_Settings")["RecurAfterMs"], out int Recur2_ms);

            ApplicationSettingsModel appSettings = new ApplicationSettingsModel
            {
            //general settings
                GeneralSettings = new GeneralSettings()
                {
                    ApplicationName = _SettingsConfigurationRoot.GetSection("General_Settings")["ApplicationName"]
                    ,
                    Environment = _SettingsConfigurationRoot.GetSection("General_Settings")["Environment"]
                    ,
                    JsonSettingsVersion = _SettingsConfigurationRoot.GetSection("General_Settings")["JsonSettingsVersion"]
                },

                //test1 settings
                Test1Settings = new Test1Settings()
                {
                     Test1a= _SettingsConfigurationRoot.GetSection("Test1_Settings")["Test1a"]
                     ,
                     Test1b = _SettingsConfigurationRoot.GetSection("Test1_Settings")["Test1b"]
                     ,
                    Test1c = _SettingsConfigurationRoot.GetSection("Test1_Settings")["Test1c"]
                    ,
                    RecurAfterMs = Recur1_ms
                },
                //test2 settings
                Test2Settings = new Test2Settings()
                {
                    Test2a=_SettingsConfigurationRoot.GetSection("Test2_Settings")["Test2a"]
                    ,
                    Test2b= _SettingsConfigurationRoot.GetSection("Test2_Settings")["Test2b"]
                    ,
                    Test2c = _SettingsConfigurationRoot.GetSection("Test2_Settings")["Test2c"]
                    ,
                    RecurAfterMs = Recur2_ms
                }
            };

            return appSettings;
        }
    }
}
