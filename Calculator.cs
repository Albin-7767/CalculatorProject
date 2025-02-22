namespace CalculatorLibrary
{
    public class Calculator
    {
        // Addition
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Subtraction
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        // Multiplication
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        // Division
        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new System.DivideByZeroException("Cannot divide by zero.");

            return a / b;
        }
    }
}
