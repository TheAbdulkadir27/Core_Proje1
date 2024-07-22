using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje1.ViewComponents.Experiance
{
    public class ExperianceList : ViewComponent
    {
        ExperianceManager ExperianceManager = new ExperianceManager(new EfExperianceDal(new DataAccessLayer.Context.DataBaseContext()));
        public IViewComponentResult Invoke() => View(ExperianceManager.TGetList());
    }
}
