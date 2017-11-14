using Autofac;
using ConsoleApplicationTemplate.Infrastructure.Configuration;
using ConsoleApplicationTemplate.Infrastructure.Mapping;
using ConsoleApplicationTemplate.Repository;

namespace ConsoleApplicationTemplate.Infrastructure.DI
{
    public abstract class ResolverConfig
    {
        internal IContainer Container { get; set; }
        public ApplicationSettings ApplicationSettings { get { return Container.Resolve<ApplicationSettings>(); } }
        public IMappingConfiguration MappingConfiguration { get { return Container.Resolve<IMappingConfiguration>(); } }
        public ITest1Repository Test1Repository { get { return Container.Resolve<ITest1Repository>(); } }
        public ITest2Repository Test2Repository { get { return Container.Resolve<ITest2Repository>(); } }


        public static IContainer ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            //configurations
            builder.RegisterType<MappingConfiguration>().As<IMappingConfiguration>().SingleInstance();
            builder.RegisterType<ApplicationSettings>().SingleInstance();            

            //repositories
            builder.RegisterType<Test1Repository>().As<ITest1Repository>().InstancePerDependency();
            builder.RegisterType<Test2Repository>().As<ITest2Repository>().InstancePerDependency();

            return builder.Build();
        }
    }
}
