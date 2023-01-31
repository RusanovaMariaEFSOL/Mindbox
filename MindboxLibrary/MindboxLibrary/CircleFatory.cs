namespace MindboxLibrary
{
    public class CircleFatory : IFigureFactory
    {
        private double _radius;
        public CircleFatory(double radius) 
        { 
            _radius = radius;
        }
        public IFigure MakeFigure()
        {
            return new Circle(_radius);
        }
    }
}
