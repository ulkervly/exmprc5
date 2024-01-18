using Microsoft.Extensions.DependencyInjection;
using Oxer.Business.Services.Implementations;
using Oxer.Business.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Oxer.Business.ServiceRegistration
{
    public static class ServiceRegistration
    {
        public static void AddServices(this IServiceCollection  services)
        {
            services.AddScoped<IStudentService, StudentService>();
        }
    }
}
