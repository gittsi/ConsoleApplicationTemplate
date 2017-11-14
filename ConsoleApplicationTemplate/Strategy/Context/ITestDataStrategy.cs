using ConsoleApplicationTemplate.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationTemplate.Strategy
{
    public interface ITestDataStrategy
    {
        List<TestData> GetData();
    }
}
