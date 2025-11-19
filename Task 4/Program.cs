namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.playerName = "Hero";
            player.level = 1;
            player.health = 100;

            Player player1 = new Player("Hero1", 2, 90);

            Console.WriteLine("\nPlayer Details:");
            Console.WriteLine($"Name: {player.playerName}, Level: {player.level}, Health: {player.health}");


            Console.WriteLine("\nPlayer 1 Details:");
            Console.WriteLine($"Name: {player1.playerName}, Level: {player1.level}, Health: {player1.health}");
        }
    }
}
