using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje1.ViewComponents.Skill
{
    public class SkillList : ViewComponent
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal(new DataAccessLayer.Context.DataBaseContext()));
        public IViewComponentResult Invoke()
        {
            return View(skillManager.TGetList());
        }
    }
}
