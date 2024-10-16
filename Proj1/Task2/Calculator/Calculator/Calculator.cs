using System;

namespace Calc
{
    public class Calculator
    {
        private double A;
        private double B;
        private char Operation;

        public Calculator(double a, double b, char operation)
        {
            A = a;
            B = b;
            Operation = operation;
        }

        public Calculator()
        {
        }

        public double Calculate()
        {
            switch (Operation)
            {
                case '+':
                    return A + B;
                case '-':
                    return A - B;
                case '*':
                    return A * B;
                case '/':
                    if (B == 0)
                        throw new Exception("ERR: Division by zero");
                    return A / B;
                default:
                    throw new Exception("Invalid operation");
            }
        }
    }
}
