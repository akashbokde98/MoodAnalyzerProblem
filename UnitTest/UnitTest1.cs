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

        // TC 2.1
        [Test]
        [TestCase("I am in sad mood")]
        public void Test1_AnalyzeMood_PassingValidInput_ReturnTrue(string input)
        {
            MoodAnalyser msg = new MoodAnalyser(input);
            string expected = "Happy";

            var actual = msg.AnalyseMood();

            Assert.AreEqual(expected, actual);
        }

    }

}