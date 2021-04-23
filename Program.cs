using System;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {

            var gameisrunning = true;
            var game = new Game();
            var player1 = new Player(game,"rudolf",100);
           
            
            var eq = new Equipment("Axe of Doom", EquipmentSlot.MainHand, 10, 5, 50, 2, 1, 1, 1);
            
            player1.levelingSystem.AddExperience(20);
            game.AddExperience(30);

            game.EquipmentManager.Equip(eq);


           
            // player1.TakeDamage(50);
            var item = new Item("test");
            while (gameisrunning)
            {
               
                var command = Console.ReadLine().ToUpper();
               

            }


        }
    }
}
