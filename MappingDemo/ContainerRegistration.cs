using AppService;
using AutoMapper;
using Domain;
using Microsoft.Extensions.DependencyInjection;
using Repo;
using Repo.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MappingDemo
{
    public static class ContainerRegistration
    {
        public static void ConfigureAppServices(this IServiceCollection services)
        {
            services.AddScoped<IDiagnosticsService, DiagnosticsService>();
        }
        public static void ConfigureRepository(this IServiceCollection services)
        {
            services.AddScoped<IDiagnosticRepository, DiagnosticRepository>();
        }
        public static void ConfigureAutomapper(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(c => c.AddProfile(new DtoMapProfile()));
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
