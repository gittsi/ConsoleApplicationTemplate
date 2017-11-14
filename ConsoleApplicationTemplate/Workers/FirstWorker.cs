using ConsoleApplicationTemplate.Helper;
using ConsoleApplicationTemplate.Infrastructure.Configuration;
using ConsoleApplicationTemplate.Strategy;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApplicationTemplate.Workers
{
    public class FirstWorker : IFirstWorker
    {
        private readonly TestDataContext _TestDataContext;
        private readonly Test1Strategy _Test1Strategy;
        private readonly Test2Strategy _Test2Strategy;
        private readonly ApplicationSettingsModel _AppSettings;

        public FirstWorker(TestDataContext testDataContext,Test1Strategy test1Strategy, Test2Strategy test2Strategy, ApplicationSettings applicationSettings)
        {
            _TestDataContext = testDataContext;
            _Test1Strategy = test1Strategy;
            _Test2Strategy = test2Strategy;
            _AppSettings = applicationSettings.Get();
        }
        public void Run1()
        {
            Thread thread_Worker1 = new Thread(Worker1);
            thread_Worker1.Start();
        }

        public void Run2()
        {
            Thread thread_Worker2 = new Thread(Worker2);
            thread_Worker2.Start();
        }

        private void Worker1()
        {
            while (1 == 1)
            {
                Consoler.WriteLineInColor("Process run started(strategy1)", ConsoleColor.Green);
                _TestDataContext.SetStrategy(_Test1Strategy);
                var data = _TestDataContext.GetData();

                foreach(var row in data)
                {
                    Consoler.WriteLineInColor(string.Format("{0} : {1} {2}", row.Id.ToString(), row.StringData, row.BoolData), ConsoleColor.Green);
                    foreach(var str in row.StringsData)
                    {
                        Consoler.WriteLineInColor(string.Format("Data {0}", str), ConsoleColor.Green);
                    }                    
                }
                Console.WriteLine("------------------------------");
                Thread.Sleep(TimeSpan.FromMilliseconds(_AppSettings.Test1Settings.RecurAfterMs));
            }
        }

        private void Worker2()
        {
            while (1 == 1)
            {
                Consoler.WriteLineInColor("Process run started(strategy2)", ConsoleColor.Green);
                _TestDataContext.SetStrategy(_Test2Strategy);
                var data = _TestDataContext.GetData();

                foreach (var row in data)
                {
                    Consoler.WriteLineInColor(string.Format("{0} : {1} {2}", row.Id.ToString(), row.StringData, row.BoolData), ConsoleColor.Green);
                    foreach (var str in row.StringsData)
                    {
                        Consoler.WriteLineInColor(string.Format("Data {0}", str), ConsoleColor.Green);
                    }                    
                }
                Console.WriteLine("------------------------------");
                Thread.Sleep(TimeSpan.FromMilliseconds(_AppSettings.Test2Settings.RecurAfterMs));
            }
        }
    }
}
