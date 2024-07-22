using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje1.ViewComponents.Feature
{
    public class ProjectList : ViewComponent
    {
        PortFolioManager PortFolioManager = new PortFolioManager(new EfPortFolioDal(new DataAccessLayer.Context.DataBaseContext()));
        public IViewComponentResult Invoke() => View(PortFolioManager.TGetList());
    }
}
