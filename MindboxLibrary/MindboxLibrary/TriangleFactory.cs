namespace MindboxLibrary
{
    public class TriangleFactory : IFigureFactory
    {
        private double _a;
        private double _b;
        private double _c;

        public TriangleFactory(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public IFigure MakeFigure()
        {
            return new Triangle(_a, _b, _c);
        }
    }
}
