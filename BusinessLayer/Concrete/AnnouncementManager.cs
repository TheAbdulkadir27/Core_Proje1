using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class AnnouncementManager : IAnnouncementService
    {
        private readonly IAnnouncementDal announcementDal;
        public AnnouncementManager(IAnnouncementDal announcementDal) => this.announcementDal = announcementDal;
        public Announcement GetByID(int id)
        {
            return announcementDal.GetByID(id);
        }

        public void TDelete(Announcement entity)
        {
           announcementDal.Delete(entity);
        }

        public List<Announcement> TGetList()
        {
            return announcementDal.GetAll();
        }

        public List<Announcement> TGetListByFilter(Expression<Func<Announcement, bool>> filter)
        {
            return announcementDal.GetByFilter(filter);
        }

        public void TInsert(Announcement entity)
        {
           announcementDal.Insert(entity);
        }

        public void TUpdate(Announcement entity)
        {
           announcementDal.Update(entity);
        }
    }
}
