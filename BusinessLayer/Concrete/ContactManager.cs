using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactdal;
        public ContactManager(IContactDal contactdal)
        {
            _contactdal = contactdal;
        }

        public Contact GetByID(int id)
        {
            return _contactdal.GetByID(id);
        }

        public void TDelete(Contact entity)
        {
            _contactdal.Delete(entity);
        }

        public List<Contact> TGetList()
        {
            return _contactdal.GetAll();
        }

        public List<Contact> TGetListByFilter(Expression<Func<Contact, bool>> filter)
        {
            return _contactdal.GetByFilter(filter);
        }

        public void TInsert(Contact entity)
        {
            _contactdal.Insert(entity);
        }

        public void TUpdate(Contact entity)
        {
            _contactdal.Update(entity);
        }
    }
}
