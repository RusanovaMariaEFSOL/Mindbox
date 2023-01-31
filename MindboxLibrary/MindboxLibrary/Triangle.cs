namespace MindboxLibrary
{
    public class Triangle : IFigure
    {
        private double _a;
        private double _b;
        private double _c;

        private double _hypotenuse;
        private double _cathetus1;
        private double _cathetus2;

        private bool _isRightTriangle;

        public bool RightTriangle
        {
            get
            {
                return _isRightTriangle;
            }
        }

        public Triangle(double a, double b, double c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                _a = a;
                _b = b;
                _c = c;
                _isRightTriangle = IsRightTriangle(a, b, c);
            }
            else
            {
                throw new ArgumentException("The side of the triangle cannot be less than 0");
            }
        }

        public double GetFigureArea()
        {
            if (_isRightTriangle)
            {
                return GetFigureAreaForRightTriangle();
            }
            return GetFigureAreaForUsualTriangle();
        }

        private bool IsRightTriangle(double a, double b, double c)
        {
            var sides = new[] { a, b, c };
            var hypotenuse = sides.Max();
            double cathetus1 = 0;
            double cathetus2 = 0;

            if (hypotenuse == a)
            {
                cathetus1 = b;
                cathetus2 = c;
            }
            if (hypotenuse == b)
            {
                cathetus1 = a;
                cathetus2 = c;
            }
            if (hypotenuse == c)
            {
                cathetus1 = a;
                cathetus2 = b;
            }

            double squareOfHypotenuse = Math.Pow(hypotenuse, 2);
            double sumOfSquaresOfСathetus = Math.Pow(cathetus1, 2) + Math.Pow(cathetus2, 2);

            if (squareOfHypotenuse == sumOfSquaresOfСathetus) 
            {
                _hypotenuse = hypotenuse;
                _cathetus1 = cathetus1;
                _cathetus2 = cathetus2;

                return true;
            }

            return false; 
        }

        private double GetFigureAreaForRightTriangle()
        {
            var figureArea = 0.5 * (_cathetus1 * _cathetus2);
            return Math.Round(figureArea, 2);
        }

        private double GetFigureAreaForUsualTriangle()
        {
            var p = (_a + _b + _c) / 2;
            var figureArea = Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
            return Math.Round(figureArea, 2);
        }
    }
}
