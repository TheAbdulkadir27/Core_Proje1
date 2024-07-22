using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje1.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager FeatureManager = new FeatureManager(new EfFeatureDal(new DataAccessLayer.Context.DataBaseContext()));

        [HttpGet]
        public IActionResult Index()
        {
            return View(FeatureManager.GetByID(1));
        }


        [HttpPost]
        public IActionResult Index(Feature feature)
        {
            FeatureManager.TUpdate(feature);
            return RedirectToAction("Index", "Default");
        }
    }
}
