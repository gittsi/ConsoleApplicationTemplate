using Autofac;
using ConsoleApplicationTemplate.Infrastructure.Configuration;
using ConsoleApplicationTemplate.Infrastructure.Mapping;
using ConsoleApplicationTemplate.Repository;

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

            //repositories
            //builder.RegisterType<TestRepository>().As<ITestRepository>().InstancePerDependency();            

            return builder.Build();
        }

    }

}
