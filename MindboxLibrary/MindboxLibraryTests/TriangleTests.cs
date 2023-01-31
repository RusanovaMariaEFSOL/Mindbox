using MindboxLibrary;

namespace MindboxLibraryTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TestTriangleWithNegativeSide_ShouldThrowException()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-5, -7, -9));
        }

        [TestMethod]
        public void TestGetFigureAreaForUsualTriangle()
        {
            double expected = 17.41;
            double result = new Triangle(5, 7, 9).GetFigureArea();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestGetFigureAreaForRightTriangle()
        {
            double expected = 24;
            double result = new Triangle(8, 6, 10).GetFigureArea();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestIsRightTriangle_ShouldReturnTrue()
        {
            bool result = new Triangle(8, 6, 10).RightTriangle;
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestIsRightTriangle_ShouldReturnFalse()
        {
            bool result = new Triangle(5, 7, 9).RightTriangle;
            Assert.IsFalse(result);
        }
    }
}
