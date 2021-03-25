using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class EquipmentManager
    {
       
        public static EquipmentManager instance;

        Equipment[] currentEquipment;
        public delegate void OnEquipmentChanged(Equipment newItem, Equipment oldItem);
        // lage interface istedenfor et delegate 
        public OnEquipmentChanged onEquipmentChanged;

        Inventory inventory;

        public EquipmentManager()
        {
            inventory = Inventory.inventory;

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
            if (onEquipmentChanged != null)
            {
                onEquipmentChanged.Invoke(newItem, oldItem);
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

                if (onEquipmentChanged != null)
                {
                    onEquipmentChanged.Invoke(null, oldItem);
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
    }
}
