using System;

namespace DepreciationProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            double purchasePrice, salvageValue, yearsOfService, depreciation;

            Console.Write("Please enter the purchase price: ");
            purchasePrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the item's year of service: ");
            yearsOfService = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the item's salvage value: ");
            salvageValue = Convert.ToDouble(Console.ReadLine());

            depreciation = (purchasePrice - salvageValue) / yearsOfService;

            Console.WriteLine("------");
            Console.WriteLine("The yearly depreciation for the item is, " + depreciation);
        }
    }
}
