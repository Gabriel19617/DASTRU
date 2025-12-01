using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sasan_UsingControlStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            while (true) // looping
            {
                Console.WriteLine("This program will determine what type of number and display its range.");
                Console.Write("\nPlease enter a number: ");

                string input = Console.ReadLine();

                bool isValid = int.TryParse(input, out num); //convert strings into int/number

                if (!isValid) //if num this code will be excuted
                {
                    Console.WriteLine("Please re-try to enter a numeric value.");
                    Console.Write("\n\nDo you want to try again (y/n)? ");
                    string user = Console.ReadLine();
                    if (user == "y") // for retrying 
                    {
                        Console.Clear();
                        continue; // continues the loop 
                    }
                    break; // stops the loop
                }

                if (num % 2 == 0) // executed if the number is even
                {
                    Console.Write($"{num} is an even number.");
                    Console.WriteLine("\n\nThis is the range of numbers based from the number entered.");
                    while (num > 0) // condition of while
                    {
                        Console.Write(num + " ");
                        num = num - 2; // deducts the assigned num by 2
                    }

                    Console.Write("\n\nDo you want to try again (y/n)? ");
                    string retry = Console.ReadLine();
                    if (retry == "y") // for retrying
                    {
                        Console.Clear(); // clears the code

                    }

                    else if (retry == "n") // for exit
                    {
                        Console.Clear();
                        break; // breaks the loop
                    }
                }
                else if (num % 2 == 1) // executed if the number entered is odd
                {
                    Console.WriteLine("Sorry, I cannot provide the range of numbers based from the number you entered.");
                    Console.Write("\n\nDo you want to try again (y/n)? ");
                    string retry = Console.ReadLine();
                    if (retry == "y") // for retrying
                    {
                        Console.Clear(); // clears the code
                        continue; // continues the loop

                    }
                    else if (retry == "n") // for exiting
                    {
                        Console.Clear();
                        break; // breaks the loop
                    }

                }

            }
            Console.Clear();
            Console.WriteLine("Thank you for using this program.");
            Console.ReadKey(); // reads any key to exit
        }
    }
}

