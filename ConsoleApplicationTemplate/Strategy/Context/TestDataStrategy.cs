using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApplicationTemplate.Model;

namespace ConsoleApplicationTemplate.Strategy
{
    public abstract class TestDataStrategy : ITestDataStrategy
    {        
        public abstract List<TestData> GetData();     
        public virtual string Strategy() { return "Default"; }
    }
}
