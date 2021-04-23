using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class Equipment : Item
    {
        public EquipmentSlot equipmentSlot;
        internal Game game;
       
        public int ArmorModifier;
        public int DamageModifier;
        public int HealthModifier;
        public int RunSpeedModifier;
        public int Agility;
        public int Strength;
        public int Intelligence;

        public Equipment(string name, EquipmentSlot equipmentSlot, int armorModifier, int damageModifier, int healthModifier, int runSpeedModifier, int agility, int strength, int intelligence) : base(name)
        {
            this.equipmentSlot = equipmentSlot;
            ArmorModifier = armorModifier;
            DamageModifier = damageModifier;
            HealthModifier = healthModifier;
            RunSpeedModifier = runSpeedModifier;
            Agility = agility;
            Strength = strength;
            Intelligence = intelligence;
        }
        
        public override void Use()
        {
            base.Use();

            //EquipmentManager.Instance.Equip(this);
            game.EquipmentManager.Equip(this);
            removeFromInventory();
        }
      
    }

    public enum EquipmentSlot { Head, Chest, Gloves, Legs, MainHand, OffHand, Feet, Ring }
}

