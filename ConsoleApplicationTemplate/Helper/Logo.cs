﻿using ConsoleApplicationTemplate.Infrastructure.Configuration;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ConsoleApplicationTemplate.Helper
{
    public class Logo
    {
        public static void ConsolePrintLogo(ApplicationSettings applicationSettings)
        {            
            var appSettings = applicationSettings.Get();
            Version version = Assembly.GetEntryAssembly().GetName().Version;
            Consoler.WriteLineInColor(string.Format("{0} - {1}", appSettings.GeneralSettings.ApplicationName, appSettings.GeneralSettings.Environment), ConsoleColor.DarkYellow);
            Consoler.WriteLineInColor(string.Format("Application Version : {0}", version), ConsoleColor.DarkYellow);         
            Console.Title = string.Format("{0} - version {1}", appSettings.GeneralSettings.ApplicationName, version);
            Console.WriteLine();
        }
    }
}
