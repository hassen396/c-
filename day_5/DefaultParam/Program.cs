using System;
class MyClass {
    static void Main(string[] args) {
    //method to find the square of a given number
    int findSquare(int number = 0) {
        return number * number;
    }

        Console.WriteLine("please ente a number to find its square: ");
        //prompting user for a number to find its square
        string input = Console.ReadLine();
        //converting the string input to an integer to perform the calculation
        int number = Convert.ToInt32(input);
        //using the findSquare method to find and print the square of the given number
        int answer = findSquare(number);
        Console.WriteLine($"the square of {number} is {answer}");
        Console.WriteLine("this is the default answer from the default parameter : ");
        Console.WriteLine(findSquare());


}
}