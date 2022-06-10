using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesOnionArchitecture.Core.Domain.Entities
{
    public class Universe
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Hero> Heroes { get; set; }
    }
}
