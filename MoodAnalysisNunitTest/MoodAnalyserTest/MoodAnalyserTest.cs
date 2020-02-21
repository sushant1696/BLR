
using NUnit.Framework;
using NunitTestInMoodAnalysis.usecase1;
using NunitTestInMoodAnalysis.UseCase2;
using System;

namespace MoodAnalysisNunitTest
{
    public class Tests
    {
        [Test]
        public void GivenSadMessage_WhenAnalyse_ReturnSad()
        {
            string obj = UseCase1.MoodAnalyse_ReturnMethod("i am sad");
            Assert.AreEqual("SAD", obj);
        }
        [Test]
        public void GivenHappyMessage_WhenAnalyse_Returnhappy()
        {
            string obj = UseCase1.MoodAnalyse_ReturnMethod("i am happy");
            Assert.AreEqual("HAPPY", obj);
        }
        [Test]
        public void GivenAnyMoodMessage_WhenAnalyse_Returnhappy()
        {
            string obj = UseCase1.MoodAnalyse_ReturnMethod("i am happy");
            Assert.AreEqual("HAPPY", obj);
        }
        [Test]
        public void GivenSadMessage_WhenAnalyse_ReturnSad2()
        {
            UseCase1 obj = new UseCase1("i am sad");
            string result =obj.MoodAnalyse_ReturnMethod();
            Assert.AreEqual("SAD", result);
        }
        [Test]
        public void GivenHappyMessage_WhenAnalyse_Returnhappy2()
        {
            UseCase1 obj = new UseCase1("i am Happy");
            string result = obj.MoodAnalyse_ReturnMethod();
            Assert.AreEqual("HAPPY", result);
        }
        [Test]
        public void GivenAnyMoodMessage_WhenAnalyse_Returnhappy2()
        {
            UseCase1 obj = new UseCase1("i am Happy");
            string result = obj.MoodAnalyse_ReturnMethod();
            Assert.AreEqual("HAPPY", result);
        }
        //for usecase2
        [Test]
        public void GivenSadMessage_WhenAnalyse_ReturnSad3()
        {
            string obj = UseCase2.MoodAnalyse_ReturnMethod3(null);
            Assert.AreEqual("HAPPY", obj);
        }
        
       

    }
}