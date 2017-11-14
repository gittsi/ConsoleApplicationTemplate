﻿using Autofac;
using ConsoleApplicationTemplate.Infrastructure.Configuration;
using ConsoleApplicationTemplate.Infrastructure.DI;
using ConsoleApplicationTemplate.Infrastructure.Mapping;
using System;
using System.Threading.Tasks;

namespace ConsoleApplicationTemplate
{
    class Program
    {
        static Autofac.IContainer autoFacContainer = null;
        private ApplicationSettings applicationSettings;

        static void Main(string[] args)
            => new Program().MainAsync().GetAwaiter().GetResult();
        public async Task MainAsync()
        {
            autoFacContainer = AutofacConfig.ConfigureContainer();
            using (var scope = autoFacContainer.BeginLifetimeScope())
            {
                applicationSettings = scope.Resolve<ApplicationSettings>();
                scope.Resolve<IMappingConfiguration>();
            }

            Helper.Logo.ConsolePrintLogo(applicationSettings);

            await Task.Delay(-1);
        }
    }
}
