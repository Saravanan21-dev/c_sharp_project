using Xunit;
using DevOpsDemoApi.Services;

namespace DevOpsDemoApi.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ReturnsSum()
        {
            var calc = new CalculatorService();
            Assert.Equal(5, calc.Add(2, 3));
        }

        [Fact]
        public void Divide_ByZero_ShouldThrow()
        {
            var calc = new CalculatorService();
            Assert.Throws<System.DivideByZeroException>(() => calc.Divide(10, 0));
        }
    }
}
