using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMonstr
{
    class Inventory
    {
        private Item[] mas;
        const int _maxItem = 100;
        public int Count { get; private set; }
        public string Owner { get; set; }

        public Inventory()
        {
            mas = new Item[_maxItem];
        }

        public Inventory(string owner) : this()
        {
            Owner = owner;
        }      

        public void Add(Item item)
        {
            LinkedList<Item> inv = new LinkedList<Item>();

            if (Count < _maxItem)
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

        public void Remove(int index)
        {
            Item[] masTmp = new Item[_maxItem];

            masTmp = mas;

            for (int i = index; i < Count; i++)
            {
                masTmp[i] = masTmp[i + 1];
            }
            Count--;

            mas = masTmp;
        }
        public Item this[int index]
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
