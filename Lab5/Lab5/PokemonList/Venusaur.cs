using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.PokemonList
{
    internal class Venusaur :Pokemon
    {
        public Venusaur()
        {
            Random random = new Random();
            this.name = "Venusaur";
            this.hp = random.Next(270  , 364);
            this.attack = random.Next(152 ,  289);
            this.image = Properties.Resources.venusaur;
        }
    }
}
