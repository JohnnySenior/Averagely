Console.WriteLine("You can calculate your average grade with this app");
Console.WriteLine("Enter all grades per subject below");
Console.WriteLine("Note: You should enter [1 ~ 5]");
Console.WriteLine();

Console.Write("Computer Science: ");
double comScience = double.Parse(Console.ReadLine()); 

Console.Write("English: ");
double english = double.Parse(Console.ReadLine()); 

Console.Write("Mathematics: ");
double math = double.Parse(Console.ReadLine()); 

Console.Write(".Net Programming: ");
double net = double.Parse(Console.ReadLine()); 

Console.Write("Data Structure: ");
double structure = double.Parse(Console.ReadLine()); 

double average = (comScience + english + math + net + structure)/5;
Console.WriteLine($"Average: {average}");
Console.WriteLine();

if(average >= 3 && average <= 5)
    Console.WriteLine("You are passed");
else if(average < 3 && average > 0)
    Console.WriteLine("You are failed");
else
    Console.WriteLine("You entered wrong grade, please check again");

