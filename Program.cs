using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, What is your name?\n");
            var name = Console.ReadLine();
            

            Console.WriteLine($"Nice to meet you, {name}. I am your console.\n");
            Console.WriteLine("Please input a number between 1 and 100: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            { 
                Console.WriteLine($"Your number is {number}. It is an even number."); 
            }


            else
            {
                Console.WriteLine($"Your number is {number}. It is an odd number.");
            }
            

            if (number < 25)
            {
                Console.WriteLine("Your number is less than 25.\n");
            }


            if (number % 2 == 0 && number >= 26 && number <= 60)

            {
                Console.WriteLine("Your number is within the range of 26 to 60.\n");
            }


            if (number > 60)
            {
                Console.WriteLine("Your number is greater than 60.\n");
            }

            Console.WriteLine($"Thank you for your input, {name}. The program will end now.");
        }
    }
}
