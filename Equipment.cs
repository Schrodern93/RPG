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

        public Equipment(string name,int armorModifier, int damageModifier, int healthModifier, int runSpeedModifier, int agility, int strength, int intelligence)
            :base(name)
        {
            Name = name;
         
            this.armorModifier = armorModifier;
            this.damageModifier = damageModifier;
            this.healthModifier = healthModifier;
            this.runSpeedModifier = runSpeedModifier;
            this.agility = agility;
            this.strength = strength;
            this.intelligence = intelligence;
        }

        //public Equipment(string name)
        //{

        //}

        public override void Use()
        {
            base.Use();

            EquipmentManager.instance.Equip(this);
            
            removeFromInventory();
        }
      
    }

    public enum EquipmentSlot { Head, Chest, Gloves, Legs, MainHand, OffHand, Feet, Ring }
}

