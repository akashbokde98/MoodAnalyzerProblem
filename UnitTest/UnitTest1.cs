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

        // TC 1.1
        [Test]
        [TestCase("I am in sad mood")]
        public void Test1_AnalyzeMood_PassingValidInput_ReturnTrue(string input)
        {
            MoodAnalyser msg = new MoodAnalyser(input);
            string expected = "Sad";

            var actual = msg.AnalyseMood();

            Assert.AreEqual(expected, actual);
        }

        //TC 1.2
        [Test]
        [TestCase("I am in any mood")]
        public void Test2_AnalyzeMood_PassingValidInput_ReturnTrue(string input)
        {
            MoodAnalyser msg = new MoodAnalyser(input);
            string expected = "Happy";

            var actual = msg.AnalyseMood();

            Assert.AreEqual(expected, actual);
        }
    }
}