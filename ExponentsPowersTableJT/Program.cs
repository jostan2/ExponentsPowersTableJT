using System;
using System.Xml.Linq;

namespace ExponentsJT
{
    internal class Program
    {
        static void Main()
        {
            bool Start = true; //Start of loop to restart program
            while (Start)
            {
                Console.WriteLine("Please enter an integer");
                var numcheck = int.TryParse(Console.ReadLine(), out int n); //numcheck = if-statement checking if "a" is a number between 1-100, and not a character or other invalid response.

                if (numcheck == false) //if "n" is not a number
                {
                    Console.WriteLine("That is not a number. Please try again.");
                    Console.WriteLine();
                }
                else if (numcheck == true && n < 1 || n > 100) //if "n" is a number, but is not within the range
                {
                    Console.WriteLine("That is not a valid number. Please try again.");
                    Console.WriteLine();
                }
                else
                {
                    int i;
                    int square;
                    int cubed;

                    Console.WriteLine("Number  Square  Cubed"); //column titles and border
                    Console.WriteLine("-------------------");

                    for (i = 1; i <= n; i++)
                    {
                        square = (i * i);
                        cubed = (i * i * i);
                        Console.WriteLine("{0})       {1}       {2}", i, square, cubed); //output of number counter ("n"), squared and cubed results of "n". Spacing of output box  off, as it just uses spaces.
                    }

                }
                    bool askAgain = true;//Loop to repeat restart/exit prompt
                    while (askAgain)
                    {
                        Console.WriteLine("Would you like to restart the program? Y/N");
                        string input = Console.ReadLine().ToLower();

                        if (input == "y")
                        {
                            Start = true; //yes to restart program
                            askAgain = false; //no to ask to restart
                        }
                        else if (input == "n")
                        {
                            Start = false; //no to restart program
                            askAgain = false; //no to ask to restart
                        }
                        else //if user input is not "y" or "n"
                        {
                            Console.WriteLine("I'm sorry, I'm afraid I can't do that. Please try again.");
                            askAgain = true;
                            Console.WriteLine();
                        }
                    }

               
            }

        }

    }
}