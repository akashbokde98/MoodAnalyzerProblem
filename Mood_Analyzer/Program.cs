using System;

namespace Mood_Analyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Mood Analyzer Problem!");

            MoodAnalyser obj1 = new MoodAnalyser("I am in sad mood");
            Console.WriteLine("I am in {0} mood", obj1.AnalyseMood());
            MoodAnalyser obj2 = new MoodAnalyser("I am in any mood");
            Console.WriteLine("I am in {0} mood", obj2.AnalyseMood());
        }

    }
}
