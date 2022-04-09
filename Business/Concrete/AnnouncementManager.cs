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
    public class AnnouncementManager : IAnnouncementService
    {
        IAnnouncement _announcement;

        public AnnouncementManager(IAnnouncement announcement)
        {
            _announcement = announcement;
        }

        public Announcement GetByID(int id)
        {
            return _announcement.GetByID(id);   
        }

        public List<Announcement> GetLastThreeAnnouncement()
        {
            return _announcement.GetAll().OrderByDescending(x=> x.Tarih).Take(3).ToList();
        }

        public void TAdd(Announcement t)
        {
            _announcement.Insert(t);
        }

        public void TDelete(Announcement t)
        {
            _announcement.Delete(t);
        }

        public List<Announcement> TGetAll()
        {
            return _announcement.GetAll();
        }

        public List<Announcement> TGetAllByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Announcement t)
        {
            _announcement.Update(t);
        }
    }
}
