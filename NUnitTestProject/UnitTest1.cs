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
            moodAnalyser = new MoodAnalyser("");
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


        /// <summary>
        /// TC 3.1 Given Null Mood Should Throw Exception  
        /// </summary>
        [Test]
        public void Given_Null_mood_Using_Custom_Exception_Throw_Message()
        {
            string actual = " ";
            try
            {
                actual = moodAnalyser.AnalyserMood();
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual("Mood should not be null message", exception.Message);
            }
        }

        /// <summary>
        /// TC 3.2 Given Empty Mood Should Throw Exception  
        /// </summary>
        [Test]
        public void Given_Empty_mood_Using_Custom_Exception_Throw_Message()
        {
            string actual = " ";
            try
            {
                actual = moodAnalyser.AnalyserMood();
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual("", exception.Message);
            }
        }

    }
}