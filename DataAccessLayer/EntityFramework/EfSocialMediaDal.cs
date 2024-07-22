using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Context;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfSocialMediaDal : GenericRepository<SocialMedia>, SocialMediaDal
    {
        public EfSocialMediaDal(DataBaseContext databasecontext) : base(databasecontext)
        {

        }
    }
}
