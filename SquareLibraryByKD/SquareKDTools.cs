namespace SquareLibraryByKD
{
    /// <summary>
    /// Инстументы
    /// </summary>
    public static class SquareKDTools
    {
        public static double GetTriangleSquare(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);
            return triangle.Square();
        }

        public static double GetTriangleSquare(double a, double b, double c, out bool itIsIsRight)
        {
            var triangle = new Triangle(a, b, c);
            itIsIsRight = triangle.IsRight;
            return triangle.Square();
        }

        public static double GetCircleSquare(double r)
        {
            var circle = new Circle(r);
            return circle.Square();
        }
    }
}
