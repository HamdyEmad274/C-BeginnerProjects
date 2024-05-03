namespace Guess_The_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Guess The Number Game");
            Console.WriteLine("Guess The Number From 1 To 10");
            Console.WriteLine("You Have 5 Chances To Guess The Number");

            Random random = new Random();

            int number = random.Next(1, 11);
            int numberOfGuesses = 5;
            int guess = 0;
            bool isGuessed = false;

            while (guess != number && numberOfGuesses > 0)
            {
                Console.WriteLine("Enter Your Guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess > number + 2 && guess < 11)
                {
                    Console.WriteLine("Your Guess Is Too High");
                    numberOfGuesses--;
                }
                else if (guess >= number + 1 && guess <= number + 2 && guess < 11)
                {
                    Console.WriteLine("Your Guess Is Close , Try Again");
                    numberOfGuesses--;
                }
                else if (guess <= number - 1 && guess >= number - 2 && guess >= 1)
                {
                    Console.WriteLine("Your Guess Is Close , Try Again");
                    numberOfGuesses--;
                }
                else if (guess < number - 2 && guess >= 1)
                {
                    Console.WriteLine("Your Guess Is Too Low");
                    numberOfGuesses--;
                }
                else if (guess == number)
                {
                    Console.WriteLine("Your Guess Is Correct");
                    isGuessed = true;
                    break;
                }
                else if (guess>10 || guess<1)
                {
                    Console.WriteLine("Invalid Input");
                    numberOfGuesses--;
                }
            }
            if (isGuessed == false)
            {
                Console.WriteLine("Sorry , You Are Out Of Chances");
            }
            else
            {
                Console.WriteLine("Congratulations , You Guessed The Number");
            }
            Console.WriteLine("Thanks For Playing");
        }
    }
}
