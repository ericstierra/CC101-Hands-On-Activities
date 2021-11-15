/*
 * Name     : Eric S. Tierra
 * School   : QECI Atimonan
 * Course   : BSCS-1B
 * Subject  : CC101
 * Intructor: Mr. Al Laurio
*/

using System;

namespace ExerciseNov132021
{
    class Program
    {
        static void Main(string[] args)
        {
			const int dozen = 12;
			const double PricePerDozen = 3.25;
			const double PricePerEgg = 0.45;
			int eggs, dozens, loose;
			double finalTotal;

			Console.Write("Enter number of eggs: ");
			eggs = Convert.ToInt32(Console.ReadLine());

			dozens = eggs / dozen;
			loose = eggs % dozen;
			finalTotal = (dozens * PricePerDozen) + (loose * PricePerEgg);

			Console.WriteLine();
			Console.WriteLine("You have ordered {0} eggs." +
							"That's {1} dozen that cost {2} dollars per dozen and {3} loose eggs " +
							"that cost {4} cents each. " +
							"The total price is {5:c}.", 
							 eggs, dozens, PricePerDozen, loose, PricePerEgg, finalTotal);
		}
    }
}
