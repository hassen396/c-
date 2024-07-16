using system;
class Bird {
    public Bird(string color){
        Console.WriteLine("Bird constructor is called");
        string color = color;
        Console.WriteLine($"The bird is {color}");
    }
}
class Program {
    static void Main(string[] args) {
        Bird b = new Bird();
    }
}