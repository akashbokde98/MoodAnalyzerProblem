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
        public string AnalyseMood1()
        {
            string nullMood = null; //Taken Null Value Input
            try
            {
                if (string.IsNullOrEmpty(nullMood))
                {
                    throw new MoodAnalysisException(ExceptionMessage.NullMoodName);
                }
            }
            catch (MoodAnalysisException)
            {
                Console.WriteLine("Entered Invalid Null Value");
                return nullMood;
            }
            return "";
        }
        public string AnalyseMood2()
        {
            string emptyMood = ""; //Taken Empty Value Input
            try
            {
                if (string.IsNullOrEmpty(emptyMood))
                {
                    throw new MoodAnalysisException(ExceptionMessage.EmptyMoodName);
                }
            }
            catch (MoodAnalysisException)
            {
                Console.WriteLine("Entered Invalid Empty Value");
                return emptyMood;
            }
            return "";
        }
    }
}