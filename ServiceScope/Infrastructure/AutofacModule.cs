using Autofac;
using Business.Manager;
using ServiceScope.Services;
using System.Linq;
using System.Reflection;

namespace ServiceScope.Infrastructure
{
    public class AutofacModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TransientService>().As<ITransientService>();
            builder.RegisterType<ScopedService>().As<IScopeService>().InstancePerLifetimeScope();
            builder.RegisterType<SingletonService>().As<ISingletonService>().SingleInstance(); 

            builder.RegisterAssemblyTypes(Assembly.Load(nameof(Business)))
                .Where(x => x.Namespace.Contains("Manager"))
                .As(x => x.GetInterfaces().FirstOrDefault(y => y.Name == "I" + x.Name)).SingleInstance();

        }
    }
     
}
