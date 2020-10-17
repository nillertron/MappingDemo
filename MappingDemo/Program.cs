using AppService;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MappingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.ConfigureAppServices();
            services.ConfigureAutomapper();
            services.ConfigureRepository();
            var containerBuilder = new ContainerBuilder();
            containerBuilder.Populate(services);
            var container = containerBuilder.Build();
            var serviceProvider = new AutofacServiceProvider(container);
            var pipe = new Pipe(serviceProvider.GetRequiredService<IDiagnosticsService>());
            pipe.DoWork().GetAwaiter().GetResult();
            Console.ReadLine();

        }

        
    }
}
