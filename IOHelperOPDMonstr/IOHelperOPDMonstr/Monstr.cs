using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOHelperOPDMonstr
{
    enum MonsterType { Dragon, Orc, Demon, Mutant, Animal, People }

    class Monstr
    {
        private MonsterType Monster;
        private double Cash = 10500.500;       
        private int MinAttack; //(минимальная сила атаки.Проверка:  1-10)
        private int MaxAttack; //(максимальная атаки. Проверка:  20-100)
        string WarCry; //(боевой клич :)
        string DieCry; //(крик умирания :)


        public Monstr() { }

        public Monstr(double cash,int min_attack,int max_attack,string war_cry,string die_cry, MonsterType monster)
            :this()
        {
            Cash = cash;
            MinAttack = min_attack;
            MaxAttack = max_attack;
            WarCry = war_cry;
            DieCry = die_cry;
            Monster = monster;
        }

        
        public string MonsterText
        {
            get
            {
                return (Monster == MonsterType.Dragon ? "Дракон" : (Monster == MonsterType.Orc ? "Орк"
                    : (Monster == MonsterType.Demon ? "Демон" : (Monster == MonsterType.Mutant ? "Мутант":
                    (Monster == MonsterType.Animal? "Животное":"Человек")))));
            }

            
        }
        public double _Cash
        {
            get
            {
                return Cash;
            }
            set
            {
                if(value> Cash)
                {
                    throw new ArgumentException("Введена не верная сумма.");
                }
            }
        }
        
        public int _MinAttack
        {
            get
            {
                return MinAttack;
            }
            set
            {
                if (value >= 1 && value <= 10)
                    MinAttack = value;
                if (value < 1)
                {
                    throw new Exception("Сила атaки меньше минимальной");
                }
            }
        }
        public int _MaxAttack
        {
            get
            {
                return MaxAttack;
            }
            set
            {
                if (value >= 20 && value <= 200)
                {
                    MaxAttack = value;
                }
                if (value > 200)
                {
                    throw new Exception("Атака превышает максимум");
                }
            }
        }
        public string _WarCry
        {
            get
            {
                return WarCry;
            }
            set
            {
                if (value != string.Empty)
                {
                    WarCry = value;
                }
                else
                {
                    throw new Exception("Вы ввели пустую строку!");
                }
            }
        }

        public string _DieCry
        {
            get
            {
                return DieCry;
            }
            set
            {
                if (value != string.Empty)
                {
                    DieCry = value;
                }
                else
                {
                    throw new Exception("Вы ввели пустую строку!");
                }
            }
        }


    }

    class Helps
    {
        private int _hp = 500;

        private int _maxHP = 500;

        public Helps(int hp, int maxHP )
        {
            _hp = hp;
            _maxHP = maxHP;
        }
        public int MaxHP
        {
            get
            {
                return _maxHP;
            }
            set
            {
                if (value >= 0 && value <= 500)
                {
                    _maxHP = value;
                }
                if (value > 500)
                {
                    throw new Exception("MaxHP > 500");
                }
            }
        }

        public int Demeg(int hp, int MinAttack, int MaxAttack)
        {
            if(MinAttack!=0) hp -= MinAttack;

            else hp -= MaxAttack;

            return hp;

        }
      
    }
    

    class Item
    {
        public string Name { get; set; }
      
        public int White { get; set; }

        public double Cost { get; set; }

        public Item(string name, int white, double cost)
        {
            Name = name;
            White = white;
            Cost = cost;
        }
    }

    class Inventar
    {
        private Item [] mas;
        const int MaxItem = 100;
        public int Count { get; private set; }
        public string Owner { get; set; }

        public Inventar()
        {
            mas = new Item[MaxItem];
        }
            
        public Inventar(string owner)  :this()
        {
           Owner = owner; 
        }
        public void Add(Item item)
        {
            if (Count < MaxItem)
            {
                mas[Count] = item;
                Count++;
            }
            else throw new ArgumentException("Инвентарь переполнен.");
        }

        public Item GetByIndex(int index)
        {
            if (index >= 0 && index < Count) return mas[index];

            else throw new ArgumentException("Неверный индекс");
        }

        public void Remove( int index)
        {
            Item[] masTmp = new Item[MaxItem];

            masTmp = mas;

            for (int i = index; i < Count; i++)
            {
                masTmp[i] = masTmp[i + 1];
            }
            Count--;

            mas = masTmp;
        }
        public Item this [int index]
        {
            get 
            {
                if (index >= 0 && index < Count) 
                    return mas[index];
                throw new ArgumentException("Неверный индекс");
            }
            set 
            {
                if (index >= 0 && index < Count) 
                    mas[index] = value; 
                else 
                    throw new ArgumentException("Неверный индекс");
            }
        }

    }

    
}
