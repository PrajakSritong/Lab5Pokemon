using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.PokemonList
{
    internal class Butterfree : Pokemon
    {
        public Butterfree()
        {
            Random random = new Random();
            this.name = "Butterfree";
            this.hp = random.Next(230 ,324);
            this.attack = random.Next(85   , 207);
            this.image = Properties.Resources.butterfree;
        }
    }
}
