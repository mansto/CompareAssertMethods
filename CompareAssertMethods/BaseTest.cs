using CompareAssertMethods.Mock;
using NUnit.Framework;

namespace CompareAssertMethods
{
    public abstract class BaseTest
    {
        protected ServiceMock ServiceMock { get; private set; }

        [SetUp]
        public void SetUp()
        {
            ServiceMock = new ServiceMock();
        }

        public abstract void AreSameTests();

        public abstract void IsEqualTest();

        public abstract void IsNullTest();

        public abstract void IsNotNullTest();

        public abstract void AreNotSameTests();

        public abstract void IsNotEqualTest();
    }
}
