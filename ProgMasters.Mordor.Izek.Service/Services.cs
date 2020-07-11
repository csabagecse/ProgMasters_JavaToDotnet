using Microsoft.Extensions.DependencyInjection;
using ProgMasters.Mordor.Izek.Service.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgMasters.Mordor.Izek.Service
{
    public static class Services
    {
        public static void RegisterServiceDependencies(this IServiceCollection services)
        {
            services.AddTransient<IOrkService, OrkService>();
        }

    }
}
