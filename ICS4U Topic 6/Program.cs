using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICS4U_Topic_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            string menuInput = "0";

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Menu");
                Console.WriteLine();

                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Prompter");
                Console.WriteLine("2. Simple Banking Machine");
                Console.WriteLine("3. Doubles Roller");


                Console.WriteLine();
                Console.Write("Enter your choice: ");
                menuInput = Console.ReadLine();

                if (menuInput == "0")
                {
                    exit = true;
                }
                else if (menuInput == "1")
                {
                    Console.Clear();
                    Prompter();
                    Console.Clear();
                }
                else if (menuInput == "2")
                {
                    Console.Clear();
                    SimpleBank();
                    Console.Clear();
                }
                else if (menuInput == "3")
                {
                    Console.Clear();
                    Doubles();
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        }

        public static void Prompter()
        {
            bool minValid = false;
            bool maxValid = false;
            bool inputValid = false;


            int minValue = 0;
            int maxValue = 0;
            int inputValue = 0;

            
            
                Console.WriteLine("Prompter");
                Console.WriteLine();
                while (!minValid)
                {
                    Console.WriteLine("Input a minimum value");

                    if (Int32.TryParse(Console.ReadLine(), out minValue))
                    {
                        minValid = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue!");
                        Console.ReadKey();
                        Console.Clear();

                    }
                }
                while (!maxValid)
                {
                    Console.WriteLine("Input a maximum value");

                    if (Int32.TryParse(Console.ReadLine(), out maxValue))
                    {
                        maxValid = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue!");
                        Console.ReadKey();
                        Console.Clear();

                    }
                } 
                while (!inputValid)
                {
                    Console.WriteLine($"Input a value between the min and max: {minValue}, {maxValue}");

                    if (Int32.TryParse(Console.ReadLine(), out inputValue))
                    {
                    if (minValue < inputValue && maxValue > inputValue)
                    {
                        inputValid = true;
                    }
                    else 
                    {
                        Console.WriteLine("Invalid Input");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue!");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue!");
                        Console.ReadKey();
                        Console.Clear();

                    }


                
                }

            Console.WriteLine($"You inputted {minValue}, {maxValue} and the inbetween value of {inputValue}");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue!");
            Console.ReadKey();
            Console.Clear();

            
        }
        public static void SimpleBank()
        {

        }
        public static void Doubles()
        {

        }

    }
}
