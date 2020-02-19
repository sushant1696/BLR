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
        public void multidivTest()
        {
            Arithmatic obj2 = new Arithmatic();
            int mulresult = obj2.multi(4, 6);
            int expect3 = 24;
            Assert.AreEqual(mulresult, expect3);
        }

       
    }
}