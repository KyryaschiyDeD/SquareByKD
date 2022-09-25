namespace SquareLibraryByKD
{
    public class Circle : IFigura
    {
        private double radius;

        /// <param name="r">Радиус круга</param>
        public Circle(double r)
        {
            if (r <= 0)
            {
                throw new ArgumentException("Значение меньше или равно нулю!");
            }
            radius = r;
        }
        public double Square()
        {
            return Math.PI * radius * radius;
        }
    }
}
