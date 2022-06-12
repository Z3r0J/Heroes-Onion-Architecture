using HeroesOnionArchitecture.Core.Application.Interfaces.Repository;
using HeroesOnionArchitecture.Core.Application.Interfaces.Repository.Heroes;
using HeroesOnionArchitecture.Infrastructure.Persistence.Contexts;
using HeroesOnionArchitecture.Infrastructure.Persistence.Repositories;
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
        #region Context
        public static void AddPersistanceInfrastructure(this IServiceCollection service, IConfiguration configuration) {

            if (configuration.GetValue<bool>("UseInMemoryDatabase"))
            {
                service.AddDbContext<ApplicationContext>(options => options.UseInMemoryDatabase("InMemoryDb"));
            }
            else
            {
                service.AddDbContext<ApplicationContext>(options => 
                options.UseSqlServer(configuration.GetConnectionString("MyConnectionString"),
                m=>m.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName)));
            }

            #region Repositories
            service.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            service.AddTransient<IHeroRepository, HeroRepository>();

        #endregion
        }
        #endregion


    }
}
