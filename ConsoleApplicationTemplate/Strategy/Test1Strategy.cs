using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplicationTemplate.Model;
using ConsoleApplicationTemplate.Infrastructure.DI;

namespace ConsoleApplicationTemplate.Strategy
{
    public class Test1Strategy : TestDataStrategy
    {
        private readonly TestDataContext _TestDataContext;
        public Test1Strategy(TestDataContext testDataContext)
        {
            _TestDataContext = testDataContext;
        }
        public override List<TestData> GetData()
        {
            return IResolver.Current.Test1Repository.GetTestData().Result;
        }
    }
}
