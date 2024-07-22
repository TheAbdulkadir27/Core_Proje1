using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje1.Controllers
{
    public class ContactController : Controller
    {
        MessageManager ContactManager = new MessageManager(new EfMessageDal(new DataAccessLayer.Context.DataBaseContext()));
        public IActionResult Index() => View(ContactManager.TGetList());
        public IActionResult DeleteContact(int id)
        {
            ContactManager.TDelete(ContactManager.GetByID(id));
            return RedirectToAction("Index");
        }
        public IActionResult DetailsContact(int id)
        {
            return View(ContactManager.GetByID(id));    
        }
    }
}
