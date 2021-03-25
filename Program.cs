using System;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {

            var gameisrunning = true;
            // var player1 = new Player(100);
            //var eqm = new EquipmentManager(); 
           // player1.TakeDamage(50);

            while (gameisrunning)
            {

                var command = Console.ReadLine().ToUpper();

                //Console.WriteLine(eqm.CheckForCommand(command));

            }


        }
    }
}
