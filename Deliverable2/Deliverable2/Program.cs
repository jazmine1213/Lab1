using System;

namespace FlippingCoin
{
    class Program
    {

        static void Main(string[] args)
        {

            int choice;
            Console.Write("Guess which will have more: heads or tails?");
            string headsOrTailsGuess = Console.ReadLine();
            if (headsOrTailsGuess.ToLower().Trim() == "heads")
            { 
                choice = 0;
            }
            else
            { 
                choice = 1;
            }

            Console.Write("How many times shall we flip the coin? ");
            int numberOfFlips = int.Parse(Console.ReadLine());

            // Declare variables
            Random rand = new Random();
            int correctCount = 0;
            //int percentage = (correctCount / numberOfFlips) * 100;
            //int heads = 0;
            //int tails = 1;

            for (int i = 0; i < numberOfFlips; i++)
            {
                int result = rand.Next(0, 2);

                if (result == 0)
                {
                    Console.WriteLine("Heads!");
                }
                else
                {
                    Console.WriteLine("Tails!");
                }
                if (result == choice)
                { //comparing result to parsed choice and incrementing the counter
                    correctCount++;
                }

            }
            Console.WriteLine("Your guess, " + headsOrTailsGuess + " came up " + correctCount + " time(s).");
            int percentage = correctCount * 100 / numberOfFlips;
            Console.WriteLine("That's " + percentage + "%");
        }
    }
}
