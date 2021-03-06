﻿using System;

namespace Calculator
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            Cal cal = new Cal();

            Console.WriteLine(cal);

            WriteMenu();
            while(true) {
                MenyChoice(cal);
            }



        }

        public static void MenyChoice(Cal cal)
        {
            var userInput = Console.ReadLine();

            switch (userInput) 
            {
                case "1":
                    Console.WriteLine("Enter two numbers to add!");
                    cal.SetFirstAndSecond(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                    Console.WriteLine("The sum is: " + cal.SumNumbers());
                    WriteMenu();
                    break;
                case "2":
                    Console.WriteLine("Enter two numbers to multiply!");
                    cal.SetFirstAndSecond(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                    Console.WriteLine("The product of the numbers is: " + cal.MultipleNumbers());
                    WriteMenu();
                    break;
                case "3":
                    Console.WriteLine("Enter two numbers!");
                    cal.SetFirstAndSecond(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                    Console.WriteLine("Sum in between is: " + cal.SumInBetween());
                    WriteMenu();
                    break;
                case "4":
                    Console.WriteLine("Enter a number to save to memory!");
                    cal.NumberInMemory = double.Parse(Console.ReadLine());
                    Console.WriteLine("Number added to memory!");
                    WriteMenu();
                    break;
                case "5":
                    cal = new Cal();
                    Console.WriteLine("Memory cleared!");
                    WriteMenu();
                    break;
                case "6":
                    Console.WriteLine("Number in memory is: " + cal.NumberInMemory);
                    WriteMenu();
                    break;
                case "7":
                    System.Environment.Exit(1);
                    break;
                default:

                    break;
            }
        }


        public static void WriteMenu()
        {
            var message = 
                "1. Add two numbers \n" +
                "2. Multiply two numbers \n" +
                "3. Sum the numbers between two numbers. \n" +
                "4. Add number to memory \n" +
                "5. Clear memory \n" +
                "6. Print calculator contents. \n" +
                "7. Quit";

            Console.WriteLine(message);
        }
    }
}
