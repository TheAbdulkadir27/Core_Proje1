using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Context;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfAuthorMessageDal : GenericRepository<AuthorMessage>, IAuthorMessageDal
    {
        public EfAuthorMessageDal(DataBaseContext databasecontext) : base(databasecontext)
        {

        }
    }
}
