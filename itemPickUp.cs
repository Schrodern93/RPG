using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class ItemPickUp
    {
        public Item item;
        
        void PickUp()
        {
            Console.WriteLine("Picking up " + item.Name);
            // add to inventory
            bool wasPickedUp = Inventory.instance.Add(item);
     
        }

    }
}
