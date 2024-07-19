using System.IO;
class Program{
    static void Main(string[] args) {
        // Console.Write("enter a massge to save into file: ");
        // string wrtireFile = Console.ReadLine();
        // File.WriteAllText("firstfile.txt", wrtireFile);
        string readFile = File.ReadAllText("firstfile.txt");
        Console.WriteLine(readFile);// writing a massage to my readers from a file

    }
}