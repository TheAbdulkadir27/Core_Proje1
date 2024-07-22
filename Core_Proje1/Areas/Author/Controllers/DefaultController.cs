using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Core_Proje1.Areas.Author.Controllers
{
    [Area("Author")]
    [Authorize]
    public class DefaultController : Controller
    {
        AnnouncementManager AnnouncementManager = new AnnouncementManager(new EfAnnouncementDal(new DataAccessLayer.Context.DataBaseContext()));
        public IActionResult Index()
        {
           var values =  AnnouncementManager.TGetList();
            return View(values);
        }
        public IActionResult AnnouncementDetail(int id)
        {
            return View(AnnouncementManager.GetByID(id));
        }
    }
}
