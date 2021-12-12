using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMonstr
{
    enum ItemWeapon { Sword,Ax, Poleaxe, Hammer, Bow }   // мечь,топор, секира, молот, лук
    enum ItemClothing { Chainmail, Cloak, Mantle, Dud }  //Кольчуга, Плащ, Мантия, Рванье
    
    class Item
    {
        private ItemWeapon _itemWeapon;

        private ItemClothing _itemClothing;
        public string Name { get; set; }

        public int White { get; set; }

        public double Cost { get; set; }

        public Item(ItemWeapon itemWeapon, ItemClothing itemClothing, string name, int white, double cost)
        {
            _itemWeapon = itemWeapon;
            _itemClothing = itemClothing;
            Name = name;
            White = white;
            Cost = cost;
        }
    }
}
