using MindboxLibrary;

namespace MindboxLibraryTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void TestCircleWithNegativeRadius_ShouldThrowException()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(-5));
        }

        [TestMethod]
        public void TestGetFigureArea()
        {
            double expected = 28.26;
            double result = new Circle(3).GetFigureArea();
            Assert.AreEqual(expected, result);
        }
    }
}
