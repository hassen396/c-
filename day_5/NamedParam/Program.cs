using System;

class Program{
    static void Main(string[] args){
        int methodone(int arg1, int arg2) {
            return arg1 - arg2;

        }
        int difference = methodone(arg2: 2, arg1: 4);
        Console.WriteLine($"The difference between the two numbers is {difference}");
    }
}