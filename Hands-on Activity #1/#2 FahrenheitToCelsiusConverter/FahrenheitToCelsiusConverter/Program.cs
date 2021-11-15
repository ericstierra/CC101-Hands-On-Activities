using System;

namespace FahrenheitToCelsiusConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**CONVERT FAHRENHEIT TO CELSIUS**");
            Console.WriteLine();

            //Declaring variables
            float fahrenheit;
            float celsius;

            //Input
            Console.Write("Enter the value of Fahrenheit: ");
            fahrenheit = Convert.ToInt32(Console.ReadLine());

            //Process
            celsius = (fahrenheit - 32) * 5 / 9; //formula

            //Output
            Console.WriteLine("-------");
            Console.Write("Answer: ");
            Console.WriteLine(celsius + " °C");

        }
    }
}
