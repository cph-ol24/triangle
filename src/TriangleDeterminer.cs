using System.Linq;

namespace TrinagleApplication
{
    public class TriangleDeterminer
    {
        public string Determine(Triangle triangle)
        {
            // Detect if the triangle is valid
            if (!DetectInvalidTriangle(triangle))
            {
                return "invalid";
            }

            // Create a array of the sides
            var triangleSides = new[] { triangle.A, triangle.B, triangle.C };

            // Find the unique sides of the triangle
            var duplicates = triangleSides.Distinct().Count();

            // All sides have different values
            if (duplicates == 3)
            {
                return "scalene";
            }

            // If 2 sides have have different values
            if (duplicates == 2)
            {
                return "isosceles";
            }

            // Otherwise it will have equal length
            return "equilateral";
        }

        private bool DetectInvalidTriangle(Triangle triangle)
        {
            // Determine if the triangle is valid using Triangle Inequality Theorem
            // http://www.wikihow.com/Determine-if-Three-Side-Lengths-Are-a-Triangle
            
            return (
                ((triangle.A + triangle.B) >= triangle.C) &&
                ((triangle.A + triangle.C) >= triangle.B) &&
                ((triangle.C + triangle.B) >= triangle.A)
            );
        }
    }
}
