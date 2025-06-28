using System;
using System.Runtime.InteropServices;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(10, 10, 10, 30)]
        [InlineData(100, 100, 100, 300)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            var calculator = new Calculator();
            // create a Calculator object
            
            //Act
            var actual = calculator.Add(num1, num2, num3);
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual

            //Assert
            Assert.Equal(expected, actual);
                //Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5 , 5)]//Add test data <-------
        [InlineData(100, 50, 50)]
        [InlineData(500, 500, 0)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var calculator = new Calculator();
            //Act
            var actual = calculator.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 2, 4)]//Add test data <-------
        [InlineData(4, 4, 16)]
        [InlineData(16, 16, 256)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var  calculator = new Calculator(); 
            //Act
            var actual = calculator.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(100, 2, 50)]//Add test data <-------
        [InlineData(50, 2, 25)]
        [InlineData(25, 5, 5)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calculator = new Calculator();
            //Act
            var actual = calculator.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
