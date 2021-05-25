using CompareAssertMethods.Mock;
using NUnit.Framework;

namespace CompareAssertMethods.Extensions
{
    public static class AssertWrapper
    {
        public static void IsManfred(PersonMock actual)
        {
            if (actual.Vorname != "Manfred")
                Assert.Fail("{0} ist not equal to Manfred but should.", actual.Vorname);
        }

        internal static void IsNotManfred(PersonMock actual)
        {
            if (actual.Vorname == "Manfred")
                Assert.Fail("{0} is equal to Manfred but should not.", actual.Vorname);
        }
    }
}
