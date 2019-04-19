using System;

namespace Grades
{
    class Program
    {
        public static void Main(string[] args)
        {
            Gradebook book = new Gradebook();
            book.AddGrade(95);
            book.AddGrade(89.7f);
            book.AddGrade(75);

            GradeStatistics stats = book.computeStatistics();
            Console.WriteLine("GRADE REPORT");
            Console.WriteLine("Your AVERAGE grade is " + stats.AverageGrade);
            Console.WriteLine("Your HIGHEST grade is " + stats.HighestGrade);
            Console.WriteLine("Your LOWEST grade is " + stats.LowestGrade);

        }
    }
}
