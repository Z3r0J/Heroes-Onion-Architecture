using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesOnionArchitecture.Core.Application.Interfaces.Services
{
    public interface IGenericServices<SaveViewModel, ViewModel>
        where SaveViewModel :class
        where ViewModel : class
    {

        Task Update(SaveViewModel vm);
        Task Delete(int id);
        Task Add(SaveViewModel vm);
        Task<SaveViewModel> GetByIdHeroeViewModel(int id);
        Task<List<ViewModel>> GetAllViewModel();
    }
}
