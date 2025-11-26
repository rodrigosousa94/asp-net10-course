namespace aspnet10.Services
{
    public class MathService
    {
        public static decimal Sum(decimal firstNumber, decimal secondNumber) => firstNumber + secondNumber;

        public static decimal Subtraction(decimal firstNumber, decimal secondNumber) => firstNumber - secondNumber;

        public static decimal Multiplication(decimal firstNumber, decimal secondNumber) => firstNumber * secondNumber;

        public static decimal Division(decimal firstNumber, decimal secondNumber) => firstNumber / secondNumber;

        public static double SquareRoot(double number) => System.Math.Sqrt(number);

        public static decimal Average(decimal firstNumber, decimal secondNumber) => (firstNumber + secondNumber) / 2;
    }
}
