namespace SimpleBattle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Unit Player = new Unit( 100,20,10,"Hamdy");
            Unit Enemy = new Unit( 75,20,10,"Enemy");
            Console.WriteLine($"Hello {Player.UnitName}");
            Console.WriteLine($"{Player.UnitName}'s Helath {Player.Hp} . Enemy's Helath {Enemy.Hp}");
            Console.WriteLine("What Choice Do You Want To Do (1=Attack)");
            int Choice = int.Parse(Console.ReadLine());
            if (Choice == 1)
            {
                Console.WriteLine($"{Player.UnitName} Attacks");
                Player.Attack(Enemy);

            }
            Console.WriteLine($"Player's Helath {Player.Hp} . Enemy's Helath {Enemy.Hp}");
        }
    }
}
