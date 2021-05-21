namespace CompareAssertMethods.Mock
{
    public class ServiceMock
    {
        internal T GetNull<T>() where T : class
        {
            return default;
        }

        internal T GetNotNull<T>() where T : class, new()
        {
            return new T();
        }

        internal PersonMock GetInstance()
        {
            return new PersonMock("Test", "Person", 44);
        }
    }
}