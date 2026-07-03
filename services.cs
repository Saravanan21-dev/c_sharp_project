namespace DevOpsDemoApi.Services
{
    public class CalculatorService
    {
        public int Add(int a, int b) => a + b;

        public int Divide(int a, int b)
        {
            // ❌ Bug: division by zero not handled
            return a / b;
        }
    }
}
