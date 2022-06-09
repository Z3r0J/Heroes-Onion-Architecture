using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesOnionArchitecture.Core.Domain.Entities
{
    public class Hero
    {
        public int HeroId { get; set; }
        public string Name { get; set; }

        public int QualityId { get; set; }
        public Quality Quality { get; set; }

        public int UniverseId { get; set; }
        public Universe Universe { get; set; }
    }
}
