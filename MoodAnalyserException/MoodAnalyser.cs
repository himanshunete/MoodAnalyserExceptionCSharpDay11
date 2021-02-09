using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserException
{
    public class MoodAnalyser
    {
        string message;

        /// <summary>
        /// parameterised constructor with null, sad or happy messages 
        /// </summary>
        /// <param name="message"></param>
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        /// <summary>
        /// Method to analyse mood with try catch
        /// </summary>
        /// <returns></returns>
        public string AnalyserMood()
        {
            try
            {
                if (this.message.Contains("SAD"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }

            catch
            {
                return null;
            }
            
        }
    }
}
