using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplicationTemplate.Model;
using ConsoleApplicationTemplate.Repository.Dto;
using System.Threading.Tasks;
using ConsoleApplicationTemplate.Infrastructure.Mapping;
using AutoMapper;

namespace ConsoleApplicationTemplate.Repository
{
    public class Test1Repository : ITest1Repository
    {
        private IMapper _Mapper;
        public Test1Repository(IMappingConfiguration mappingConfiguration)
        {
            _Mapper = mappingConfiguration.GetConfigureMapper();
        }
        public async Task<List<TestData>> GetTestData()
        {
            await Task.FromResult(1);

            var list = GetTestDtoData().Result;
            var newList = _Mapper.Map<List<TestData>>(list);
            return newList;
        }
        private async Task<List<TestDataDto>> GetTestDtoData()
        {
            await Task.FromResult(1);

            List<TestDataDto> list = new List<TestDataDto>();
            TestDataDto data = null;

            data = new TestDataDto() { _Id = 1, _BoolData = false, _StringData = "a", _StringsData = new List<string>() { "A", "a" } };
            list.Add(data);

            data = new TestDataDto() { _Id = 2, _BoolData = false, _StringData = "b", _StringsData = new List<string>() { "B", "b" } };
            list.Add(data);

            data = new TestDataDto() { _Id = 3, _BoolData = false, _StringData = "c", _StringsData = new List<string>() { "C", "c" } };
            list.Add(data);

            return list;
        }
    }
}
