using System;
using Calc;

public class Program
{
    public static void Main(string[] args)
    {
        Calculator calculator = new Calculator(5, 6, '*');
        calculator.Calculate();
    }
}