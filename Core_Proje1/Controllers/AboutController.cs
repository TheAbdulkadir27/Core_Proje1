using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
namespace Core_Proje1.Controllers
{
    public class AboutController : Controller
    {
        AboutManager AboutManager = new AboutManager(new EfAboutDal(new DataAccessLayer.Context.DataBaseContext()));

        [HttpGet]
        public IActionResult Index()
        {
            return View(AboutManager.GetByID(1));
        }

        [HttpPost]
        public IActionResult Index(About about)
        {
            AboutManager.TUpdate(about);
            return RedirectToAction("Index", "Default");
        }
    }
}
