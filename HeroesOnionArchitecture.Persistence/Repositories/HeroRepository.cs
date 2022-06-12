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
    public class HeroRepository : IHeroRepository
    {

        private readonly ApplicationContext _dbContext;
        public HeroRepository(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Hero hero)
        {
            await _dbContext.Set<Hero>().AddAsync(hero);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Hero>> GetAllAsync() {

            return await _dbContext.Set<Hero>().ToListAsync();
        }

        public async Task<Hero> GetByIdAsync(int id) {

            return await _dbContext.Set<Hero>().FindAsync(id);

        }

        public async Task UpdateAsync(Hero hero) {

            _dbContext.Entry(hero).State = EntityState.Modified;

            await _dbContext.SaveChangesAsync();

        }

        public async Task DeleteAsync(Hero hero) {

            _dbContext.Set<Hero>().Remove(hero);
            await _dbContext.SaveChangesAsync();
        
        }
    }
}
