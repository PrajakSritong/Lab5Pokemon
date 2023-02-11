using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.PokemonList
{
    internal class Nidoking : Pokemon
    {
        public Nidoking()
        {
            Random random = new Random();
            this.name = "Nidoking";
            this.hp = random.Next(1000, 2500);
            this.attack = random.Next(100,150);
            this.image = Properties.Resources.nidoking;
        }
    }
}
