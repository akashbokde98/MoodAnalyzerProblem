using System;

namespace Mood_Analyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Mood Analyzer Problem!");

            MoodAnalyser obj1 = new MoodAnalyser("I am in sad mood");
            Console.WriteLine("{0} Mood", obj1.AnalyseMood());
        }

    }

}
