using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http;
using System.Text;
using Mood_Analyzer;

namespace Mood_Analyzer
{
    public class MoodAnalyser
    {
        public string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public MoodAnalyser()
        {
            this.message = message;
        }
        //Analysing Mood
        public string AnalyseMood()
        {
            Console.WriteLine("Enter Mood Name-"); //User Input
            string mood =Console.ReadLine().ToLower();
            if (message.Contains(mood))
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }
        }
    }
}