using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class ItemPickUp
    {
        public Item item;
        
        
        void PickUp(Player player, Item item)
        {
            Console.WriteLine("Picking up " + item.Name);
            // add to inventory
           player.inventory.Add(item);
        }

    }
}
