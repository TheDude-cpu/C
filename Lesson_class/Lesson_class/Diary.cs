using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson_class
{
    class Diary
    {
        public Diary() // default constructor
        {
            ratings = new List<float>();
        }
        // Stan - variables (fields)
        private List<float> ratings;

        public static float MinGrade = 0;
        public static float MaxGrade = 10; 

        //Behavior - method 
        public void AddRating(float rating) //parameter ratings to add
        {
            ratings.Add(rating); // add ratings to diary
        }

        internal DiaryStatistics ComputeStatistics()
        {
            DiaryStatistics stats = new DiaryStatistics();

            float sum = 0f;

            foreach (var rating in ratings)
            {
                sum += rating;
            }

            stats.AverageGrade = sum / ratings.Count();
            stats.MaxGrade = ratings.Max();
            stats.MinGrade = ratings.Min();

            return stats;
        }

    }
}
