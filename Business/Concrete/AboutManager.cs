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
    public class AboutManager : IAboutService
    {
        IAbout _about;

        public AboutManager(IAbout about)
        {
            _about = about;
        }

        public About GetByID(int id)
        {
           return _about.GetByID(id);
        }

        public void TAdd(About t)
        {
            _about.Insert(t);
        }

        public void TDelete(About t)
        {
            _about.Delete(t);
        }

        public List<About> TGetAll()
        {
            return _about.GetAll();
        }

        public List<About> TGetAllByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(About t)
        {
           _about.Update(t);
        }
    }
}
