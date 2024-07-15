
ConsoleColor cc = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.Black;
ConsoleColor bcc = Console.BackgroundColor;
Console.BackgroundColor = ConsoleColor.White;
string myName = "smilex";
foreach (char c in myName){
    foreach (char c2 in "aeiou"){
        if (c == c2) Console.Write(c);
    }  
 }
Console.WriteLine();

string[] mySistersNames = ["rich", "nur", "etsub", "dinke", "sis"];
foreach (string name in mySistersNames)
    Console.WriteLine(name);

int[] ints = [1,2,3,4,5,6,7,];
string[] strings = new string[4] { "s1", "s2", "s3", "s4"};

foreach (string i in strings)
    Console.WriteLine(i);
for(int i = 0; i < ints.Length; i++)
    Console.WriteLine(ints[i]);
   