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
    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMedia _socialmedia;

        public SocialMediaManager(ISocialMedia socialmedia)
        {
            _socialmedia = socialmedia;
        }

        public SocialMedia GetByID(int id)
        {
           return _socialmedia.GetByID(id);
        }

        public void TAdd(SocialMedia t)
        {
          _socialmedia.Insert(t);
        }

        public void TDelete(SocialMedia t)
        {
            _socialmedia.Delete(t);
        }

        public List<SocialMedia> TGetAll()
        {
            return _socialmedia.GetAll();
        }

        public List<SocialMedia> TGetAllByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(SocialMedia t)
        {
            _socialmedia.Update(t);
        }
    }
}
