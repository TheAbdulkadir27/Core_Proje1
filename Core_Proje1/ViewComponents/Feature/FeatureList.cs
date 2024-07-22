using BusinessLayer.Concrete;
using DataAccessLayer.Context;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje1.ViewComponents.Feature
{
    public class FeatureList : ViewComponent
    {
        FeatureManager FeatureManager = new FeatureManager(new EfFeatureDal(new DataBaseContext()));
        public IViewComponentResult Invoke()
        {
            return View(FeatureManager.TGetList());
        }
    }
}
