using System;


namespace GuessingRandomNumber
{
    class GuessingRandomNumber
    {
        static void Main(string[] args)

        {
            Random random = new Random();

            int randomNumber = random.Next(1, 1000);

            int Guess = 0;

            Console.WriteLine("Guess a number between 1 to 1000");

            while (Guess != randomNumber)
            {
                Guess = Convert.ToInt32(Console.ReadLine());

                if (Guess < randomNumber)
                {
                    Console.WriteLine("Sorry, the number is higher than " + Guess + ". Guess another number");
                }
                else if (Guess > randomNumber)
                {
                    Console.WriteLine("Sorry, the number is lower than " + Guess + ". guess another number");
                }
            }
            Console.WriteLine("Great! The answer was " + randomNumber);
            Console.ReadLine();

        }
    }
}
