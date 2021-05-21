using CompareAssertMethods.Mock;
using NUnit.Framework;

namespace CompareAssertMethods
{
    [TestFixture]
    public class NUnitAssertTests : BaseTest
    {
        [Test]
        public override void AreSameTests()
        {
            var actual = ServiceMock.GetInstance();
            var expected = actual;
            Assert.AreSame(expected, actual);
        }

        [Test]
        public override void IsEqualTest()
        {
            var actual = ServiceMock.GetInstance();
            var expected = ServiceMock.GetInstance();
            expected.Id = actual.Id;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public override void AreNotSameTests()
        {
            var actual = ServiceMock.GetInstance();
            var expected = ServiceMock.GetInstance();
            Assert.AreNotSame(expected, actual);
        }

        [Test]
        public override void IsNotEqualTest()
        {
            var actual = ServiceMock.GetInstance();
            var expected = ServiceMock.GetInstance();
            Assert.AreNotEqual(expected, actual);
        }

        [Test]
        public override void IsNotNullTest()
        {
            var actual = ServiceMock.GetNotNull<PersonMock>();
            Assert.IsNotNull(actual);
        }

        [Test]
        public override void IsNullTest()
        {
            var actual = ServiceMock.GetNull<PersonMock>();
            Assert.IsNull(actual);
        }
    }
}