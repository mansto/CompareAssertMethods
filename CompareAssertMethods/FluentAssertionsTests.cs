using CompareAssertMethods.Mock;
using FluentAssertions ;
using FluentAssertions.Extensions;
using NUnit.Framework;
using System;
using CompareAssertMethods.Extensions;

namespace CompareAssertMethods
{
    [TestFixture]
    public class FluentAssertionsTests : BaseTest
    {
        [Test]
        public override void AreSameTests()
        {
            var actual = ServiceMock.GetPerson();
            var expected = actual;
            actual.Should().BeSameAs(expected);
        }

        [Test]
        public override void IsEqualTest()
        {
            var actual = ServiceMock.GetPerson();
            var expected = ServiceMock.GetPerson();
            expected.Id = actual.Id;
            actual.Should().Be(expected);
        }


        [Test]
        public override void AreNotSameTests()
        {
            var actual = ServiceMock.GetPerson();
            var expected = ServiceMock.GetPerson(); ;
            actual.Should().NotBeSameAs(expected);
        }

        [Test]
        public override void IsNotEqualTest()
        {
            var actual = ServiceMock.GetPerson();
            var expected = ServiceMock.GetPerson();
            actual.Should().NotBe(expected);
        }

        [Test]
        public override void IsNotNullTest()
        {
            var actual = ServiceMock.GetPerson();
            actual.Should().NotBeNull();
        }

        [Test]
        public override void IsNullTest()
        {
            var actual = ServiceMock.GetNull<PersonMock>();
            actual.Should().BeNull();
        }

        [Test]
        public override void IsAssignableToTest()
        {
            var actual = ServiceMock.GetInstanceOf<PersonReadRepository>();
            actual.Should().BeAssignableTo<IReadRepository<PersonMock>>();
        }

        [Test]
        public override void IsNotAssignableToTest()
        {
            var actual = ServiceMock.GetInstanceOf<PersonWriteRepository>();
            actual.Should().NotBeAssignableTo<IReadRepository<PersonMock>>();
        }

        [Test]
        public override void PerfomanceTest()
        {
            ServiceMock.ExecutionTimeOf(x => x.SleepFor500Milliseconds()).Should().BeLessThan(600.Milliseconds());
        }

        [Test]
        public override void ExtensionTest()
        {
            var actual = ServiceMock.GetManfred();
            actual.Must().BeManfred();

            actual = ServiceMock.GetCornelia();
            actual.Must().NotBeManfred();
        }
    }
}