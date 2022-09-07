using System;
namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool stopLoop = false;
            do {
                try
                {
                    PrintMainMenu();
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1: CheckNumber();
                            break;

                        case 2: Console.WriteLine("EX2 ");
                            break;

                        case 3: LandscapeOrPotrait();
                            break;

                        case 4: CheckSpeed();
                            break;

                        case 5: Calculator();
                            break;

                        case 9: Console.WriteLine("See you soon!");
                            stopLoop = true;
                            break;

                        default: Console.WriteLine(choice + " is not on the menu. Please try again!");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Something wrong happend.");
                }
            }while(!stopLoop);
        } // End of Main
        static void PrintMainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("---- MENU ----");
            Console.WriteLine(" 1 - Check number between 1 and 10 ");
            Console.WriteLine(" 2 -  EX2 ");
            Console.WriteLine(" 3 - Image portrait or landscape? ");
            Console.WriteLine(" 4 - Check Speed ");
            Console.WriteLine(" 5 - Calculator ");
            Console.WriteLine(" 9 - Exit ");
        } 

        /* EX1. 
         * Check if number from user is between 1 and 10.
         */
        static void CheckNumber() { 
            Console.Write("Write a number between 1 and 10: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num >= 1 && num <= 10)
            { 
                    Console.WriteLine("The number is valid. - " + num);
            } 
            else
            {
                Console.WriteLine("The number is invalid. - " + num);
            }
         }

        /* EX3. 
            * The user to enter the width and height of an image. Then tell if the image is landscape or portrait.
        */
        static void LandscapeOrPotrait() { 
            Console.WriteLine("Write the width and height of an image. ");
            Console.Write("Width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Heigth: ");
            int heigth = Convert.ToInt32(Console.ReadLine());

            if (width > heigth)
            {
                Console.WriteLine("The image is landscape. ");
            }
            else
            {
                Console.WriteLine("The image is portrait. ");
            }
        }

        /* EX4.
            * The user enter the speed limit and the speed of a car. 
            * If the user enters a value less than the speed limit, display Ok on the console.
            * If the value is above the speed limit, calculate the number of failure points.
            * For every 5km/hr above the speed limit, 1 failure point should be incurred and displayed on the console. 
            * If the number of failure points is above 12, display License Suspended.
            */
        static void CheckSpeed() { 
            Console.WriteLine("Write the speed limit and the speed of the car. ");
            Console.Write("Speed limit: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            Console.Write("Speed: ");
            int speed = Convert.ToInt32(Console.ReadLine());

            if (limit >= speed)
            {
                Console.WriteLine("OK. ");
            }
            else
            {
                int diff = speed - limit;
                int failurepoint = diff / 5;
                Console.WriteLine("Difference: " + diff + " Failure point: " + failurepoint);
                if (failurepoint > 12)
                {
                    Console.WriteLine("Your drivers license will be suspended.");
                }
            }
        }

        /* Assignment 
         * Basic Console-based calculator. It handles basic mathematical 
         * operations, addition, subtraction, multiplication, division.
         */

        static void PrintCalculatorMenu()
        {
            Console.WriteLine();
            Console.WriteLine("---- CALCULATOR ----");
            Console.WriteLine(" 1 - Addision ");
            Console.WriteLine(" 2 - Subtraction ");
            Console.WriteLine(" 3 - Muliplication ");
            Console.WriteLine(" 4 - Division ");
            Console.WriteLine(" 9 - Exit ");
        }

        static void Addition()
        {
            Console.WriteLine("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine(num1 + " + " + num2 + " = " + sum);
        }

        static void Subtraction()
        {
            Console.WriteLine("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 - num2;
            Console.WriteLine(num1 + " - " + num2 + " = " + sum);
        }

        static void Muliplication()
        {
            Console.WriteLine("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 * num2;
            Console.WriteLine(num1 + " * " + num2 + " = " + sum);
        }

        static void Division()
        {
            Console.WriteLine("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if(num1 == 0 || num2 == 0)
            {
                Console.WriteLine("0 is not a valid number.");
                return;
            }
            int sum = num1 / num2;
            Console.WriteLine(num1 + " / " + num2 + " = " + sum);
        }

        static void Calculator()
        {
            bool keepLoop = true;
            do
            {
                try
                {
                    PrintCalculatorMenu();
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1: Addition();                            
                            break;

                        case 2: Subtraction();
                            break;

                        case 3: Muliplication();
                            break;

                        case 4: Division();
                            break;

                        case 9: Console.WriteLine("See you soon!");
                            keepLoop = false;
                            break;

                        default: Console.WriteLine(choice + " is not on the menu. Please try again!");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Ops.. Something wrong happend.");
                }
            } while (keepLoop);
        }

    } // End of class
} // End of namespace