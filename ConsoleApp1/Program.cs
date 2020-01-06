using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to the GuessNumber game!");
            Console.ResetColor();

            Console.Write("Type your name: ");

            string name = Console.ReadLine();

            Console.WriteLine("Hallo " + name + "! Try to guess the  number from 1 to 10.");

            while (true)
            {

                Random random = new Random();
                int num = random.Next(1, 10);
                int guess = 0;
                while (guess != num)
                {

                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        Console.WriteLine("It is not a number. Try again");
                        continue;
                    }
                    guess = Int32.Parse(input);

                    if (guess != num)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You are wrong!!");
                        Console.ResetColor();
                    }

                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You are correct!!");
                Console.ResetColor();

                Console.WriteLine("Do you want to play again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    Console.WriteLine("Try to guess the  number from 1 to 10.");
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }


                Console.Read();
            }
        }


    }
    
 }   
    

