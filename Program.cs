Console.WriteLine("You can calculate you average grade with this app");
Console.WriteLine("Enter all grades per subject below");
Console.WriteLine("Note: You should enter [0 ~ 30]");
Console.WriteLine();

Console.Write("Computer Science: ");
var comScience = double.Parse(Console.ReadLine()); 

Console.Write("English: ");
var english = double.Parse(Console.ReadLine()); 

Console.Write("Mathematics: ");
var math = double.Parse(Console.ReadLine()); 

Console.Write(".Net Programming: ");
var net = double.Parse(Console.ReadLine()); 

Console.Write("Data Structure: ");
var structure = double.Parse(Console.ReadLine()); 

var average = (comScience + english + math + net + structure)/5;
Console.WriteLine($"Average: {average}");
Console.WriteLine();
