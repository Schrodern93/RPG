using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class EquipmentManager
    {

        public static EquipmentManager Instance => _instance ??= new EquipmentManager();
        private static EquipmentManager _instance = null;
        private List<IOnEquipmentChange> _subscribers;
        Equipment[] currentEquipment;
        Inventory inventory;

        internal EquipmentManager()
        {
            int numSlots = Enum.GetNames(typeof(EquipmentSlot)).Length;
            currentEquipment = new Equipment[numSlots];
            _subscribers = new List<IOnEquipmentChange>();
        }

        public void SubscribeChanges(IOnEquipmentChange subscriber)
        {
            _subscribers.Add(subscriber);
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
           
            if (newItem != null && oldItem != null)
            {
                NotifySubscribers(newItem, oldItem);
            }
            currentEquipment[slotIndex] = newItem;
        }

        private void NotifySubscribers(Equipment newItem, Equipment oldItem)
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.OnEquipmentChange(newItem, oldItem);
            }
        }

        public void Unequip(int slotIndex)
        {
            if (currentEquipment[slotIndex] != null)
            {
                Equipment oldItem = currentEquipment[slotIndex];
                inventory.Add(oldItem);
                currentEquipment[slotIndex] = null;

                if (oldItem != null)
                {
                    NotifySubscribers(null, oldItem);
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

        // burde trekkes ut i en commandlist? ********************************************************
        public string CheckForCommand(string command)
        {
            if (command == "U")
            {
                UnequipAll();
                return "Unequipping all!";
            }
            return null;
        }
        //********************************************************************************************
      
    }
}
