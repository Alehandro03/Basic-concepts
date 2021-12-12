using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMonstr
{
    
    abstract class Creature
    {
        private string _creatureName{ get; set;}

        private int _hp = 500;

        private int _maxHP = 500;

        private string _dead { get; set; }

        public Creature() { }

        public Creature(string creName, int hp, int maxHP, string dead)  : this()         
        {
            _creatureName = creName;
            _hp = hp;
            _maxHP = maxHP;
            _dead = dead;
        }

        public abstract int Wound(int hp);
        
        
            
        
    }
}
