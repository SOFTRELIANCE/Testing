using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            Console.WriteLine("Input the first Number:");
            string firstNumber = Console.ReadLine();


            Console.WriteLine("Input the second Number:");
            string secondNumber = Console.ReadLine();

            Console.WriteLine("What do you want to do with those numbers?");
            Console.WriteLine("[A]dd");
            Console.WriteLine("[S]ubstract");
            Console.WriteLine("[M]ultiply");

            string userInput = Console.ReadLine();

            if (userInput.ToUpper() == "A" )
            {
                Console.WriteLine($"{firstNumber} + {secondNumber} = {(int.Parse(firstNumber) + int.Parse(secondNumber))}");
            }
            else if (userInput.ToUpper() == "S")
            {
                Console.WriteLine($"{firstNumber} - {secondNumber} = {(int.Parse(firstNumber) - int.Parse(secondNumber))}");
            }
            else if (userInput.ToUpper() == "M" )
            {
                Console.WriteLine($"{firstNumber} * {secondNumber} = {(int.Parse(firstNumber) * int.Parse(secondNumber))}");
            }
            else
            {
                Console.WriteLine("Invalid option");
            }


            Console.WriteLine("Press any Key to close");
            Console.ReadKey();
        }
    }
}
