using System;
using System.Collections.Generic;

namespace Grades
{
    public class Gradebook
    {
        public Gradebook()
        {
            grades = new List<float>();
        }

        public GradeStatistics computeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            foreach(float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

       private List<float> grades;
    }
}
