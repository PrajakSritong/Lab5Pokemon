using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.PokemonList
{
    internal class Blastoise : Pokemon
    {
        public Blastoise()
        {
            Random random = new Random();
            this.name = "Blastoise";
            this.hp = random.Next(268 ,362);
            this.attack = random.Next(153 ,  291);
            this.image = Properties.Resources.blastoise;
        }
    }
}
