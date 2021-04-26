using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class Player
    {
        public string PlayerName { get; private set; }
        public int CurrentHealth { get; private set; }
        internal EquipmentManager EquipmentManager { get; private set; }
        public LevelingSystem levelingSystem;
        public Inventory inventory;
        public PlayerStats playerStats;
  


        public StatModifier armor { get; }
        public StatModifier damage { get; }
        public StatModifier runspeed { get; }
        public StatModifier healt { get; }
        public StatModifier agility { get; }
        public StatModifier strength { get; }
        public StatModifier intelligence { get; }


        internal Player(string playerName, int playerHealth)
        {
            PlayerName = playerName;
            CurrentHealth = playerHealth;
            EquipmentManager = new EquipmentManager();
            levelingSystem = new LevelingSystem();
            inventory = new Inventory();
            playerStats = new PlayerStats();
        }


        public void TakeDamage(int damageTaken)
        {

            damageTaken -= armor.GetValue();

            //denne gjør at player ikke blir healet av å ta skade
            damageTaken = Math.Clamp(damageTaken, 0, int.MaxValue);

            CurrentHealth -= damageTaken;
            Console.WriteLine("player takes " + damageTaken + " damage.");

            if (CurrentHealth <= 0)
            {
                Die();
            }

        }

        private void Die()
        {
           Console.WriteLine(" player Died!!! ");
        }

        public void AddExperience(int gainedXP)
        {
           levelingSystem.AddExperience(gainedXP);
        }
    }
}
