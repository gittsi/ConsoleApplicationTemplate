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
                    //;

                    //cfg.CreateMap<GuildCharacterDto, Model.Character>()
                    //.ForMember(dest => dest.Name, src => src.MapFrom(source => source.Name))
                    //.ForMember(dest => dest.Stats, src => src.Ignore())
                    //;

                    ////.ForMember(dest => dest.Tax, c => c.MapFrom(src => !string.IsNullOrWhiteSpace(src.TaxCode) ? new TaxInfo() { TaxCode = src.TaxCode, TaxOffice = src.TaxOffice } : null))

                    //cfg.CreateMap<GuildCharacterDto, Model.GuildCharacter>()
                    //.ForMember(dest => dest.Character, src => src.MapFrom(source => new Model.Character() { Name = source.Name })
                    //);

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
