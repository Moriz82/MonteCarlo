using System;

namespace MonteCarlo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int stake, goal, itterations, trials = 0, win = 0;
            int[] bets;

            stake = Int32.Parse(args[0]);
            goal = Int32.Parse(args[1]);
            itterations = Int32.Parse(args[2]);
            
            bets = new int[itterations];

            for (int i = 0; i < itterations; i++)
            {
                int betz = 0;
                int money = stake;
                while (true)
                {
                    int coinValue = random.Next(2); 

                    betz++;
                    
                    if (coinValue == 1)
                    {
                        money++;
                    }
                    else
                    {
                        money--;
                    }

                    trials++;

                    if (money >= goal)
                    {
                        win++;
                        bets[i] = betz;
                        break;
                    }

                    if (money <= 0)
                    {
                        bets[i] = betz;
                        break;
                    }
                }
            }
            Console.WriteLine("With "+itterations+" Trials, The average chance of winning is "+(double)win/itterations+" ");
        }
    }
}