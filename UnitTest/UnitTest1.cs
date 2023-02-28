using NUnit.Framework;
//using MoodAnalyzer;
using Mood_Analyzer;

namespace UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        // TC 3.1 - NULL Mood
        [Test]
        [TestCase("I am in sad mood")]
        public void Test1_AnalyzeMood_PassingValidInput_ReturnTrue(string input)
        {
            MoodAnalyser msg = new MoodAnalyser(input);
            string expected = null;

            string actual = msg.AnalyseMood1();

            Assert.AreEqual(expected, actual);
        }

        // TC 3.2 - Empty Mood
        [Test]
        [TestCase("I am in Sad mood")]
        public void Test2_AnalyzeMood_PassingValidInput_ReturnTrue(string input)
        {
            MoodAnalyser msg = new MoodAnalyser(input);
            string expected = "";

            string actual = msg.AnalyseMood2();

            Assert.AreEqual(expected, actual);
        }
    }

}