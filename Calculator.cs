namespace Calculator
{
    public class CalculatorApp
    {
        public double Add(double num1, double num2) => num1 + num2;
        public double Subtract(double num1, double num2) => num1 - num2;
        public double Multiply(double num1, double num2) => num1 * num2;
        public double Divide(double num1, double num2)
        {
            return num2 == 0 ? double.NaN : num1 / num2;
        }
    }
}
