/*
 * Name     : Eric S. Tierra
 * School   : QECI Atimonan
 * Course   : BSCS-1B
 * Subject  : CC101
 * Intructor: Mr. Al Laurio
*/

using System;

namespace SammysSeashoreSuppliesRental
{
    class Program
    {
        static void Main(string[] args)
        {
            int minRented, numHours, numMin;
            double totalPrice;

            Console.Write("Enter number of minutes rented       : ");
            minRented = Convert.ToInt32(Console.ReadLine());

            numHours = (minRented / 60);
            numMin = (minRented % 60);
            totalPrice = (numHours * 40) + (numMin * 1);

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Total number of hour(s)              : {0}", numHours);
            Console.WriteLine("Total number of minute(s)            : {0}", numMin);
            Console.WriteLine("Total rent for the sports equipment  : {0:c}", totalPrice);
        }
    }
}
