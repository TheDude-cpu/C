
using System;
using System.Collections.Generic;
using System.Linq;

// Student diary
namespace Lesson_class
{   
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary(); // declaration first class // new creat instation of diary

            diary.AddRating(5);
            diary.AddRating(8.5f);
            diary.AddRating(4.7f);

            DiaryStatistics stats = diary.ComputeStatistics();

            //var avg = stats.AverageGrade;

            Console.WriteLine("Average Value:" + stats.AverageGrade);
            Console.WriteLine("Average Value Max:" + stats.MaxGrade);
            Console.WriteLine("Average Value Min:" + stats.MinGrade);

            Console.ReadKey();

        }
 
    }
}
