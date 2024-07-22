using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Context;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfPortFolioDal : GenericRepository<PortFolio>, IPortFolioDal
    {
        public EfPortFolioDal(DataBaseContext databasecontext) : base(databasecontext)
        {

        }
    }
}
