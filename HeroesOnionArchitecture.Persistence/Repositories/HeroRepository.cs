using HeroesOnionArchitecture.Core.Application.Interfaces.Repository.Heroes;
using HeroesOnionArchitecture.Core.Domain.Entities;
using HeroesOnionArchitecture.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesOnionArchitecture.Infrastructure.Persistence.Repositories
{
    public class HeroRepository : GenericRepository<Hero>, IHeroRepository
    {

        private readonly ApplicationContext _dbContext;
        public HeroRepository(ApplicationContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
