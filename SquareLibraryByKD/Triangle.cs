namespace SquareLibraryByKD
{
    public class Triangle : IFigura
    {
        private List<double> numberList;
        public bool IsRight // Прямоугольный?
        {
            get
            {
                if (WhatTriangle() == 3)
                    return true;
                return false;
            }
        }
        public bool IsEquilateral // Равносторонний?
        {
            get
            {
                if (WhatTriangle() == 2)
                    return true;
                return false;
            }
        }
        public bool IsIsosceles // Равнобедренный?
        {
            get
            {
                if (WhatTriangle() == 1)
                    return true;
                return false;
            }
        }
        public bool IsRegular // Обычный?
        {
            get
            {
                if (WhatTriangle() == 0)
                    return true;
                return false;
            }
        }

        /// <param name="a">Сторона треугольника</param>
        /// <param name="b">Сторона треугольника</param>
        /// <param name="c">Сторона треугольника</param>
        public Triangle(double a, double b, double c)
        {
            numberList = new List<double>() { a, b, c };
            if (numberList.Min() <= 0)
            {
                throw new ArgumentException("Одно или несколько значений меньше нуля!");
            }
            if (a >= b + c || b >= a + c || c >= a + b)
            {
                throw new ArgumentException("Это не будет треугольником!");
            }
            
        }
        public double Square()
        {
            double p = numberList.Sum() / 2;

            return Math.Sqrt(p * (p - numberList[0]) * (p - numberList[1]) * (p - numberList[2]));
        }

        private sbyte WhatTriangle()
        {
            double a = numberList[0];
            double b = numberList[1];
            double c = numberList[2];
            if ((a == b) || (a == c) || (b == c)) // Равнобедренный
            {
                return 1;
            }
            else
            if (a == b && a == c && b == c) // Равносторонний
            {
                return 2;
            }
            else
            if (c * c == a * a + b * b || a * a == b * b + c * c || c * c == b * b + a * a) // Прямоугольный
            {
                return 3;
            }
            else
                return 0;
        }
    }
}
