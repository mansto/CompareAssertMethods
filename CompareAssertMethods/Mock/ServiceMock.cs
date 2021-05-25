using System;
using System.Threading;

namespace CompareAssertMethods.Mock
{
    public class ServiceMock
    {
        internal T GetNull<T>() where T : class
        {
            return default;
        }

        internal PersonMock GetPerson()
        {
            return new PersonMock("Test", "Person", 44);
        }

        internal PersonMock GetManfred()
        {
            return new PersonMock("Manfred", "Stocker", 25);
        }

        internal PersonMock GetCornelia()
        {
            return new PersonMock("Cornelia", "Stocker", 25);
        }

        internal T GetInstanceOf<T>() where T : new()
        {
            return new T();
        }

        public void SleepFor500Milliseconds()
        {
            Thread.Sleep(500);
        }

     
    }
}