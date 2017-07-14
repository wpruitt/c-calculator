using System;
using Calc;
using Xunit;

namespace CalculatorTests
{
    public class CalculatorShould
    {
        private Calculator _calculator;

        public CalculatorShould()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void AddTwoIntegers()
        {
            // Given this input to the method
            int sum = _calculator.Add(54, 29);

            // We are asserting that the output should be this
            Assert.Equal(sum, 83);
        }
    }
}