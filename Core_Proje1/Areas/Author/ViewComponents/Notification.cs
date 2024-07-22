using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
namespace Core_Proje1.Areas.Author.ViewComponents
{
    public class Notification : ViewComponent
    {
        AnnouncementManager AnnouncementManager = new AnnouncementManager(new EfAnnouncementDal(new DataAccessLayer.Context.DataBaseContext()));

        public IViewComponentResult Invoke()
        {
            return View(AnnouncementManager.TGetList().Take(5).ToList());
        }
    }
}
