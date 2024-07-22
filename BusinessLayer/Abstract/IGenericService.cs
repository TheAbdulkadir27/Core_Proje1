using System.Linq.Expressions;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class, new()
    {
        void TInsert(T entity);
        void TUpdate(T entity);
        void TDelete(T entity);
        List<T> TGetList();
        T GetByID(int id);
        List<T> TGetListByFilter(Expression<Func<T,bool>> filter);
    }
}
