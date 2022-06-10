using HeroesOnionArchitecture.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesOnionArchitecture.Core.Application.Interfaces
{
    public interface IHeroRepository
    {
        Task AddAsync(Hero hero);
        Task<List<Hero>> GetAllAsync(Hero hero);
        Task<Hero> GetByIdAsync(int id);
        Task UpdateAsync(Hero hero);
        Task DeleteAsync(Hero hero);
    }
}
