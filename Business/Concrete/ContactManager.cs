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
    public class ContactManager : IContactService
    {
        IContact _contact;

        public ContactManager(IContact contact)
        {
            _contact = contact;
        }

        public Contact GetByID(int id)
        {
           return _contact.GetByID(id); 
        }

        public void TAdd(Contact t)
        {
            _contact.Insert(t);
        }

        public void TDelete(Contact t)
        {
           _contact.Delete(t);
        }

        public List<Contact> TGetAll()
        {
            return _contact.GetAll();
        }

        public List<Contact> TGetAllByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Contact t)
        {
           _contact.Update(t);
        }
    }
}
