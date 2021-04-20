using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Game
    {
        public EquipmentManager equipmentManager;
        public Player player;

        public Game(Player player)
        {
            equipmentManager = new EquipmentManager();
            this.player = player;
        }

        public bool IsRunning()
        {
            return true;
        }
    }
}
