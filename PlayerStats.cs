using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
     public class PlayerStats
    {
        public Player player;

        public PlayerStats()
        {
            EquipmentManager.instance.onEquipmentChanged += OnEquipmentChanged;
        }
        void OnEquipmentChanged(Equipment newItem, Equipment oldItem)
        {
            if (newItem != null)
            {
                armor.AddModifier(newItem.armorModifier);
                //mangler noe her
            }

            if (oldItem != null)
            {
                armor.RemoveModifier(oldItem.armorModifier);
                damage.RemoveModifier(oldItem.damageModifier);
                runspeed.RemoveModifier(oldItem.runSpeedModifier);
                healt.RemoveModifier(oldItem.healthModifier);
                agility.RemoveModifier(oldItem.agility);
                strength.RemoveModifier(oldItem.strength);
                intelligence.RemoveModifier(oldItem.intelligence);
            }
        }
    }
}
