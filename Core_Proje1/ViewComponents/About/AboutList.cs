using BusinessLayer.Concrete;
using DataAccessLayer.Context;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje1.ViewComponents.About
{
    public class AboutList : ViewComponent
    {
        AboutManager AboutManager = new AboutManager(new EfAboutDal(new DataBaseContext()));
        public IViewComponentResult Invoke()
        {
            return View(AboutManager.TGetList());
        }
    }
}
