using Autofac;
using ConsoleApplicationTemplate.Infrastructure.Configuration;
using ConsoleApplicationTemplate.Infrastructure.Mapping;
using ConsoleApplicationTemplate.Repository;
using ConsoleApplicationTemplate.Strategy;
using ConsoleApplicationTemplate.Workers;

namespace ConsoleApplicationTemplate.Infrastructure.DI
{
    public static class AutofacConfig
    {
        public static IContainer ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<IResolver>().As<IStartable>().SingleInstance();

            builder.RegisterType<MappingConfiguration>().As<IMappingConfiguration>().SingleInstance();
            builder.RegisterType<ApplicationSettings>().SingleInstance();            
            builder.RegisterType<SettingsConfiguration>().As<ISettingsConfiguration>().SingleInstance();


            //strategies
            builder.RegisterType<TestDataStrategy>().As<ITestDataStrategy>().InstancePerDependency();
            builder.RegisterType<Test1Strategy>().InstancePerDependency();
            builder.RegisterType<Test2Strategy>().InstancePerDependency();

            //workers
            builder.RegisterType<FirstWorker>().As<IFirstWorker>().InstancePerDependency();
            
            //context            
            builder.RegisterType<TestDataContext>().InstancePerDependency();


            //repositories
            //builder.RegisterType<TestRepository>().As<ITestRepository>().InstancePerDependency();            

            return builder.Build();
        }

    }

}
