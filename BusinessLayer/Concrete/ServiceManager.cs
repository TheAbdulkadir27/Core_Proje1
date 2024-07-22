using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDal _servicedal;
        public ServiceManager(IServiceDal servicedal)
        {
            _servicedal = servicedal;
        }

        public Service GetByID(int id)
        {
            return _servicedal.GetByID(id);
        }

        public void TDelete(Service entity)
        {
            _servicedal.Delete(entity);
        }

        public List<Service> TGetList()
        {
            return _servicedal.GetAll();
        }

        public List<Service> TGetListByFilter(Expression<Func<Service, bool>> filter)
        {
            return _servicedal.GetByFilter(filter);
        }

        public void TInsert(Service entity)
        {
            _servicedal.Insert(entity);
        }

        public void TUpdate(Service entity)
        {
            _servicedal.Update(entity);
        }
    }
}
