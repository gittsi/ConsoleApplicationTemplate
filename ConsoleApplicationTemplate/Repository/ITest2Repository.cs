using ConsoleApplicationTemplate.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationTemplate.Repository
{
    public interface ITest2Repository
    {
        Task<List<TestData>> GetTestData();
    }
}
