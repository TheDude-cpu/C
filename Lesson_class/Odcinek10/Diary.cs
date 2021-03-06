﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Odcinek10
{
    class Diary
    {
        public Diary() // default constructor
        {
            ratings = new List<float>();
        }
        // Stan - variables (fields)
        List<float> ratings;

        //Behavior - method 
        public void AddRating(float rating) //parameter ratings to add
        {
            ratings.Add(rating); // add ratings to diary
        }

        public float CalculateAverage()
        {
            float sum = 0, avg = 0;

            foreach (var rating in ratings)
            {
                sum += rating;
            }

            avg = sum / ratings.Count();

            return avg;
        }

        public float GiveMaxRating()
        {
            return ratings.Max(); // return max element on the list
        }

        public float GiveMinRating()
        {
            return ratings.Min(); // return min element on the list
        }


    }
}
