using System.Linq.Expressions;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class, new()
    {
        void Insert(T item);
        void Update(T item);
        void Delete(T item);
        List<T> GetAll();
        T GetByID(int id);
        List<T> GetByFilter(Expression<Func<T, bool>> filter);
    }
}
