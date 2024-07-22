using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje1.ViewComponents.TestiMonial
{
    public class TestiMonialList : ViewComponent
    {
        TestiMonialsManager TestiMonialsManager = new TestiMonialsManager(new EfTestiMonialsDal(new DataAccessLayer.Context.DataBaseContext()));
        public IViewComponentResult Invoke() => View(TestiMonialsManager.TGetList());
    }
}
