using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
            


            int minValue = 0;
            int maxValue = 0;
            int inputValue = 0;

            
            
            Console.WriteLine("Prompter");
            Console.WriteLine();
            Console.WriteLine("Input a minimum value");

            while (!Int32.TryParse(Console.ReadLine(), out minValue))
            {
                Console.Clear();
                Console.WriteLine("Input a minimum value");

            }
            Console.WriteLine("Input a maximum value");

            while (!Int32.TryParse(Console.ReadLine(), out maxValue) || maxValue < minValue)
            {
                Console.Clear();
                Console.WriteLine("Input a maximum value");

            }
            do
            {
                Console.WriteLine($"Input a value between the min and max: {minValue}, {maxValue}");

                if (!Int32.TryParse(Console.ReadLine(), out inputValue) || minValue > inputValue || maxValue < inputValue)
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue!");
                    Console.ReadKey();
                    Console.Clear();
                }
                



            } while (minValue > inputValue || maxValue < inputValue);

            Console.WriteLine($"You inputted {minValue}, {maxValue} and the inbetween value of {inputValue}");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue!");
            Console.ReadKey();
            Console.Clear();

            
        }
        public static void SimpleBank()
        {
            double bal = 150;
            double transactionFee = 0.75;

            double deposit = 0;
            double withdrawl = 0;

            string input = "";

            bool finish = false;

            bool subFinish = false;

            while (!finish)
            {
                finish = false; subFinish = false;

                Console.WriteLine("Welcome to the Bank of Blorb!");
                Console.WriteLine();
                Console.WriteLine($"Current BALANCE : ${bal}");

                Console.WriteLine();

                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdrawl");

                input = Console.ReadLine();

                if (input.Trim() == "0" || input.ToLower().Trim() == "exit")
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for using the Bank of Blorb!");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to EXIT.");
                    Console.ReadKey();

                    finish = true;
                }
                else if (input.Trim() == "1" || input.ToLower().Trim() == "deposit")
                {
                    while (!subFinish)
                    {
                        Console.Clear();

                        Console.WriteLine("Welcome to the Bank of Blorb!");
                        Console.WriteLine();
                        Console.WriteLine($"Current BALANCE : ${bal}");

                        Console.WriteLine();

                        Console.WriteLine("Deposit");

                        if (double.TryParse(Console.ReadLine(), out deposit))
                        {
                            if (deposit < 0)
                            {
                                Console.WriteLine("Invalid Input: Positive Value Required.");
                                
                                Console.WriteLine();
                                Console.WriteLine("Press any key to EXIT.");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Clear();

                                Console.WriteLine($"You deposited {deposit}.");
                                Console.WriteLine();

                                bal = bal + deposit - transactionFee;

                                Console.WriteLine($"Current Balance : {bal}");

                                deposit = 0;


                                Console.WriteLine();
                                Console.WriteLine("Press any key to EXIT.");
                                Console.ReadKey();

                                subFinish = true;

                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input: Input Number.");

                            Console.WriteLine();
                            Console.WriteLine("Press any key to EXIT.");
                            Console.ReadKey();
                        }
                        


                    }
                }
                else if (input.Trim() == "2" || input.ToLower().Trim() == "withdrawl")
                {
                    while (!subFinish)
                    {
                        Console.Clear();

                        Console.WriteLine("Welcome to the Bank of Blorb!");
                        Console.WriteLine();
                        Console.WriteLine($"Current BALANCE : ${bal}");

                        Console.WriteLine();

                        Console.Write("Withdrawl : -$");

                        if (double.TryParse(Console.ReadLine(), out withdrawl))
                        {
                            if (withdrawl < 0)
                            {
                                Console.WriteLine("Invalid Input: Positive Value Required.");

                                Console.WriteLine();
                                Console.WriteLine("Press any key to EXIT.");
                                Console.ReadKey();
                            }
                            else if ((withdrawl + transactionFee) < bal)
                            {
                                Console.Clear();

                                Console.WriteLine($"You withdrew ${withdrawl}.");
                                Console.WriteLine();

                                bal = bal - withdrawl - transactionFee;

                                Console.WriteLine($"Current Balance : ${bal}");

                                withdrawl = 0;


                                Console.WriteLine();
                                Console.WriteLine("Press any key to EXIT.");
                                Console.ReadKey();

                                subFinish = true;

                            }
                            else 
                            {
                                Console.WriteLine("Invalid Input: You lack the required funds.");

                                Console.WriteLine();
                                Console.WriteLine("Press any key to EXIT.");
                                Console.ReadKey();
                            }

                        }
                        else
                        {
                            Console.WriteLine("Invalid Input: Input Number.");

                            Console.WriteLine();
                            Console.WriteLine("Press any key to EXIT.");
                            Console.ReadKey();
                        }



                    }
                }
                else 
                {
                    Console.WriteLine("Invalid Input: Input Number.");

                    Console.WriteLine();
                    Console.WriteLine("Press any key to EXIT.");
                    Console.ReadKey();
                }
                
                Console.Clear();
            }
        }
        public static void Doubles()
        {

        }

    }
}
