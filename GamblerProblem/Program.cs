using System;

namespace GamblerProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gambler Problem");

			//int stackmoney = 100;
			//int betmoney = 1;
			//Console.WriteLine($"Money is : {stakemoney}");
			//Console.WriteLine($"Money is : {betmoney}");

			Game game = new Game();
            game.StartGame();
            game.Bet();
		}
    }
}