namespace SimpleDiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PlayerDice = 0;
            int PlayerPoints = 0;
            int ComputerDice = 0;
            int ComputerPoints = 0;
            bool GameContinue = false;
            Random random = new Random();
            do
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Press any key to roll the dice");
                     var key = Console.ReadKey();
                    Console.WriteLine();
                    PlayerDice = random.Next(1, 7);
                    if (key.Key == ConsoleKey.Spacebar)
                    {
                        PlayerDice = 6;
                    }
                    Console.WriteLine($"Your Roll: {PlayerDice}");
                    Console.WriteLine("......");
                    System.Threading.Thread.Sleep(1000);
                    ComputerDice = random.Next(1, 7);
                    Console.WriteLine($"Computer Roll: {ComputerDice}");
                    if (PlayerDice > ComputerDice)
                    {
                        Console.WriteLine("You Win the Round");
                        PlayerPoints++;
                        Console.WriteLine($"The Score is: {PlayerPoints} For You - {ComputerPoints} For Computer");
                    }
                    else if (PlayerDice < ComputerDice)
                    {
                        Console.WriteLine("Computer Wins the Round");
                        ComputerPoints++;
                        Console.WriteLine($"The Score is: {PlayerPoints} For You - {ComputerPoints} For Computer");
                    }
                    else
                    {
                        Console.WriteLine("Draw");
                        Console.WriteLine($"The Score is: {PlayerPoints} For You - {ComputerPoints} For Computer");
                    }
                }
                Console.WriteLine("Game Over");
                if (PlayerPoints > ComputerPoints)
                {
                    Console.WriteLine("You Win the Game");
                }
                else if (PlayerPoints < ComputerPoints)
                {
                    Console.WriteLine("Computer Wins the Game");
                }
                else
                {
                    Console.WriteLine("Draw");
                } 
                Console.WriteLine("Do you want to play again? (Y/N)");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    GameContinue = true;
                    PlayerPoints = 0;
                    ComputerPoints = 0;
                    Console.Clear();
                }
                else
                {
                    GameContinue = false;
                }
            } while (GameContinue==true);
        }
    }
}
