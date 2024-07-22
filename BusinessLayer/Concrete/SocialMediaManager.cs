using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly SocialMediaDal _socialMediaDal;
        public SocialMediaManager(SocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }

        public SocialMedia GetByID(int id)
        {
            return _socialMediaDal.GetByID(id);
        }

        public void TDelete(SocialMedia entity)
        {
            _socialMediaDal.Delete(entity);
        }

        public List<SocialMedia> TGetList()
        {
            return _socialMediaDal.GetAll();
        }

        public List<SocialMedia> TGetListByFilter(Expression<Func<SocialMedia, bool>> filter)
        {
            return _socialMediaDal.GetByFilter(filter);
        }

        public void TInsert(SocialMedia entity)
        {
            _socialMediaDal.Insert(entity);
        }

        public void TUpdate(SocialMedia entity)
        {
            _socialMediaDal.Update(entity);
        }
    }
}
