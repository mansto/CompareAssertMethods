using CompareAssertMethods.Extensions;
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
            var actual = ServiceMock.GetPerson();
            var expected = actual;
            Assert.AreSame(expected, actual);
        }

        [Test]
        public override void IsEqualTest()
        {
            var actual = ServiceMock.GetPerson();
            var expected = ServiceMock.GetPerson();
            expected.Id = actual.Id;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public override void AreNotSameTests()
        {
            var actual = ServiceMock.GetPerson();
            var expected = ServiceMock.GetPerson();
            Assert.AreNotSame(expected, actual);
        }

        [Test]
        public override void IsNotEqualTest()
        {
            var actual = ServiceMock.GetPerson();
            var expected = ServiceMock.GetPerson();
            Assert.AreNotEqual(expected, actual);
        }

        [Test]
        public override void IsNotNullTest()
        {
            var actual = ServiceMock.GetPerson();
            Assert.IsNotNull(actual);
        }

        [Test]
        public override void IsNullTest()
        {
            var actual = ServiceMock.GetNull<PersonMock>();
            Assert.IsNull(actual);
        }

        [Test]
        public override void IsAssignableToTest()
        {
            var actual = ServiceMock.GetInstanceOf<PersonReadRepository>();
            Assert.IsInstanceOf<IReadRepository<PersonMock>>(actual);
        }

        [Test]
        public override void IsNotAssignableToTest()
        {
            var actual = ServiceMock.GetInstanceOf<PersonWriteRepository>();
            Assert.IsNotInstanceOf<IReadRepository<PersonMock>>(actual);
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
            AssertWrapper.IsManfred(actual);

            actual = ServiceMock.GetCornelia();
            AssertWrapper.IsNotManfred(actual);

        }
    }
}