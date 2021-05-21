using CompareAssertMethods.Mock;
using FluentAssertions;
using NUnit.Framework;

namespace CompareAssertMethods
{
    [TestFixture]
    public class FluentAssertionsTests : BaseTest
    {
        [Test]
        public override void AreSameTests()
        {
            var actual = ServiceMock.GetInstance();
            var expected = actual;
            actual.Should().BeSameAs(expected);
        }

        [Test]
        public override void IsEqualTest()
        {
            var actual = ServiceMock.GetInstance();
            var expected = ServiceMock.GetInstance();
            expected.Id = actual.Id;
            actual.Should().Be(expected);
        }


        [Test]
        public override void AreNotSameTests()
        {
            var actual = ServiceMock.GetInstance();
            var expected = ServiceMock.GetInstance(); ;
            actual.Should().NotBeSameAs(expected);
        }

        [Test]
        public override void IsNotEqualTest()
        {
            var actual = ServiceMock.GetInstance();
            var expected = ServiceMock.GetInstance();
            actual.Should().NotBe(expected);
        }

        [Test]
        public override void IsNotNullTest()
        {
            var actual = ServiceMock.GetNotNull<PersonMock>();
            actual.Should().NotBeNull();
        }

        [Test]
        public override void IsNullTest()
        {
            var actual = ServiceMock.GetNull<PersonMock>();
            actual.Should().BeNull();
        }
    }
}