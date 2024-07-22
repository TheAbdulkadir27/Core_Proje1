using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje1.ViewComponents.Service
{
    public class ServiceList : ViewComponent
    {
        ServiceManager ServiceManager = new ServiceManager(new EfServiceDal(new DataAccessLayer.Context.DataBaseContext()));
        public IViewComponentResult Invoke()
        {
            return View(ServiceManager.TGetList());
        }
    }
}
