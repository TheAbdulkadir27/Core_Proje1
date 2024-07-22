using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Context;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfSkillDal : GenericRepository<Skill>, SkillDal
    {
        public EfSkillDal(DataBaseContext databasecontext) : base(databasecontext)
        {

        }
    }
}
