using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationTemplate.Infrastructure.Configuration
{
    public interface ISettingsConfiguration
    {
        IConfigurationRoot GetConfiguration();
    }
}
