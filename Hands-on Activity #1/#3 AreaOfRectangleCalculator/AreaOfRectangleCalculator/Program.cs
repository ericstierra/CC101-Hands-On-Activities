using System;

namespace AreaOfRectangleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**FIND THE AREA OF A RECTANGLE**");
            Console.WriteLine();

            int width, length, area; //Declaring Variables

            Console.Write("Enter Width: "); //Input
            width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Length: ");
            length = Convert.ToInt32(Console.ReadLine());

            area = length * width; //Process

            Console.WriteLine("----------");
            Console.WriteLine("The AREA of the rectangle is: " + area); //Output

        }
    }
}
