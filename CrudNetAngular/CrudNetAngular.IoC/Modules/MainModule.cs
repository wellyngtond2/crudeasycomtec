using Autofac;
using CrudNetAngular.Core.Interfaces.Repositories;
using CrudNetAngular.Core.Interfaces.Validates;
using CrudNetAngular.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CrudNetAngular.IoC.Modules
{
    public class MainModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assemblies = new[]
            {
                Assembly.Load("CrudNetAngular"),
                Assembly.Load("CrudNetAngular.Core"),
                Assembly.Load("CrudNetAngular.DataContracts"),
                Assembly.Load("CrudNetAngular.Data"),
                Assembly.Load("CrudNetAngular.Infra"),
            };

            builder
                .RegisterAssemblyTypes(assemblies)
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}
