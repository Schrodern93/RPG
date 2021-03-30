using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class EquipmentManager : IOnEquipmentchange
    {
        // kanskje en private construktor som new'er eqmanager 
        //public static EquipmentManager instance;
        public EquipmentManager instance;
        //public EquipmentManager equipmentManager;
        //private EquipmentManager()
        //{
        //    equipmentManager = new EquipmentManager();
        //}

        Equipment[] currentEquipment;
        //public delegate void OnEquipmentChanged(Equipment newItem, Equipment oldItem);
        // lage interface istedenfor et delegate 
        //public OnEquipmentChanged onEquipmentChanged;
      

        Inventory inventory;

        public EquipmentManager()
        {
            inventory = Inventory.instance;
            instance = new EquipmentManager();
            int numSlots = Enum.GetNames(typeof(EquipmentSlot)).Length;
            currentEquipment = new Equipment[numSlots];

        }

        public void Equip(Equipment newItem)
        {
            int slotIndex = (int)newItem.equipmentSlot;

            Equipment oldItem = null;
            if (currentEquipment[slotIndex] != null)
            {
                oldItem = currentEquipment[slotIndex];
                inventory.Add(oldItem);
            }
            //if (onEquipmentChanged != null)
            if (newItem != null && oldItem != null)
            {
                //onEquipmentChanged.Invoke(newItem, oldItem);
                OnEquipmentchange(newItem, oldItem);
            }
            currentEquipment[slotIndex] = newItem;
        }
       
        public void Unequip(int slotIndex)
        {
            if (currentEquipment[slotIndex] != null)
            {
                Equipment oldItem = currentEquipment[slotIndex];
                inventory.Add(oldItem);

                currentEquipment[slotIndex] = null;

                //if (onEquipmentChanged != null)
                if (oldItem != null)
                {
                    //onEquipmentChanged.Invoke(null, oldItem);
                    OnEquipmentchange(null, oldItem);
                }
            }
        }

        public void UnequipAll()
        {
            for (int i = 0; i < currentEquipment.Length; i++)
            {
                Unequip(i);
            }
        }

        // burde trekkes ut i en commandlist? 
        public string CheckForCommand(string command)
        {
            if (command == "U")
            {
                UnequipAll();
                return "Unequipping all!";
            }
            return null;
        }

        public Equipment OnEquipmentchange(Equipment newEquipment, Equipment oldEquipment)
        {
            if (newEquipment == null && oldEquipment != null)
            {
                oldEquipment = null;
                return oldEquipment;
            }

            if (newEquipment != null && oldEquipment != null)
            {
                return newEquipment;
            }

            return null;
        }
    }
}
