using System;

namespace AVERAGELY
{
    public static class Reporter
    {
        public static void Main()
        {
            int numberOfSubject = 0;
            decimal average = 0, totalGrade = 0;
            Input();
            CalculateTheAverageValue(numberOfSubject, average, totalGrade);

        }
        public static void Input()
        {
            Console.WriteLine("");
            Console.WriteLine("You can calculate your average grade with this app");
            Console.WriteLine("Enter all grades per subject below");
            Console.WriteLine("Note: You should enter [1 ~ 5]");
            Console.Write("How many subject do you want to enter: ");  
        }
        

        public static void CalculateTheAverageValue(int numberOfSubject, decimal average, decimal totalGrade)
        {
            try
            {
                numberOfSubject = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            catch (FormatException formatException)
            {
                Console.WriteLine("The input is not in a correct format");
            }
            catch (OverflowException overflowException)
            {
                Console.WriteLine("Value is too large or too small, take a look data type");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            
            for (int iteration = 1; iteration <= numberOfSubject; iteration++)
            {
                Console.Write($"Subject {iteration}: ");
                decimal grade = decimal.Parse(Console.ReadLine());
                totalGrade += grade;
            }

            average = totalGrade / numberOfSubject;
            Console.WriteLine($"Average grade: {average:f2}");
            
            if (average >= 3 && average <= 5)
                Console.WriteLine("You are passed");
            else if (average < 3 && average > 0)
                Console.WriteLine("You are failed");
            else
                Console.WriteLine("You entered wrong grade, please check again.");
        }
    }
}
