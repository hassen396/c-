string[] amharicName = [ "kebede","abebe", "aster","eyob"];
Console.WriteLine("before sorting");
foreach(string amName in amharicName){
Console.WriteLine(amName);
}
Array.Sort(amharicName);

Console.WriteLine("after sorting");

foreach(string amName in amharicName){
Console.WriteLine(amName);
}
Console.WriteLine("the last of them all is " + amharicName.Max());
Console.WriteLine("the first of them all is " + amharicName.Min());