using System;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {

            var gameisrunning = true;
            var player1 = new Player("rudolf",100);
            var eqm = EquipmentManager.Instance; 
            // player1.TakeDamage(50);
            var eq = new Equipment("Axe of Doom",EquipmentSlot.MainHand,10,5,50,2,1,1,1);
            var item = new Item("test");
            while (gameisrunning)
            {
               
                var command = Console.ReadLine().ToUpper();
               

            }


        }
    }
}
