using Microsoft.Extensions.DependencyInjection;
using Oxer.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxer.Data.ServiceRegistrartion
{
    public static  class ServiceRegistration
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IstudentRepository,IstudentRepository>();
        }
    }
}
