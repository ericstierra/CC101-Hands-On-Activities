//Tierra, Eric S.
//BSCS-1B

using System;

namespace FeetToCentimeterConverter
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declaring variables
            const double ft_to_cm = 30.48;
            double feetValue;
            double cmValue;

            Console.WriteLine("**CONVERT FEET TO CM**");
            Console.WriteLine();

            //Input
            Console.Write("Please enter the value of feet: ");
            feetValue = Convert.ToDouble(Console.ReadLine());

            //Process
            cmValue = feetValue * ft_to_cm;

            //Output
            Console.WriteLine("-------");
            Console.Write("Answer: ");
            Console.WriteLine(cmValue + " cm");

        }
    }
}
