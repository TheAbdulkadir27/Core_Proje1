using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
namespace Core_Proje1.Controllers
{
    public class ExperianceController : Controller
    {
        ExperianceManager ExperianceManager = new ExperianceManager(new EfExperianceDal(new DataAccessLayer.Context.DataBaseContext()));
        public IActionResult Index()
        {
            return View(ExperianceManager.TGetList());
        }
        [HttpGet]
        public IActionResult AddExperiance()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddExperiance(Experiance experiance)
        {
            ExperianceManager.TInsert(experiance);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteExperiance(int id)
        {
            ExperianceManager.TDelete(ExperianceManager.GetByID(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateExperiance(int id)
        {
            var values = ExperianceManager.GetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateExperiance(Experiance experiance)
        {
            ExperianceManager.TUpdate(experiance);
            return RedirectToAction("Index");
        }
    }
}
