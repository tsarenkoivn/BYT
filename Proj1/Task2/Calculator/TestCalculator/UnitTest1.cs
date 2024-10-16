using Calc;

namespace TestCalculator
{
    public class Tests
    {
        [Test]
        public void Addition_EqualTest()
        {
            var calculator = new Calculator(3, 4, '+');
            Assert.That(calculator.Calculate(), Is.EqualTo(7.0000).Within(0.0001));
        }

        [Test]
        public void Subtraction_EqualTest()
        {
            var calculator = new Calculator(10, 4, '-');
            Assert.That(calculator.Calculate(), Is.EqualTo(6.0000).Within(0.0001));
        }

        [Test]
        public void Multiplication_EqualTest()
        {
            var calculator = new Calculator(3, 4, '*');
            Assert.That(calculator.Calculate(), Is.EqualTo(12.0000).Within(0.0001));
        }

        [Test]
        public void Division_EqualTest()
        {
            var calculator = new Calculator(8, 2, '/');
            Assert.That(calculator.Calculate(), Is.EqualTo(4.0000).Within(0.0001));
        }

        [Test]
        public void DivisionByZero_Exception()
        {
            var calculator = new Calculator(5, 0, '/');
            Assert.Throws<Exception>(() => calculator.Calculate());
        }

        [Test]
        public void InvalidOperation_Exception()
        {
            var calculator = new Calculator(5, 3, '%');
            Assert.Throws<Exception>(() => calculator.Calculate());
        }

        [Test]
        public void DivisionByZero_ShouldReturnErrorMessage()
        {
            var calculator = new Calculator(10, 0, '/');
            var ex = Assert.Throws<Exception>(() => calculator.Calculate());
            Assert.That(ex.Message, Is.EqualTo("ERR: Division by zero"));
        }

        [Test]
        public void SubtractionNegativeNumbers_EqualTest()
        {
            var calculator = new Calculator(-10, -4, '-');
            Assert.That(calculator.Calculate(), Is.EqualTo(-6.0000).Within(0.0001));
        }

        [Test]
        public void DivisionNegativeNumbers_EqualTest()
        {
            var calculator = new Calculator(-1024.65, -1000, '/');
            Assert.That(calculator.Calculate(), Is.EqualTo(1.0246).Within(0.0001));
        }

        [Test]
        public void AdditionNegativeNumbers_EqualTest()
        {
            var calculator = new Calculator(-10, -4, '+');
            Assert.That(calculator.Calculate(), Is.EqualTo(-14.0000).Within(0.0001));
        }

        [Test]
        public void MultiplicationWithDecimals_EqualTest()
        {
            var calculator = new Calculator(-234.8, 4.6789, '*');
            Assert.That(calculator.Calculate(), Is.EqualTo(-1098.6057).Within(0.0001));
        }
    }
}