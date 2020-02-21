using System;
using Xunit;
using UnitTest;

namespace XunitTest
{
  
    public class RegistrationUsingXunitTest
    {
        [Fact]

        public void PhoneNoTest()
        {
            string PhonNo = "9577039035";
            string num = RegexDemo.PhoneNumber(PhonNo);
            Assert.Equal(PhonNo, num);
        }
        [Fact]
        public void EmailTest()
        {
            string eml = "shan16@gmaiL.com";
            string expct = RegexDemo.Email(eml);
            Assert.Equal(eml, expct);
        }
    }
}
