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
                     
                if (bet == 1)
                {
                    j += 1;
                    Console.WriteLine("Won");
                    Console.WriteLine("Total Amount =" + j);

                }
                else
                {
                    j -= 1;
                    Console.WriteLine("Loose");
                    Console.WriteLine("Total Amount =" + j);

                }
            }
        }
    }

