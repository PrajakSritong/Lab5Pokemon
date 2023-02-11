using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.PokemonList
{
    internal class Raichu : Pokemon
    {
        public Raichu()
        {
            Random random = new Random();
            this.name = "Raichu";
            this.hp = random.Next(230 ,  324);
            this.attack = random.Next(166  , 306);
            this.image = Properties.Resources.raichu;
        }
    }
}
