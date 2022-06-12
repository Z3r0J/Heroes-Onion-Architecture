using HeroesOnionArchitecture.Core.Application.Interfaces.Repository.Heroes;
using HeroesOnionArchitecture.Core.Application.Interfaces.Services.Heroes;
using HeroesOnionArchitecture.Core.Application.Services.Heroes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesOnionArchitecture.Core.Application
{
    public static class ServicesRegistration
    {
        public static void AddApplicationLayer(this IServiceCollection service, IConfiguration configuration) {
            #region Repositories

            service.AddTransient<IHeroServices, HeroServices>();

        #endregion
        }


    }
}
