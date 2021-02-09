using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserException
{
    public class MoodAnalyserCustomException:Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {
            EMPTY_MESSAGE,
            NULL_MESSAGE,
        }

        public MoodAnalyserCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
