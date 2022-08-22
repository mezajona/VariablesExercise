using System;

namespace VariablesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //declared and initialized a variable.
            //camelCase for the variable name
            //explicit typing
            string dogName = "Ralf";
            int dogAge = 10;
            char nickName = 'R';
            bool lovesHiking = true;
            double tennisBalls = 32;
            decimal weight = 70.3m;


            //string interpolation with the $ AND { } around variables
            Console.WriteLine($"My dog's name is {dogName}, he is {dogAge} years old and he has {tennisBalls} tennis balls and it is {lovesHiking} that he loves to hike, which keeps him at his weight of {weight} pounds.");
          
        }
    }
}

