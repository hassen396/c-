using System;
public class Calculate
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        start:
        Console.WriteLine("Enter the first number:");
        string input1 = Console.ReadLine();
        Console.WriteLine("Enter an operator (+, -, *, /):");
        char operatorChar = Console.ReadLine()[0];
        Console.WriteLine("Enter the second number:");
        string input2 = Console.ReadLine();
        int num1 = int.Parse(input1);
        int num2 = int.Parse(input2);

        switch (operatorChar)
        {
            case '+':
                int sum = num1 + num2;
                Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
                break;
            case '-':
                int difference = num1 - num2;
                Console.WriteLine($"The difference of {num1} and {num2} is: {difference}");
                break;
            case '*':
                int product = num1 * num2;
                Console.WriteLine($"The product of {num1} and {num2} is: {product}");
                break;
            case '/':
                double quotient = calc.divide(num1, num2);
                Console.WriteLine($"The quotient of {num1} and {num2} is: {quotient}");
                break;
            default:
                Console.WriteLine("Invalid operator!");
                break;
        }
        goto start;
    }
}
public class Calculator
{
    public int add(int a, int b)
    {
        return a + b;
    }
    public int subtract(int a, int b)
    {
        return a - b;
    }
    public int multiply(int a, int b)
    {
        return a * b;
    }
    public double divide(int a, int b) { return a / b; }
}