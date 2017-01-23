using System;
using NUnit.Framework;

namespace NUnitTests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        [TestCase(8, true)]
        [TestCase(16, true)]
        [TestCase(32, true)]
        [TestCase(64, true)]
        [TestCase(99, false)]
        public void IsEven_SuccessOrFailure(int x, bool expected)
        {
            NeedsTesting nt = new NeedsTesting();
            bool actual = nt.isEven(x);
            //Assert.That(actual, Is.True);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ExceptionIsThrown()
        {
            NeedsTesting nt = new NeedsTesting();
            Exception e = Assert.Throws<Exception>(
                new TestDelegate(nt.ExceptionWrapper), "message");
        }
    }

    public class NeedsTesting
    {
        public bool isEven(int x)
        {
            return x % 2 == 0;
        }

        public void ExceptionWrapper()
        {
            bool b = ThrowsException2("hej");
        }
        public bool ThrowsException2(string hej)
        {
            throw new Exception();
        }
    }
}
