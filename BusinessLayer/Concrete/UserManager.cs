using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User GetByID(int id)
        {
            return _userDal.GetByID(id);
        }

        public void TDelete(User entity)
        {
            _userDal.Delete(entity);
        }

        public List<User> TGetList()
        {
            return _userDal.GetAll();
        }

        public List<User> TGetListByFilter(Expression<Func<User, bool>> filter)
        {
            return _userDal.GetByFilter(filter);
        }

        public void TInsert(User entity)
        {
            _userDal.Insert(entity);
        }

        public void TUpdate(User entity)
        {
            _userDal.Update(entity);
        }
    }
}
