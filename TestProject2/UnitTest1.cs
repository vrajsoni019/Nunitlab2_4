using NUnit.Framework;
namespace NUnitDemonstration.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        //test1
        [Test]
        public void ValidTriangle_ValidInput_ReturnsValidMessage()
        {
            // Arrange
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }


        //test2
        [Test]
        public void SixtySixtySeventy_InvalidInput_ReturnsInvalidMessage()
        {
            // Arrange
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 70;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }





        //test3
        // Add more test methods as needed to cover different scenarios
        [Test]
        public void ZeroAngle_InvalidInput_ReturnsInvalidMessage()
        {
            // Arrange
            int firstAngle = 0;  //INVALID
            int secondAngle = 90;
            int thirdAngle = 90;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }

        //test4
        [Test]
        public void ZeroZeroOneEighty_InvalidInput_ReturnsvalidMessage()
        {
            // Arrange
            int firstAngle = 0; //INVALID
            int secondAngle = 180;
            int thirdAngle = 0;  //INVALID
            // Act 
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }

        //test5
        [Test]
        public void TwoNinty_InvalidInput_ReturnsValidMessage()
        {
            // Arrange
            int firstAngle = 90;
            int secondAngle = -90; //invalid
            int thirdAngle = 90;  //
            // Act 
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);

        }
        //test6
        [Test]
        public void NegattiveAngle_InvalidInput_ReturnsInvalidMessage()
        {
            // Arrange
            int firstAngle = -90;   //invalid
            int secondAngle = -90; //invalid
            int thirdAngle = -90;  //invalid
            // Act 
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }
        //test7
        [Test]
        public void TWoFortyFiuveOneNinty_InvalidInput_ReturnsInvalidMessage()
        {
            // Arrange
            int firstAngle = 45;
            int secondAngle = 45; //invalid
            int thirdAngle = 90;  //
            // Act 
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);

        }
        //test8
        [Test]
        public void ZeroAllAngle_InvalidInput_ReturnsInvalidMessage()
        {
            // Arrange
            int firstAngle = 0;
            int secondAngle = 0; 
            int thirdAngle = 0; 
            // Act 
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);

        }
        //test9
        [Test]
        public void OneEightyAngle_InvalidInput_ReturnsInvalidMessage()
        {
            // Arrange
            int firstAngle = -180;
            int secondAngle = 180;
            int thirdAngle = -180;
            // Act 
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);

        }
        [Test]
        public void OneEightyOneNinty_InvalidInput_ReturnsInvalidMessage()
        {
            // Arrange
            int firstAngle = 180;
            int secondAngle = 45;
            int thirdAngle = -45;
            // Act 
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);

        }
    }    
}