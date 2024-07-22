using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
namespace Core_Proje1.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal(new DataAccessLayer.Context.DataBaseContext()));
        public IActionResult Index()
        {
        
            return View(serviceManager.TGetList());
        }
        public IActionResult DeleteService(int id)
        {
            serviceManager.TDelete(serviceManager.GetByID(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            return View(serviceManager.GetByID(id));
        }
        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
            serviceManager.TUpdate(service);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddService()
        { 
            return View();
        }

        [HttpPost]
        public IActionResult AddService(Service service)
        {
            serviceManager.TInsert(service);
            return RedirectToAction("Index");
        }
    }
}
