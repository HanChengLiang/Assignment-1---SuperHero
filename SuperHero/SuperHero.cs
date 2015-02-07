using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hero
{
    class SuperHero : hero
    {

        private string[] superPowers;

        //constructor
        public SuperHero(string name) :
            base(name)
        {
            this.generateRandomPowers();
        }

      





    }
}


