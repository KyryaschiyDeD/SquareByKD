namespace SquareLibraryByKD.Tests
{
    public class StartKDTest
    {

        [Theory]
        [InlineData(6, 5, 5, 12)]
        [InlineData(6, 10, 8, 24)]
        [InlineData(10, 12, 10, 48)]
        [InlineData(16, 10, 10, 48)]
        public void IsTriangleSquareTrue(double a, double b, double c, double expected)
        {
            var triangle = new Triangle(a, b, c);
            double result = triangle.Square();
            Assert.Equal(expected, result);
        }
    
        [Fact]
        public void IsTriangleSquareIsRight()
        {
            bool tmp;
            Assert.Equal(12.0, SquareKDTools.GetTriangleSquare(6, 5, 5, out tmp));
            Assert.False(tmp);

            Assert.Equal(24.0, SquareKDTools.GetTriangleSquare(10, 6, 8, out tmp));
            Assert.True(tmp);
        }

        [Fact]
        public void IsTriangleIsRight()
        {
            Assert.True(new Triangle(10, 6, 8).IsRight);
            Assert.False(new Triangle(15, 15, 15).IsRight);
        }

        [Fact]
        public void IsTriangleBadValues()
        {
            Assert.Throws<ArgumentException>(() => SquareKDTools.GetTriangleSquare(100000, 10, 10));
            Assert.Throws<ArgumentException>(() => SquareKDTools.GetTriangleSquare(10, 100000, 10));
            Assert.Throws<ArgumentException>(() => SquareKDTools.GetTriangleSquare(10, 10, 100000));

            Assert.Throws<ArgumentException>(() => SquareKDTools.GetTriangleSquare(0, 10, 10));
            Assert.Throws<ArgumentException>(() => SquareKDTools.GetTriangleSquare(10, 0, 10));
            Assert.Throws<ArgumentException>(() => SquareKDTools.GetTriangleSquare(10, 10, 0));

            Assert.Throws<ArgumentException>(() => SquareKDTools.GetTriangleSquare(-1, 10, 10));
            Assert.Throws<ArgumentException>(() => SquareKDTools.GetTriangleSquare(4, -2, 5));
            Assert.Throws<ArgumentException>(() => SquareKDTools.GetTriangleSquare(10, 10, -3));
        }

        [Fact]
        public void IsCircleSquareTrue()
        {
            Assert.Equal(Math.PI * 9, SquareKDTools.GetCircleSquare(3));
            Assert.Equal(Math.PI * 16, SquareKDTools.GetCircleSquare(4));
            Assert.Equal(Math.PI * 36, SquareKDTools.GetCircleSquare(6));
            Assert.Equal(Math.PI * 321489, SquareKDTools.GetCircleSquare(567));
        }

        [Fact]
        public void IsCircleBadValues()
        {
            Assert.Throws<ArgumentException>(() => SquareKDTools.GetCircleSquare(0));
            Assert.Throws<ArgumentException>(() => SquareKDTools.GetCircleSquare(-1));
            Assert.Throws<ArgumentException>(() => new Circle(-5));
        }
    }
}
