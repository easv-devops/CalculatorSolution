using ConsoleCalculator;
using NUnit.Framework;


namespace Tests
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void Add_Valid_Input_ReturnsCorrectResult()
        {
            //Arrange
            var dataSource = Helper.DataSource;
            var calculatorRepository = new CalculatorRepository(dataSource);
            var calculator = new Calculator(calculatorRepository);

            double n1 = 2;
            double n2 = 5;
            double expected = 7;

            //Act
            double actual = calculator.Add(n1, n2);

            //Assert
            Assert.That(actual, Is.EqualTo(expected)); 
        }

        [Test]
        public void Subtract_Valid_Input_ReturnsCorrectData()
        {
            //Arrange
            var dataSource = Helper.DataSource;
            var calculatorRepository = new CalculatorRepository(dataSource);
            var calculator = new Calculator(calculatorRepository);
            double n1 = 10;
            double n2 = 5;
            double expected = 5;
            //Act
            double actual = calculator.Subtract(n1, n2);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));

        }

        [Test]
        public void Multiply_Valid_Input_ReturnCorrectData()
        {
            //Arrange
            var dataSource = Helper.DataSource;
            var calculatorRepository = new CalculatorRepository(dataSource);
            var calculator = new Calculator(calculatorRepository);
            double n1 = 10;
            double n2 = 5;
            double expected = 50;

            //Act
            double actual = calculator.Multiply(n1,n2);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));        }

        [Test]
        public void Divide_Valid_Input_ReturnCorrectData()
        {
            //Arrange
            var dataSource = Helper.DataSource;
            var calculatorRepository = new CalculatorRepository(dataSource);
            var calculator = new Calculator(calculatorRepository);
            double n1 = 20;
            double n2 = 5;
            double expected = 4;

            //Act
            double actual = calculator.Divide(n1,n2);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));        }



    }
}