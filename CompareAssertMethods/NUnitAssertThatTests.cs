using CompareAssertMethods.Mock;
using NUnit.Framework;
using CompareAssertMethods.Extensions;

namespace CompareAssertMethods
{
    [TestFixture]
    public class NUnitAssertThatTests : BaseTest
    {
        [Test]
        public override void AreSameTests()
        {
            var actual = ServiceMock.GetPerson();
            var expected = actual;
            Assert.That(actual, Is.SameAs(expected));
        }

        [Test]
        public override void IsEqualTest()
        {
            var actual = ServiceMock.GetPerson();
            var expected = ServiceMock.GetPerson();
            expected.Id = actual.Id;
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public override void AreNotSameTests()
        {
            var actual = ServiceMock.GetPerson();
            var expected = ServiceMock.GetPerson(); ;
            Assert.That(actual, Is.Not.SameAs(expected));
        }

        [Test]
        public override void IsNotEqualTest()
        {
            var actual = ServiceMock.GetPerson();
            var expected = ServiceMock.GetPerson();
            Assert.That(actual, Is.Not.EqualTo(expected));
        }

        [Test]
        public override void IsNotNullTest()
        {
            var actual = ServiceMock.GetPerson();
            Assert.That(actual, Is.Not.Null);
        }

        [Test]
        public override void IsNullTest()
        {
            var actual = ServiceMock.GetNull<PersonMock>();
            Assert.That(actual, Is.Null); Assert.IsNull(actual);
        }

        [Test]
        public override void IsAssignableToTest()
        {
            var actual = ServiceMock.GetInstanceOf<PersonReadRepository>();
            Assert.That(actual, Is.AssignableTo<IReadRepository<PersonMock>>());
        }

        [Test]
        public override void IsNotAssignableToTest()
        {
            var actual = ServiceMock.GetInstanceOf<PersonWriteRepository>();
            Assert.That(actual, Is.Not.AssignableTo<IReadRepository<PersonMock>>());
        }

        [Test]
        [MaxTime(600)]
        public override void PerfomanceTest()
        {
            ServiceMock.SleepFor500Milliseconds();
        }

        [Test]
        public override void ExtensionTest()
        {
            var actual = ServiceMock.GetManfred();
            Assert.That(actual, MyIs.Manfred());

            actual = ServiceMock.GetCornelia();
            Assert.That(actual, Is.Not.Manfred());
        }
    }
}