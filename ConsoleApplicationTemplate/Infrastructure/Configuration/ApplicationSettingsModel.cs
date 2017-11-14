using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationTemplate.Infrastructure.Configuration
{
    public class ApplicationSettingsModel
    {
        public GeneralSettings GeneralSettings { get; set; }
        public Test1Settings Test1Settings { get; set; }

        public Test2Settings Test2Settings { get; set; }
    }

    public class GeneralSettings
    {
        public string ApplicationName { get; set; }
        public string Environment { get; set; }
        public string JsonSettingsVersion { get; set; }
    }

    public class Test1Settings
    {
        public string Test1a { get; set; }
        public string Test1b { get; set; }
        public string Test1c { get; set; }
    }

    public class Test2Settings
    {
        public string Test2a { get; set; }
        public string Test2b { get; set; }
    }
}
