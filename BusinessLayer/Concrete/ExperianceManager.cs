using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class ExperianceManager : IExperianceService
    {
        private readonly IExperianceDal _experiancedal;
        public ExperianceManager(IExperianceDal experiancedal)
        {
            _experiancedal = experiancedal;
        }

        public Experiance GetByID(int id)
        {
            return _experiancedal.GetByID(id);
        }

        public void TDelete(Experiance entity)
        {
            _experiancedal.Delete(entity);
        }

        public List<Experiance> TGetList()
        {
            return _experiancedal.GetAll();
        }

        public List<Experiance> TGetListByFilter(Expression<Func<Experiance, bool>> filter)
        {
            return _experiancedal.GetByFilter(filter);
        }

        public void TInsert(Experiance entity)
        {
            _experiancedal.Insert(entity);
        }

        public void TUpdate(Experiance entity)
        {
            _experiancedal.Update(entity);
        }
    }
}
