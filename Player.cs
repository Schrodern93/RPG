using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class Player
    {
        public string PlayerName;
        public int CurrentHealth { get; private set; }

        public StatModifier armor;
        public StatModifier damage;
        public StatModifier runspeed;
        public StatModifier healt;
        public StatModifier agility;
        public StatModifier strength;
        public StatModifier intelligence;

        public Player(string playerName, int playerHealth)
        {
            PlayerName = playerName;
            CurrentHealth = playerHealth;
        }


        public void TakeDamage(int damageTaken)
        {

            damageTaken -= armor.GetValue();

            //dennne gjør at player ikke blir healet av å ta skade
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
    }
}
