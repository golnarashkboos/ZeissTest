using ZeissTest.Business.IService;
using Autofac;
using ZeissTest.Data;

namespace ZeissTest.Business
{
    public class ServiceInstaller : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ZeissTestDatabaseContext>().InstancePerRequest();
            builder.RegisterAssemblyTypes(ThisAssembly)
                    .Where(c => c.Name.EndsWith("Service"))
                    .AsImplementedInterfaces();
        }
    }
}
