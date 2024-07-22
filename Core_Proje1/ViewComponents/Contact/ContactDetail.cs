using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje1.ViewComponents.Contact
{
    public class ContactDetail : ViewComponent
    {
        ContactManager ContactManager = new ContactManager(new EfContactDal(new DataAccessLayer.Context.DataBaseContext()));
        public IViewComponentResult Invoke()
        {
            return View(ContactManager.TGetList());
        }
    }
}
