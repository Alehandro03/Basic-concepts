using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMonstr
{
    class Monstr : Creature, ICombatan
    {
        private Monster _monster;
        private double Cash = 10500.500;
        private int MinAttack; //(минимальная сила атаки.Проверка:  1-10)
        private int MaxAttack; //(максимальная атаки. Проверка:  20-100)
        string WarCry; //(боевой клич :)
        string DieCry; //(крик умирания :)
       
        public Monstr() { }
        public Monstr(Monster monster, double cash, int minAttack, int maxAttack) : this()
        {
            _monster = monster;
            Cash = cash;
            MinAttack = minAttack;
            MaxAttack = maxAttack;
        }
        public Monstr(string warCry, string dieCry) : this()
        {
            WarCry = warCry;
            DieCry = dieCry;

        }

        public double _Cash
        {
            get => Cash;

            set
            {
                if (value > Cash) throw new ArgumentException("Введена не верная сумма.");
            }
        }

        public int _MinAttack
        {
            get => MinAttack;

            set
            {
                if (value >= 1 && value <= 10) MinAttack = value;

                else if (value < 1) throw new Exception("Сила атaки меньше минимальной");
            }
        }
        public int _MaxAttack
        {
            get => MaxAttack;

            set
            {
                if (value >= 20 && value <= 200) MaxAttack = value;

                else if (value > 200) throw new Exception("Атака превышает максимум");
            }
        }
        public string _WarCry
        {
            get => WarCry;

            set
            {
                if (value != string.Empty) WarCry = value;
                else throw new Exception("Вы ввели пустую строку!");
            }
        }

        public string _DieCry
        {
            get => DieCry;

            set
            {
                if (value != string.Empty) DieCry = value;

                else throw new Exception("Вы ввели пустую строку!");

            }
        }

        int ICombatan.MinAttack
        { 
            get => _MinAttack; 
            
            set
            {
                if (_monster == Monster.Orc) _MinAttack = 5;
                else if (_monster == Monster.Elf) _MinAttack = 6;
                else if (_monster == Monster.Mutant) _MinAttack = 7;
                else if (_monster == Monster.Mag) _MinAttack = 4;
                else if (_monster == Monster.People) _MinAttack = 5;
            }
        }
        int ICombatan.MaxAttack 
        { 
            get => _MaxAttack; 
            set
            {        
                 if (_monster == Monster.Orc) _MaxAttack = 80;
                 else if (_monster == Monster.Elf) _MaxAttack = 50;
                 else if (_monster == Monster.Mutant) _MaxAttack = 70;
                 else if (_monster == Monster.Mag) _MaxAttack = 40;
                 else if (_monster == Monster.People) _MaxAttack = 65;                
            }
        }   

       
       

        bool ICombatan.Attack()
        {
            throw new NotImplementedException();
        }
        

        public override int Wound(int hp)
        {
            if (_monster == Monster.Orc) hp = hp - 10;
            else if (_monster == Monster.Elf) hp = hp - 30;
            else if (_monster == Monster.Mutant) hp = hp - 5;
            else if (_monster == Monster.Mag) hp = hp - 40;
            else if (_monster == Monster.People) hp = hp - 20;

            return hp;
        }
    }

   


   

    
}
