
using System;
class Bird
{
    public string name;
    public string color;
    public Bird(string color, string name)
    {
        Console.WriteLine("Bird constructor is called");
        this.name = name;
        this.color = color;
        Console.WriteLine($"{name} is {color}");
    }
    public bool CanFly;
}
class Program
{
    
    static void Main(string[] args)
    {
        Bird parrot = new Bird("green", "parrot");
        parrot.CanFly = true;
        if (parrot.CanFly)
        {
            Console.WriteLine($"{parrot.name} can fly");
        }
        else
        {
            Console.WriteLine($"{parrot.name} cannot fly");
        }
        Console.WriteLine($"tha name of the bird is {parrot.name} and the color  is {parrot.color}");


    }
}