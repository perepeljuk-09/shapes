using shapes.Models;

namespace shapesTests.Models
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CircleNotNull()
        {
            // arrange
            int radius = 10;

            // act
            Circle actual = new Circle(radius);

            // assert
            Assert.IsNotNull(actual);

        }
        [TestMethod]
        public void CircleExceptionByRadiusless0()
        {
            // arrange
            int radius = -10;

            // act

            // assert
            Assert.ThrowsException<Exception>(() => new Circle(radius));

        }
        [TestMethod]
        public void CircleExceptionByRadiusEquals0()
        {
            // arrange
            int radius = 0;

            // act

            // assert
            Assert.ThrowsException<Exception>(() => new Circle(radius));

        }
        [TestMethod]
        public void SquareEqual314ByRadius10()
        {
            // arrange
            int radius = 10;
            float expected = 314.15927f;

            // act
            Circle circle = new Circle(radius);

            // assert
            Assert.AreEqual(expected, circle.GetSquare());
        }
        [TestMethod]
        public void SquareEqual530ByRadius13()
        {
            // arrange
            int radius = 13;
            float expected = 530.92914f;

            // act
            Circle circle = new Circle(radius);

            // assert
            Assert.AreEqual(expected, circle.GetSquare());
        }
    }
}