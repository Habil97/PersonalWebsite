using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SkillManager : ISkillService
    {
        ISkill _skill;

        public SkillManager(ISkill skill)
        {
            _skill = skill;
        }

        public Skill GetByID(int id)
        {
            return _skill.GetByID(id);
        }

        public void TAdd(Skill t)
        {
            _skill.Insert(t);
        }

        public void TDelete(Skill t)
        {
           _skill.Delete(t);
        }

        public List<Skill> TGetAll()
        {
           return _skill.GetAll();
        }

        public List<Skill> TGetAllByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Skill t)
        {
            _skill.Update(t);
        }
    }
}
