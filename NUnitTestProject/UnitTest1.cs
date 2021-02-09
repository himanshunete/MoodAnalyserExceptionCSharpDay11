using NUnit.Framework;
using MoodAnalyserException;

namespace NUnitTestProject
{
    public class Tests
    {
        MoodAnalyser moodAnalyser;
        [SetUp]
        public void Setup()
        {
            moodAnalyser = new MoodAnalyser(null);
        }

        /// <summary>
        /// TC 2.1 Given Null Mood Should Return Happy 
        /// </summary>
        [Test]
        public void Test1()
        {
            string expected = "HAPPY";

            var actual = moodAnalyser.AnalyserMood();
            Assert.AreEqual(expected, actual);
        }
    }
}