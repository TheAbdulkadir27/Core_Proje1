using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje1.ViewComponents.Feature
{
    public class FeatureStatic : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using (DataBaseContext context = new DataBaseContext())
            {
                ViewBag.V1 = context.Skills.Count();
                ViewBag.V2 = context.Messages.Where(x => x.Status == false).Count();
                ViewBag.V3 = context.Messages.Where(x => x.Status == true).Count();
                ViewBag.V4 = context.Experiances.Count();
            }
            return View();
        }
    }
}
