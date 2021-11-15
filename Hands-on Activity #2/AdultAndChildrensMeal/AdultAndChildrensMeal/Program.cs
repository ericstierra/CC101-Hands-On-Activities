/*
 * Name     : Eric S. Tierra
 * School   : QECI Atimonan
 * Course   : BSCS-1B
 * Subject  : CC101
 * Intructor: Mr. Al Laurio
*/

using System;

namespace AdultAndChildrensMeal
{
    class Program
    {
        static void Main(string[] args)
        {
            double adultMeal, childMeal;
            double amTotal, cmTotal, overallTotal;
            double profitAdult, profitChild, profitTotal;

            Console.Write("Enter number of Adult's Meal ordered     : ");
            adultMeal = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number of Children's Meal ordered  : ");
            childMeal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("------------------------------------------------");

            amTotal = (adultMeal * 7);
            cmTotal = (childMeal * 4);
            overallTotal = (amTotal + cmTotal);

            profitAdult = (2.65 * adultMeal);
            profitChild = (0.9 * childMeal);
            profitTotal = (profitAdult + profitChild);

            Console.WriteLine("(A)");
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Total money collected for adult meal     : {0:c}",amTotal);
            Console.WriteLine("Total money collected for children's meal: {0:c}", cmTotal);
            Console.WriteLine("Overall Total                            : {0:c}", overallTotal);

            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("(B)");
            Console.WriteLine("Total profit for adult meal              : {0:c}", profitAdult);
            Console.WriteLine("Total profit for children's meal         : {0:c}", profitChild);
            Console.WriteLine("Total profit                             : {0:c}", profitTotal);

        }
    }
}
