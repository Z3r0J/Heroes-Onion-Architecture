using HeroesOnionArchitecture.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesOnionArchitecture.Infrastructure.Persistence
{
    public static class ServicesRegistration
    {
        public static void AddPersistanceInfrastructure(this IServiceCollection service, IConfiguration configuration) {

            service.AddDbContext<ApplicationContext>(options=>options.UseSqlServer(configuration.GetConnectionString("MyConnectionString")));
        
        }
    }
}
