
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

            for (; ; ) // infinit loop
            {
                Console.WriteLine("Write rating from range 1-10");

                float rating;
                bool result = float.TryParse(Console.ReadLine(), out rating); // change string on float

                if (rating == 11)
                {
                    break;
                }

                if (result == true) // we can write only result
                {
                    if (rating > 0 && rating <=10)
                    {
                        diary.AddRating(rating); //add rating to diary
                    }
                    else
                        Console.WriteLine("Not expected rating");
                }

            }

            Console.WriteLine("Average your ratings is: " + diary.CalculateAverage());
            Console.WriteLine("Max rating of your ratings is: " + diary.GiveMaxRating());
            Console.WriteLine("Min rating of your ratings is: " + diary.GiveMinRating());

            Console.ReadKey();

            Diary diary2 = new Diary(); // next diary ...
            Diary diary3 = new Diary(); // each is different diary with rating,  and each has access to method, instance etc.
            Diary diary4 = new Diary();
        }
 
    }
}
