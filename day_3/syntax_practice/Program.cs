using System;
 public class Practice {
    public static void Main() {
        Console.WriteLine("please enter a number: ");
        string input = Console.ReadLine();
        // Convert the string to an integer( what we understand here is that the user inputs are by defaut strings)
        int number1 = Convert.ToInt32(input);
       // float number2 = Convert.ToFloat(input);
        double number3 = Convert.ToDouble(input);
       // Console.WriteLine("this is a float number" + number2);
        Console.WriteLine("this is a double number " + number3);
        Console.WriteLine($"2 x {number1} is  {number1 * 2}");
    }
 }