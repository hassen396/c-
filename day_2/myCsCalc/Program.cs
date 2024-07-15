using System;

    class Program{
        static void Main(string[] args) {
        Calc calc= new Calc();
        int ans = calc.add(8, 84);
        Console.WriteLine($"the answer is {ans}");
        Console.WriteLine("enter your age: ");
        string myname=Console.ReadLine();
        int age;
        if(!int.TryParse(myname, out age)){
            Console.WriteLine("invalid input! Please enter a valid age");
            myname=Console.ReadLine();

        }else{
            Console.WriteLine("you entered the number " + age);
        }

        Console.WriteLine("your age is: "+ age);
    }
}

class Calc{
    public int add(int a, int b) {
        return (a + b);
}
}