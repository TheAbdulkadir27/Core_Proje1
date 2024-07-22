using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Context;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
namespace DataAccessLayer.EntityFramework
{
    public class EfUserMessageDal : GenericRepository<UserMessage>, IUserMessageDal
    {
        public EfUserMessageDal(DataBaseContext databasecontext) : base(databasecontext)
        {

        }
        public List<UserMessage> GetAllUserMessageWithUser()
        {
            using (DataBaseContext databasecontext = new DataBaseContext())
            {
                return databasecontext.UserMessages.Include(X => X.User).ToList();
            }
        }
    }
}
