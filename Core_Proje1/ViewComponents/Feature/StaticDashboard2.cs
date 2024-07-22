using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;
namespace Core_Proje1.ViewComponents.Feature
{
    public class StaticDashboard2 : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using (DataBaseContext dataBaseContext = new DataBaseContext())
            {
                ViewBag.V1 = dataBaseContext.PortFolios.Count();
                ViewBag.V2 = dataBaseContext.Messages.Count();
                ViewBag.V3 = dataBaseContext.Services.Count();
            }
            return View();
        }
    }
}
