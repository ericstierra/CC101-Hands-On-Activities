using System;

namespace GradingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int english, filipino, math, science; //variables for the 4 subjects
            int average; //variable for average

            //Input
            Console.WriteLine("Please enter the following grades of Eric Tierra");
            Console.WriteLine("-------");
            Console.Write("English : "); english = Convert.ToInt32(Console.ReadLine());
            Console.Write("Filipino: "); filipino = Convert.ToInt32(Console.ReadLine());
            Console.Write("Math    : "); math = Convert.ToInt32(Console.ReadLine());
            Console.Write("Science : "); science = Convert.ToInt32(Console.ReadLine());

            //Process
            average = (english + filipino + math + science) / 4; //formula

            //Output
            Console.WriteLine("-------");
            Console.WriteLine("Average : " + average);
            Console.WriteLine("-------");
         
        }
    }
}
