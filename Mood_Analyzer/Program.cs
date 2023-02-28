using System;

namespace Mood_Analyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Mood Analyzer Problem!");

            MoodAnalyser obj1 = new MoodAnalyser("I am in sad mood");
            Console.WriteLine(obj1.AnalyseMood1());
            Console.WriteLine(obj1.AnalyseMood2());
        }

    }

}
