using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class itemPickUp
    {
        public Item item;
        
        void PickUp()
        {
            Console.WriteLine("Picking up " + item.name);
            // add to inventory
            bool wasPickedUp = Inventory.instance.Add(item);
     
        }

    }
}
