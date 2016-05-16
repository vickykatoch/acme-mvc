using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using Acme.Domain;
using System.Data.Entity;

namespace Acme.Data.Repo
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected readonly AcmeContext _context = new AcmeContext();

        #region IRepository Members
        public virtual IEnumerable<T> FetchAll()
        {
            return _context.Set<T>().ToList();
        }

        public virtual IEnumerable<T> FetchByQuery(Expression<Func<T, bool>> predicate)
        {
            return _context
                .Set<T>()
                .Where(predicate)
                .ToList();
        }

        public virtual T FindById<TInput>(TInput id)
        {
            return _context
                    .Set<T>()
                    .Find(id);
        }

        public virtual bool Save(T entity)
        {
            if (entity.IsNew)
            {
                _context.Set<T>().Add(entity);
            }
            else
            {
                _context.Set<T>().Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;
            }
            _context.SaveChanges();
            return true;
        }
        #endregion

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
