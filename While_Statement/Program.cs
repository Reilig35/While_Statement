
using System;

namespace While_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the number between 1 and 5");
            int num = Convert.ToInt32(Console.ReadLine());

            bool Guess = false;

            do 
            { 
                switch(num) 
                {
                    case 1:
                        Console.WriteLine("Sorry it's not 1");
                        Console.WriteLine("Guess a number");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Correct it was 2 all along");
                        Guess = true;
                        break;
                    case 3:
                        Console.WriteLine("Sorry it's not 3");
                        Console.WriteLine("Guess a number");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Sorry it's not 4");
                        Console.WriteLine("Guess a number");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("Sorry it's not 5");
                        Console.WriteLine("Guess a number");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Sorry it has to be a number between 1 and 5");
                        Console.WriteLine("Guess a number");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                }
             }
            while (Guess == false);
            Console.WriteLine("\n\nPress ENTER for next programme");
            Console.Read();

           
            //Using While loop to find the ODD and EVEN numbers
            int i = 1;

            while(i <= 50)
            {
                if(i % 2 == 1)
                {
                    Console.WriteLine($"{i} is an ODD number");
                }
                else 
                {
                    Console.WriteLine($"{i} is an EVEN number");
                }
                i++;
            }
        }
    }
}
