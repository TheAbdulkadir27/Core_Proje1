using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Context;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfTestiMonialsDal : GenericRepository<TestiMonials>, ITestiMonialsDal
    {
        public EfTestiMonialsDal(DataBaseContext databasecontext) : base(databasecontext)
        {

        }
    }
}
