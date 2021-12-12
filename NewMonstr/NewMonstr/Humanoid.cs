using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMonstr
{
    enum Monster {  Orc, Elf, Mutant, Mag, People }
    class Humanoid : Creature
    {
        private Monster _monster;
        private Inventory _inventory;
        public Humanoid() { }
        public Humanoid(Monster monster, Inventory inventory) : this()
        {
            _monster = monster;
            _inventory = inventory;
        }

        public override int Wound(int hp)
        {
            if(_monster == Monster.Orc) hp = hp - 10;
            else if (_monster == Monster.Elf) hp = hp - 30;
            else if (_monster == Monster.Mutant) hp = hp - 5;
            else if (_monster == Monster.Mag) hp = hp - 40;
            else if (_monster == Monster.People) hp = hp - 20;

            return hp;
    
        }

        
    }
}
