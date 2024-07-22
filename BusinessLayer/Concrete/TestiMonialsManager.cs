using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class TestiMonialsManager : ITestiMonialsService
    {
        private readonly ITestiMonialsDal _testiMonialsDal;
        public TestiMonialsManager(ITestiMonialsDal testiMonialsDal)
        {
            _testiMonialsDal = testiMonialsDal;
        }

        public TestiMonials GetByID(int id)
        {
            return _testiMonialsDal.GetByID(id);
        }

        public void TDelete(TestiMonials entity)
        {
            _testiMonialsDal.Delete(entity);
        }

        public List<TestiMonials> TGetList()
        {
            return _testiMonialsDal.GetAll();
        }

        public List<TestiMonials> TGetListByFilter(Expression<Func<TestiMonials, bool>> filter)
        {
            return _testiMonialsDal.GetByFilter(filter);
        }

        public void TInsert(TestiMonials entity)
        {
            _testiMonialsDal.Insert(entity);
        }

        public void TUpdate(TestiMonials entity)
        {
            _testiMonialsDal.Update(entity);
        }
    }
}
