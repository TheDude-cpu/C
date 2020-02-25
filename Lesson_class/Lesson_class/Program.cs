
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

            float avg = diary.CalculateAverage();
            float max = diary.GiveMaxRating();
            float min = diary.GiveMinRating();

            for (; ; ) // infinit loop
            {
                Console.WriteLine("Write rating from range 1-10" );

                float rating = float.Parse(Console.ReadLine()); // change string on float

                if (rating == 11)
                {
                    break;
                }

                diary.AddRating(rating); //add rating to diary
            }

            Console.WriteLine("Average your ratings is: " + diary.CalculateAverage());
            Console.WriteLine("Max rating of your ratings is: " + diary.GiveMaxRating());
            Console.WriteLine("Min rating of your ratings is: " + diary.GiveMinRating());

            Console.ReadKey();
        }
 
    }
}
