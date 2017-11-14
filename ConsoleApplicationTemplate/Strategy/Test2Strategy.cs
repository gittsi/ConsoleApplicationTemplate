using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplicationTemplate.Model;
using ConsoleApplicationTemplate.Infrastructure.DI;

namespace ConsoleApplicationTemplate.Strategy
{
    public class Test2Strategy : TestDataStrategy
    {
        private readonly TestDataContext _TestDataContext;
        public Test2Strategy(TestDataContext testDataContext)
        {
            _TestDataContext = testDataContext;
        }
        public override List<TestData> GetData()
        {
            return IResolver.Current.Test2Repository.GetTestData().Result;
        }
    }
}
