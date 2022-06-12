using HeroesOnionArchitecture.Core.Application.ViewModel.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesOnionArchitecture.Core.Application.Interfaces.Services.Heroes
{
    public interface IHeroServices
    {
        Task Update(SaveHeroeViewModel vm);
        Task Delete(int id);
        Task Add(SaveHeroeViewModel vm);
        Task<SaveHeroeViewModel> GetByIdHeroeViewModel(int id);
        Task<List<SaveHeroeViewModel>> GetAllViewModel();
    }
}
