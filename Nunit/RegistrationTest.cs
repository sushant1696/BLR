using NUnit.Framework;
using UnitTest;

namespace NUnitTestProject1
{
    public class Tests
    {
       [TestCase]
        public void addTest()
        {
            Arithmatic obj = new Arithmatic();
            int result=obj.add(2, 3);
            int expect = 5;
            Assert.AreEqual(result, expect);
            int result2 = obj.sub(7, 5);
            int expect2 = 2;
            Assert.AreEqual(result2, expect2);
        }
        [TestCase]
        public void multidivTest()
        {
            Arithmatic obj2 = new Arithmatic();
            int mulresult = obj2.multi(4, 6);
            int expect3 = 24;
            Assert.AreEqual(mulresult, expect3);
        }

        [TestCase]
        public void PhoneNoTest()
        {
            string PhoneNo = "9577039035";
            string num = RegexDemo.PhoneNumber(PhoneNo);
            Assert.AreEqual(PhoneNo, num);
        }
        [TestCase]
        public void FnameTest()
        {
            string fname = "Sushant";
            string expect = RegexDemo.FirstName(fname);
            Assert.AreEqual(fname, expect);
        }
        [TestCase]
        public void LnameTest()
        {
            string lname = "Daas";
            string expect = RegexDemo.LastName(lname);
            Assert.AreEqual(lname, expect);
        }
        [TestCase]
        public void emailTest()
        {
            string eml ="shaan1696@gmail.com";
            string expect1 = RegexDemo.Email(eml);
            Assert.AreEqual(eml, expect1);
        }
        public void passwordTest()
        {
            string pswds = "shan123.";
            string expect2 = RegexDemo.Email(pswds);
            Assert.AreEqual(pswds, expect2);
        }
    }
}