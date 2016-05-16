using Acme.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Acme.Data.Repo
{
    public interface IRepository<T> : IDisposable where T : Entity  
    {
        T FindById<TInput>(TInput id);
        IEnumerable<T> FetchAll();
        bool Save(T entity);
        IEnumerable<T> FetchByQuery(Expression<Func<T,bool>> predicate);

    }
}
