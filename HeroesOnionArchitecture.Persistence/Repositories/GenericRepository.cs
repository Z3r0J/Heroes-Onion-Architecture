﻿using HeroesOnionArchitecture.Core.Application.Interfaces.Repository;
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
    public class GenericRepository<Entity>:IGenericRepository<Entity> where Entity : class
    {

        private readonly ApplicationContext _dbContext;
        public GenericRepository(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Entity entity)
        {
            await _dbContext.Set<Entity>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Entity>> GetAllAsync() {

            return await _dbContext.Set<Entity>().ToListAsync();
        }

        public async Task<List<Entity>> GetAllWithIncludeAsync(List<string> Properties)
        {
            var query = _dbContext.Set<Entity>().AsQueryable();

            foreach (string p in Properties)
            {
                query = query.Include(p);
            }

            return await query.ToListAsync();
        }

        public async Task<Entity> GetByIdAsync(int id) {

            return await _dbContext.Set<Entity>().FindAsync(id);

        }

        public async Task UpdateAsync(Entity entity) {

            _dbContext.Entry(entity).State = EntityState.Modified;

            await _dbContext.SaveChangesAsync();

        }

        public async Task DeleteAsync(Entity entity) {

            _dbContext.Set<Entity>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        
        }
    }
}
