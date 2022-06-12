using HeroesOnionArchitecture.Core.Application.Interfaces.Repository.Heroes;
using HeroesOnionArchitecture.Core.Application.Interfaces.Services.Heroes;
using HeroesOnionArchitecture.Core.Application.ViewModel.Hero;
using HeroesOnionArchitecture.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesOnionArchitecture.Core.Application.Services.Heroes
{
    public class HeroServices : IHeroServices
    {
        public readonly IHeroRepository _repository;

        public HeroServices(IHeroRepository heroRepository)
        {
            _repository = heroRepository;
        }

        public async Task Update(SaveHeroeViewModel vm) {

            Hero hero = new() { 
            Id = vm.Id,
            Name = vm.Name,
            PhotoUrl = vm.PhotoUrl,
            QualityId = vm.QualityId,
            UniverseId = vm.UniverseId
            };
            
            await _repository.UpdateAsync(hero);
        }

        public async Task Add(SaveHeroeViewModel vm)
        {

            Hero hero = new()
            {
                Name = vm.Name,
                PhotoUrl = vm.PhotoUrl,
                QualityId = vm.QualityId,
                UniverseId = vm.UniverseId
            };

            await _repository.AddAsync(hero);
        }

        public async Task Delete(int id) {

            var Hero = await _repository.GetByIdAsync(id);

            await _repository.DeleteAsync(Hero);

        }

        public async Task<SaveHeroeViewModel> GetByIdHeroeViewModel(int id) {

            var Hero = await _repository.GetByIdAsync(id);

            return new()
            {
                Id = Hero.Id,
                Name = Hero.Name,
                PhotoUrl = Hero.PhotoUrl,
                QualityId = Hero.QualityId,
                UniverseId = Hero.UniverseId
            };
        }

        public async Task<List<SaveHeroeViewModel>> GetAllViewModel() {

            var HeroList = await _repository.GetAllAsync();

            return HeroList.Select(heroList => new SaveHeroeViewModel
            {
                Id = heroList.Id,
                Name = heroList.Name,
                PhotoUrl = heroList.PhotoUrl,
                QualityId = heroList.QualityId,
                UniverseId = heroList.UniverseId
            }).ToList();        
        }
    }
}
