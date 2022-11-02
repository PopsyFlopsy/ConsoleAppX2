using System.Runtime.InteropServices;

namespace ConsoleAppX2
{
    class Guy
    {
        public string Name;
        public int Cash;
        static void Main(string[] args)
        {
            Random random = new Random();
            double odds = 0.75;
            Guy player = new Guy() { Cash = 100, Name = "The player"};
            Console.WriteLine($"Hello, beetch, odds are {odds}");
            for (int i = 0; player.Cash > 0; i++)
            {
                Console.WriteLine($"{player.Name} has {player.Cash}");
                Console.Write("How much do you want to bet: ");
                string howMuch = Console.ReadLine();
                if (int.TryParse(howMuch, out int amount))
                {
                    int pot = amount * 2;
                    if (random.NextDouble() > odds)
                    {
                        Console.WriteLine($"You win {pot}, slut");
                        player.Cash += pot;
                    }
                    else
                    {
                        Console.WriteLine("Ya los beetc");
                        player.Cash -= amount;
                    }
                }
            }
        }
    }
}