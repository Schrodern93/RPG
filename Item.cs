using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class Item
    {
        public string Name;

        public Item(string name)
        {
            Name = name;
        }

        public virtual void Use()
        {
           // no skjer i denne metoden, det varierer fra klassene som arver
            Console.WriteLine("Using " + Name);
           
        }

        public void removeFromInventory()
        {
            //Inventory.inventory.Remove(this);

        }

    }
}
