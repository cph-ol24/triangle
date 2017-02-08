namespace TriangleApplication
{
    public class Triangle
    {
        public Triangle(int a, int b, int c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public int A { get; private set; }

        public int B { get; private set; }

        public int C { get; private set; }
    }
}
