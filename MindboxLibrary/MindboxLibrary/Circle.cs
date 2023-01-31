namespace MindboxLibrary
{
    public class Circle : IFigure
    {

        private double _radius;
        public Circle(double radius)
        {
            if (radius > 0)
            {
                _radius = radius;
            }
            else
            {
                throw new ArgumentException("Circle radius cannot be less than 0.");
            }
        }
        public double GetFigureArea()
        {
            var figureArea = Math.Round(Math.PI, 2) * Math.Pow(_radius, 2);
            return Math.Round(figureArea, 2);
        }
    }
}
