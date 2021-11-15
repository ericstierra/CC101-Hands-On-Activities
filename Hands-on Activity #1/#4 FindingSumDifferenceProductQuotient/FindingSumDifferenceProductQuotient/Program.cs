using System;

namespace FindingSumDifferenceProductQuotient
{
    class Program
    {
        static void Main(string[] args)
        {

            float num1, num2; //Declaring Variables
            float sum, difference, product, quotient;

            Console.Write("Enter First Number : "); //Input
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            sum = num1 + num2; //Process
            difference = num1 - num2;
            product = num1 * num2;
            quotient = num1 / num2;

            Console.WriteLine("-------"); //Output
            Console.WriteLine("Sum        = " + sum);
            Console.WriteLine("Difference = " + difference);
            Console.WriteLine("Product    = " + product);
            Console.WriteLine("Quotient   = " + quotient);

        }
    }
}
