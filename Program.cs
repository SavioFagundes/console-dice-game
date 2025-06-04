namespace Program
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNumber = 0;
            int enemyRandomNumber = 0;

            int playerPoints = 0;
            int enemyPoints = 0;
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Press any key to roll the dice...");
                Console.ReadKey();

                playerRandomNumber = new Random().Next(1, 7);
                System.Console.WriteLine("you rolled a " + playerRandomNumber);

                System.Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNumber = new Random().Next(1, 7);
                System.Console.WriteLine("The enemy rolled a " + enemyRandomNumber);

                if (playerRandomNumber > enemyRandomNumber)
                {
                    playerPoints++;
                    System.Console.WriteLine("You win this round!");
                }
                else if (playerRandomNumber < enemyRandomNumber)
                {
                    enemyPoints++;
                    System.Console.WriteLine("The enemy wins this round!");
                }
                else
                {
                    System.Console.WriteLine("It's a tie!");
                }
            }
            System.Console.WriteLine("Game over!");
            System.Console.WriteLine("You scored " + playerPoints + " points.");
            System.Console.WriteLine("The enemy scored " + enemyPoints + " points.");
        }
    }
}