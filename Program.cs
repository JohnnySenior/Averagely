Console.WriteLine("");
Console.WriteLine("You can calculate your average grade with this app");
Console.WriteLine("Enter all grades per subject below");
Console.WriteLine("Note: You should enter [1 ~ 5]");
Console.Write("How many subject do you want to enter: ");

int numberOfSubject = int.Parse(Console.ReadLine());
Console.Clear();

double totalGrade = 0;

for (int iteration = 1; iteration <= numberOfSubject; iteration++)
{
    Console.Write($"Subject {iteration}: ");
    double grade = double.Parse(Console.ReadLine());
    totalGrade += grade;
}

double average = totalGrade / numberOfSubject;
Console.WriteLine($"Average grade: {average:f2}");

if (average >= 3 && average <= 5)
    Console.WriteLine("You are passed");
else if (average < 3 && average > 0)
    Console.WriteLine("You are failed");
else
    Console.WriteLine("You entered wrong grade, please check again");

