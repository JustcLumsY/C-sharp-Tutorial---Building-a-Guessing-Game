using System;

namespace C_sharp_Tutorial___Building_a_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;

            while (guess != secretWord)
            {
                Console.Write("Enter guess: ");
                guess = Console.ReadLine();
             
                guessCount++;

                if (guessCount > 2)
                {
                    Console.Write("Out of guesses");
                    return;
                }
            }
            Console.Write("You Win!");
            Console.ReadLine();

            //do

            //{
            //    Console.Write("Enter guess: ");
            //    guess = Console.ReadLine();
            //}

            //while (guess != secretWord);
            //Console.Write("You Win!");
        }


    }
}
