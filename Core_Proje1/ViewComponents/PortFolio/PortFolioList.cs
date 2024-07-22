using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
namespace Core_Proje1.ViewComponents.PortFolio
{
    public class PortFolioList : ViewComponent
    {
        PortFolioManager PortFolioManager = new PortFolioManager(new EfPortFolioDal(new DataAccessLayer.Context.DataBaseContext()));
        public IViewComponentResult Invoke()
        {
            return View(PortFolioManager.TGetList());
        }
    }
}
