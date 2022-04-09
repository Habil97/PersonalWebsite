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
    public class ExperienceManager : IExperienceService
    {
        IExperience _experience;

        public ExperienceManager(IExperience experience)
        {
            _experience = experience;
        }

        public Experience GetByID(int id)
        {
            return _experience.GetByID(id);
        }

        public void TAdd(Experience t)
        {
            _experience.Insert(t);
        }

        public void TDelete(Experience t)
        {
           _experience.Delete(t);
        }

        public List<Experience> TGetAll()
        {
           return _experience.GetAll();
        }

        public List<Experience> TGetAllByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Experience t)
        {
           _experience.Update(t);
        }
    }
}
