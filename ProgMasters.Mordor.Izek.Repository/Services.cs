using Microsoft.Extensions.DependencyInjection;
using ProgMasters.Mordor.Izek.Repository.Abstractions;
using ProgMasters.Mordor.Izek.Repository.Mapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgMasters.Mordor.Izek.Repository
{
    public static class Services
    {
        public static void RegisterRepositoryDependencies(this IServiceCollection services)
        {
            services.AddTransient<IOrkMapper, OrkMapper>();
            services.AddTransient<IOrkRepository, OrkRepository>();
        }

    }
}
