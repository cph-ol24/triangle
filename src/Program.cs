using System;

namespace TriangleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var triangleDeterminer = new TriangleDeterminer();

            var scaleneTriangle = new Triangle(8, 4, 12);
            Console.WriteLine($"scaleneTriangle: {triangleDeterminer.Determine(scaleneTriangle)}");

            var equilateralTriangle = new Triangle(3, 3, 3);
            Console.WriteLine($"equilateralTriangle: {triangleDeterminer.Determine(equilateralTriangle)}");

            var invalidTriangle = new Triangle(5, 1, 1);
            Console.WriteLine($"invalidTriangle: {triangleDeterminer.Determine(invalidTriangle)}");

            var isoscelesTriangle = new Triangle(3, 4, 3);
            Console.WriteLine($"isoscelesTriangle: {triangleDeterminer.Determine(isoscelesTriangle)}");

            // Lets make a custom
            while (true)
            {
                var sideNames = new char[] { 'A', 'B', 'C' };
                var sides = new int[3];

                for (var i = 0; i < sides.Length; i++)
                {
                    while (true)
                    {
                        Console.Write($"Enter side {sideNames[i]}: ");

                        // Get the value
                        var input = Console.ReadLine();

                        int sideValue;

                        // Is the input a valid int?
                        if (int.TryParse(input, out sideValue))
                        {
                            sides[i] = sideValue;
                            break;
                        }
                        else
                        {
                            Console.Write("INVALID VALUE\n");
                        }
                    }
                }

                // Construct triangle
                var customTriangle = new Triangle(sides[0], sides[1], sides[2]);
                Console.WriteLine($"The triangle is {triangleDeterminer.Determine(customTriangle)}");
            }
        }
    }
}
