using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamblerProblem
{
    public class Game
    {
        public void StartGame()
        {
            int stakemoney = 100;
            int betmoney = 1;
            Console.WriteLine($"Money is : {stakemoney}");
            Console.WriteLine($"Money is : {betmoney}");
        }

        public void Bet()
        {
            int i = 1;
            int j = 100;
            
            Random random = new Random();
            int bet = random.Next(2);
            int play = random.Next(0, 2);

            int InitialStake = (int)random.NextInt64();
            int maxStake = InitialStake + (50 % InitialStake);
            int minStake = InitialStake - (50 % InitialStake);

            while (InitialStake >= minStake && InitialStake <= maxStake)
            {
                

               
                switch (play)
                {

                    case 1:
                        InitialStake += bet;
                        Console.WriteLine("you win 1$");
                        Console.WriteLine("the stake after winning" + InitialStake);
                        break;
                    case 0:
                        InitialStake -= bet;
                        Console.WriteLine("you loose 1$");
                        Console.WriteLine("the stake after winning" + InitialStake);
                        break;
                }
                Console.WriteLine("Stake has reached to" + InitialStake);

            }

               
        }
    }
}

