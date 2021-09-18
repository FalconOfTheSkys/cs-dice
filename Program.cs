using System;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Dice! 
            */

            RollDice(5);
            Console.ReadKey();

        }

        static void RollDice(int RollAttempts)
        {
            Random intgen = new Random(); //Create random object
            int i = 0; //Set i to 0

            if(RollAttempts>0)//If RollAttempts>0
            {
                while (i != RollAttempts)//While i is not equal to RollAttempts
                {
                    int roll = intgen.Next(1, 7);
                    Console.WriteLine("You rolled, " + roll);
                    i++;

                    /*
                    Generate a new random number and increment i 
                    */ 
                }
            }
            else
            {
                //If it is 0 then generate 1 random number and print it.
                int roll = intgen.Next(1, 7);
                Console.WriteLine("You rolled, "+roll);
            }

        }
    }
}
