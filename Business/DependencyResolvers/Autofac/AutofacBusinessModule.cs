using System.Reflection;
using Autofac;
using Module = Autofac.Module;
using Castle.DynamicProxy;
using Autofac.Extras.DynamicProxy;
using Business.Concrete;
using Business.Abstract;
using Business.DependencyResolvers.Interceptors;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            var assembly = Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}