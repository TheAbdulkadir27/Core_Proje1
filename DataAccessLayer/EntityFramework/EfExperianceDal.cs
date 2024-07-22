using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Context;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfExperianceDal : GenericRepository<Experiance>, IExperianceDal
    {
        public EfExperianceDal(DataBaseContext databasecontext) : base(databasecontext)
        {
        }
    }
}
