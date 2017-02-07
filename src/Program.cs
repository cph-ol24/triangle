using System;

namespace TrinagleApplication
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
        }
    }
}
