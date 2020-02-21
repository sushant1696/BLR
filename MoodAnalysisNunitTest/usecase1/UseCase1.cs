using System;
using System.Collections.Generic;
using System.Text;

namespace NunitTestInMoodAnalysis.usecase1
{
    class UseCase1
    {
        string message;

        public UseCase1()
        {
        }

        public UseCase1(string msg)
        {
            this.message = msg;
        }
        public static string MoodAnalyse_ReturnMethod(string message)
        {
            if (message.ToLower().Contains("sad"))
            {
                return "SAD";
            }
            else if (message.ToLower().Contains("happy"))
            {
                return "HAPPY";
            }
            else
                return "HAPPY";
        }

        public string MoodAnalyse_ReturnMethod()
        {
            if (message.ToLower().Contains("sad"))
            {
                return "SAD";
            }
            else if (message.ToLower().Contains("happy"))
            {
                return "HAPPY";
            }
            else
                return "HAPPY";
        }
    }
}
