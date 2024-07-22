using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class SkillManager : ISkillService
    {
        private readonly SkillDal _skillDal;
        public SkillManager(SkillDal skillDal)
        {
            _skillDal = skillDal;
        }
        public Skill GetByID(int id)
        {
            return _skillDal.GetByID(id);
        }

        public void TDelete(Skill entity)
        {
            _skillDal.Delete(entity);
        }

        public List<Skill> TGetList()
        {
            return _skillDal.GetAll();
        }

        public List<Skill> TGetListByFilter(Expression<Func<Skill, bool>> filter)
        {
            return _skillDal.GetByFilter(filter);
        }

        public void TInsert(Skill entity)
        {
            _skillDal.Insert(entity);
        }

        public void TUpdate(Skill entity)
        {
            _skillDal.Update(entity);
        }
    }
}
