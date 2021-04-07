using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class PlayerStats : IOnEquipmentChange
    {
        public Player player;

        public PlayerStats()
        {
            EquipmentManager.Instance.SubscribeChanges(this);
        }
        public void OnEquipmentChange(Equipment newEquipment, Equipment oldEquipment)
        {
            if (newEquipment != null)
            {
                player.armor.AddModifier(newEquipment.ArmorModifier);
                //Mangler noe her!
            }

            if (oldEquipment != null)
            {
                player.armor.RemoveModifier(oldEquipment.ArmorModifier);
                player.damage.RemoveModifier(oldEquipment.DamageModifier);
                player.runspeed.RemoveModifier(oldEquipment.RunSpeedModifier);
                player.healt.RemoveModifier(oldEquipment.HealthModifier);
                player.agility.RemoveModifier(oldEquipment.Agility);
                player.strength.RemoveModifier(oldEquipment.Strength);
                player.intelligence.RemoveModifier(oldEquipment.Intelligence);
            }
        }
    }
}
