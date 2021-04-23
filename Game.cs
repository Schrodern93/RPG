using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Game
    {
        internal EquipmentManager EquipmentManager { get; private set; }
        public Player player;
         
        public Game()
        {
            EquipmentManager = new EquipmentManager();
            player = new Player(this, "Joakim", 100);
        }

        public bool IsRunning()
        {
            return true;
        }

        public void AddExperience(int gainedXP)
        {
            player.levelingSystem.AddExperience(gainedXP);
        }
    }
}
