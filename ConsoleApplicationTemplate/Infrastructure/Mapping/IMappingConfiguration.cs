using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationTemplate.Infrastructure.Mapping
{
    public interface IMappingConfiguration
    {
        IMapper GetConfigureMapper();
    }
}
