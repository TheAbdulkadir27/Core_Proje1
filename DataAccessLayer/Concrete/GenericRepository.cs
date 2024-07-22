using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccessLayer.Concrete
{
    public class GenericRepository<T> : IGenericDal<T> where T : class, new()
    {
        private readonly DataBaseContext _databasecontext;
        public GenericRepository(DataBaseContext databasecontext)
        {
            _databasecontext = databasecontext;
            databasecontext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
        public void Delete(T item)
        {
            _databasecontext.Set<T>().Remove(item);
            _databasecontext.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _databasecontext.Set<T>().AsNoTracking().ToList();
        }

        public List<T> GetByFilter(Expression<Func<T, bool>> filter)
        {
            return _databasecontext.Set<T>().Where(filter).ToList();
        }
        public T GetByID(int id)
        {
            return _databasecontext.Set<T>().Find(id)!;
        }

        public void Insert(T item)
        {
            _databasecontext.Set<T>().Add(item);
            _databasecontext.SaveChanges();
        }
        public void Update(T item)
        {
            _databasecontext.Set<T>().Update(item);
            _databasecontext.SaveChanges();
        }
    }
}
