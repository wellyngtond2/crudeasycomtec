using Autofac;
using Autofac.Extensions.DependencyInjection;
using CrudNetAngular.IoC.Modules;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CrudNetAngular.IoC
{
    /// <summary>
    /// Register all services of the others assemblies
    /// </summary>
    public static class InjectorBootStrapper
    {
        /// <summary>
        /// Makes use of Autofac to set up the service provider, bringing together Autofac registrations and ASP.NET Core framework registrations.
        /// </summary>
        public static IServiceProvider CreateServiceProvider(IServiceCollection services)
        {
            var builder = new ContainerBuilder();

            builder.Populate(services);
            builder.RegisterModule<MainModule>();

            var container = builder.Build();

            return new AutofacServiceProvider(container);
        }
    }
}
