using CompareAssertMethods.Mock;
using NUnit.Framework;

namespace CompareAssertMethods
{
    [TestFixture]
    public class NUnitAssertThatTests : BaseTest
    {
        [Test]
        public override void AreSameTests()
        {
            var actual = ServiceMock.GetInstance();
            var expected = actual;
            Assert.That(actual, Is.SameAs(expected));
        }

        [Test]
        public override void IsEqualTest()
        {
            var actual = ServiceMock.GetInstance();
            var expected = ServiceMock.GetInstance();
            expected.Id = actual.Id;
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public override void AreNotSameTests()
        {
            var actual = ServiceMock.GetInstance();
            var expected = ServiceMock.GetInstance(); ;
            Assert.That(actual, Is.Not.SameAs(expected));
        }

        [Test]
        public override void IsNotEqualTest()
        {
            var actual = ServiceMock.GetInstance();
            var expected = ServiceMock.GetInstance();
            Assert.That(actual, Is.Not.EqualTo(expected));
        }

        [Test]
        public override void IsNotNullTest()
        {
            var actual = ServiceMock.GetNotNull<PersonMock>();
            Assert.That(actual, Is.Not.Null);
        }

        [Test]
        public override void IsNullTest()
        {
            var actual = ServiceMock.GetNull<PersonMock>();
            Assert.That(actual, Is.Null); Assert.IsNull(actual);
        }
    }
}