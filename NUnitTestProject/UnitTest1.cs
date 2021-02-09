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
        public void Given_Null_Mood_Return_Happy()
        {
            string expected = "Happy";
            var actual = moodAnalyser.AnalyserMood();
            Assert.AreEqual(expected, actual);
        }

    }
}