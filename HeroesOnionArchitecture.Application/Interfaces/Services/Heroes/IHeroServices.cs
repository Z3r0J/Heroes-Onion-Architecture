using HeroesOnionArchitecture.Core.Application.ViewModel.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesOnionArchitecture.Core.Application.Interfaces.Services.Heroes
{
    public interface IHeroServices :IGenericServices<SaveHeroeViewModel,HeroViewModel>
    {

    }
}
