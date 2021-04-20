using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreateNote.Business;
using CreateNote.Data;
using Microsoft.Extensions.DependencyInjection;

namespace CreateNote.API.Config
{
    public static class ServicesConfig
    {
        public static void RegistrateServicesConfig(this IServiceCollection services)
        {
            services.AddScoped<ITestingCaseService, TestingCaseService>();

            services.AddScoped<ITestingCaseRepository, TestingCaseRepository>();
        }
    }
}
