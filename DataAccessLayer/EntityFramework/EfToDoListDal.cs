using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Context;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfToDoListDal : GenericRepository<ToDoList>, IToDoListDal
    {
        public EfToDoListDal(DataBaseContext databasecontext) : base(databasecontext)
        {

        }
    }
}
