using System.IO;
using System;
using System.Text.Json;

public class Program
{
    public static void Main(string[] args)
    {
        WriteFile writer = new WriteFile();
        ReadFile reader = new ReadFile();
        WriteJson writeJson = new WriteJson();
        ReadSpecificLine readSpecificLine = new ReadSpecificLine();
        writer.WriteFiles("file_1.txt", "contetnt to be appended");
        Console.WriteLine("this is an exercise on writing files and reading from the file");
        reader.Read("uiWritten.txt");
        readSpecificLine.ReadLine("uiWritten.txt", 1);
        Console.WriteLine("writing json file");
        var data = new {
            Name = "smilex",
            Age = 35,
            Occupation = "Software Developer"
        };
        string jsonContent = JsonSerializer.Serialize(data);
        writeJson.WriteJsonFile("first.json", jsonContent);
    }
}


public class WriteFile
{
    public void WriteFiles(string path, string content)
    {
        File.AppendAllText(path, content);
    }
}
public class ReadFile
{

    public void Read(string filename)
    {
        string text = File.ReadAllText(filename);
        Console.WriteLine("The contents of the file are: " + text);
    }
}


public class ReadSpecificLine
{
    public void ReadLine(string filename, int lineNumber)
    {
        string[] lines = File.ReadAllLines(filename);
        if (lineNumber < lines.Length)
            Console.WriteLine($"The line {lineNumber} is: {lines[lineNumber]}");
    }
}

public class WriteJson {
    public void WriteJsonFile(string jsonFilePath, string jsonContent){
        File.WriteAllText(jsonFilePath, jsonContent);
    }
}