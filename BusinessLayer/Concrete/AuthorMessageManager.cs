using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class AuthorMessageManager : IAuthorMessageService
    {
        private readonly IAuthorMessageDal _authormessagedal;
        public AuthorMessageManager(IAuthorMessageDal authormessagedal)
        {
            _authormessagedal = authormessagedal;
        }

        public AuthorMessage GetByID(int id)
        {
            return _authormessagedal.GetByID(id);
        }

        public void TDelete(AuthorMessage entity)
        {
            _authormessagedal.Delete(entity);
        }

        public List<AuthorMessage> TGetList()
        {
            return _authormessagedal.GetAll();
        }

        public List<AuthorMessage> TGetListByFilter(Expression<Func<AuthorMessage, bool>> filter)
        {
            return _authormessagedal.GetByFilter(filter);
        }

        public void TInsert(AuthorMessage entity)
        {
            _authormessagedal.Insert(entity);
        }

        public void TUpdate(AuthorMessage entity)
        {
            _authormessagedal.Update(entity);
        }
    }
}
