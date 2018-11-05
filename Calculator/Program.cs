using System;

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
                    cal.FirstNumber = double.Parse(Console.ReadLine());
                    cal.SecondNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine("The sum is: " + cal.SumNumbers());
                    WriteMenu();
                    break;
                case "2":
                    Console.WriteLine("Enter two numbers to multiply!");
                    cal.FirstNumber = double.Parse(Console.ReadLine());
                    cal.SecondNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine("The product of the numbers is: " + cal.MultipleNumbers());
                    break;
                case "3":
                    Console.WriteLine("Enter two numbers!");
                    cal.FirstNumber = double.Parse(Console.ReadLine());
                    cal.SecondNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine("Sum in between is: " + cal.SumInBetween());
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
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
