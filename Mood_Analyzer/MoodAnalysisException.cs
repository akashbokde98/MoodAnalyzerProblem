using System;
using System.Collections.Generic;
using System.Text;

namespace Mood_Analyzer
{
    public class MoodAnalysisException : Exception
    {
        public MoodAnalysisException(ExceptionMessage message) : base(message.ToString())
        {

        }
    }
    public enum ExceptionMessage
    {
        NullMoodName,
        EmptyMoodName,
    }
}
