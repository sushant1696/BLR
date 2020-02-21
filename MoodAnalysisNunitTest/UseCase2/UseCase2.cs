using System;
using System.Collections.Generic;
using System.Text;

namespace NunitTestInMoodAnalysis.UseCase2
{
    class UseCase2
    {
        string message;

        public UseCase2()
        {
        }

        public UseCase2(string msg)
        {
            this.message = msg;
        }
        public static string MoodAnalyse_ReturnMethod3(string message)
        {
            try
            {
                if (message.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                else (message.ToLower().Contains("happy"))
                {
                    return "HAPPY";
                }
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "happy";
            }
            return null;
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
