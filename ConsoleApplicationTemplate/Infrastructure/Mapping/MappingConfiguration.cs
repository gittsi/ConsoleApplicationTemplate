using AutoMapper;
using ConsoleApplicationTemplate.Model;
using ConsoleApplicationTemplate.Repository.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationTemplate.Infrastructure.Mapping
{
    public class MappingConfiguration : IMappingConfiguration
    {
        private IMapper _Mapper;
        public MappingConfiguration()
        {
            _Mapper = GetConfigureMapper();
        }
        public IMapper GetConfigureMapper()
        {
            if (_Mapper != null)
                return _Mapper;
            try
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<TestDataDto, TestData>()
                    .ForMember(dest => dest.BoolData, src => src.MapFrom(source => source._BoolData))
                    .ForMember(dest => dest.Id, src => src.MapFrom(source => source._Id))
                    .ForMember(dest => dest.StringData, src => src.MapFrom(source => source._StringData))
                    .ForMember(dest => dest.StringsData, src => src.MapFrom(source => source._StringsData))
                    ;

                    cfg.AllowNullDestinationValues = true;
                    cfg.AllowNullCollections = true;
                });

                config.AssertConfigurationIsValid();
                return config.CreateMapper();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
