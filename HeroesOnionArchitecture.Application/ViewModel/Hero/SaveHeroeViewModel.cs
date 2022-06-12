using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesOnionArchitecture.Core.Application.ViewModel.Hero
{
    public class SaveHeroeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public int QualityId { get; set; }
        public int UniverseId { get; set; }

    }
}
