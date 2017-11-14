using ConsoleApplicationTemplate.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationTemplate.Strategy
{
    public class TestDataContext
    {
        private TestDataStrategy _TestDataStrategy;
        public void SetStrategy(TestDataStrategy testDataStrategy)
        {
            this._TestDataStrategy = testDataStrategy;
        }
        public string GetStrategy()
        {
            return this._TestDataStrategy.Strategy();
        }
        public List<TestData> GetData()
        {
            if (_TestDataStrategy is null)
            {
                throw new Exception("You have to choose strategy");
            }

            return this._TestDataStrategy.GetData();
        }
    }
}
