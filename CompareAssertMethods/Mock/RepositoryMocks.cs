using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CompareAssertMethods.Mock
{
    public interface IReadRepository<T>
    {
        T Get(Guid id);

        IEnumerable<T> Get();

        IEnumerable<T> FindAll(Expression<Func<T, bool>> predicate);
    }

    public interface IWriteRepository<T>
    {
         Guid Write(T entity);

        IEnumerable<Guid> Write(IEnumerable<T> entities);

    }

    public class PersonReadRepository : IReadRepository<PersonMock>
    {
        public IEnumerable<PersonMock> FindAll(Expression<Func<PersonMock, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public PersonMock Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PersonMock> Get()
        {
            throw new NotImplementedException();
        }
    }

    public class PersonWriteRepository : IWriteRepository<PersonMock>
    {
        public Guid Write(PersonMock entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Guid> Write(IEnumerable<PersonMock> entities)
        {
            throw new NotImplementedException();
        }
    }
}
