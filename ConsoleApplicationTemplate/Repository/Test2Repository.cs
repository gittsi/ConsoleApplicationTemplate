using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplicationTemplate.Model;
using ConsoleApplicationTemplate.Repository.Dto;
using System.Threading.Tasks;

namespace ConsoleApplicationTemplate.Repository
{
    public class Test2Repository : ITest2Repository
    {
        public async Task<List<TestData>> GetTestData()
        {
            await Task.FromResult(1);

            var list = GetTestDtoData().Result;

            return null;
        }

        private async Task<List<TestDataDto>> GetTestDtoData()
        {
            await Task.FromResult(1);

            List<TestDataDto> list = new List<TestDataDto>();
            TestDataDto data = null;

            data = new TestDataDto() { _Id = 11, _BoolData = false, _StringData = "aa", _StringsData = new List<string>() { "AA", "aa" } };
            list.Add(data);

            data = new TestDataDto() { _Id = 22, _BoolData = false, _StringData = "bb", _StringsData = new List<string>() { "BB", "bb" } };
            list.Add(data);

            data = new TestDataDto() { _Id = 33, _BoolData = false, _StringData = "cc", _StringsData = new List<string>() { "CC", "cc" } };
            list.Add(data);

            return list;
        }
    }
}
