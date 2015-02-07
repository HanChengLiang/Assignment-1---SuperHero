// Author: Han Cheng Liang
// ID: 300791705

using System;

namespace hero
{
    class Program
    {
        static void Main(string[] args)
        {
            hero hero = new hero("Lux");
            hero.show();
            hero.fight();

            SuperHero superHero = new SuperHero("BatMan");
            superHero.showPowers();
            superHero.fight();
        }
    }
}