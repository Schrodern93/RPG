using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class Equipment : Item
    {
        public EquipmentSlot equipmentSlot;

        public int armorModifier;
        public int damageModifier;
        public int healthModifier;
        public int runSpeedModifier;
        public int agility;
        public int strength;
        public int intelligence;

        public override void Use()
        {
            base.Use();

            EquipmentManager.instance.Equip(this);
            
            removeFromInventory();
        }
      
    }

    public enum EquipmentSlot { Head, Chest, Gloves, Legs, MainHand, OffHand, Feet, Ring }
}

