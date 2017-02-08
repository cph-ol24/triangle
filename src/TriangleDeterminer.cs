namespace TriangleApplication
{
    using System.Linq;

    public class TriangleDeterminer
    {
        public TriangleType Determine(Triangle triangle)
        {
            // Detect if the triangle is valid
            if (!this.DetectInvalidTriangle(triangle))
            {
                return TriangleType.Invalid;
            }

            // Create a array of the sides
            var triangleSides = new[] { triangle.A, triangle.B, triangle.C };

            // Find the unique sides of the triangle
            var uniqueSides = triangleSides.Distinct().Count();

            // All sides have different values
            if (uniqueSides == 3)
            {
                return TriangleType.Scalene;
            }

            // If 2 sides have have different values
            if (uniqueSides == 2)
            {
                return TriangleType.Isosceles;
            }

            // Otherwise it will have equal length
            return TriangleType.Equilateral;
        }

        private bool DetectInvalidTriangle(Triangle triangle)
        {
            // Determine if the triangle is valid using Triangle Inequality Theorem
            // http://www.wikihow.com/Determine-if-Three-Side-Lengths-Are-a-Triangle
            return ((triangle.A + triangle.B) >= triangle.C) &&
                ((triangle.A + triangle.C) >= triangle.B) &&
                ((triangle.C + triangle.B) >= triangle.A);
        }
    }
}
