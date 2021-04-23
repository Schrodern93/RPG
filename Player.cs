using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class Player
    {
        public string PlayerName;
        internal Game _game;
        public int CurrentHealth; 
        public LevelingSystem levelingSystem;

        //public StatModifier armor;
        //public StatModifier damage;
        //public StatModifier runspeed;
        //public StatModifier healt;
        //public StatModifier agility;
        //public StatModifier strength;
        //public StatModifier intelligence;

       
        internal Player(Game game, string playerName, int playerHealth)
        {
            _game = game;
            PlayerName = playerName;
            CurrentHealth = playerHealth;
            levelingSystem = new LevelingSystem();
        }


        public void TakeDamage(int damageTaken)
        {

            //damageTaken -= armor.GetValue();

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
    }
}
