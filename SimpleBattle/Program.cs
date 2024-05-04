namespace SimpleBattle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Unit Player = new Unit( 100,25,10,"Hamdy");
            Unit Enemy = new Unit( 100,30,10,"Enemy");
            Random random = new Random();
            Console.WriteLine($"Hello {Player.UnitName}");
            while (!Player.IsDead && !Enemy.IsDead)
            {
                Console.WriteLine($"{Player.UnitName}'s Helath {Player.Hp} . Enemy's Helath {Enemy.Hp}");
                Console.WriteLine("What Choice Do You Want To Do (1=Attack) (2 or else = Heal)");
                int Choice = int.Parse(Console.ReadLine());
                if (Choice == 1)
                {
                    Console.WriteLine($"{Player.UnitName} Attacks");
                    Player.Attack(Enemy);
                }
                else
                {
                    Console.WriteLine($"{Player.UnitName} Heals");
                    Player.Heal();
                }
                if (Player.IsDead || Enemy.IsDead) break;
                Console.WriteLine($"Player's Helath {Player.Hp} . Enemy's Helath {Enemy.Hp}");
                Console.WriteLine("Enemy Turn");
                Thread.Sleep(1000);
                int rnd = random.Next(0, 2);
                if (rnd == 0)
                {
                    Console.WriteLine($"{Enemy.UnitName} Attacks");
                    Enemy.Attack(Player);
                }
                else
                {
                    Console.WriteLine($"{Enemy.UnitName} Heals");
                    Enemy.Heal();
                } 
            }
        }
    }
}
