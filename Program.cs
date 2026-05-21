using System;

namespace AVERAGELY
{
    public static class Reporter
    {
        public static void Main()
        {
            PrintInstructions();

            int numberOfSubject = ReadNumberOfSubjects();
            if (numberOfSubject <= 0)
                return;

            decimal average = CalculateAverage(numberOfSubject);
            PrintResult(average);
        }

        private static void PrintInstructions()
        {
            Console.WriteLine("");
            Console.WriteLine("You can calculate your average grade with this app");
            Console.WriteLine("Enter all grades per subject below");
            Console.WriteLine("Note: You should enter [1 ~ 5]");
        }

        private static int ReadNumberOfSubjects()
        {
            Console.Write("How many subjects do you want to enter: ");
            try
            {
                int count = int.Parse(Console.ReadLine());
                Console.Clear();
                return count;
            }
            catch (FormatException)
            {
                Console.WriteLine("The input is not in a correct format");
                return 0;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Value is too large or too small, take a look data type");
                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        private static decimal CalculateAverage(int numberOfSubject)
        {
            decimal totalGrade = 0;

            for (int iteration = 1; iteration <= numberOfSubject; iteration++)
            {
                totalGrade += ReadGrade(iteration);
            }

            return totalGrade / numberOfSubject;
        }

        private static decimal ReadGrade(int subjectNumber)
        {
            while (true)
            {
                Console.Write($"Subject {subjectNumber}: ");
                try
                {
                    decimal grade = decimal.Parse(Console.ReadLine());

                    if (grade < 1 || grade > 5)
                    {
                        Console.WriteLine("Grade must be between 1 and 5. Try again.");
                        continue;
                    }

                    return grade;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The input is not in a correct format. Try again.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private static void PrintResult(decimal average)
        {
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
