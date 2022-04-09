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
    public class InformationManager : IInformationService
    {
        IInformation _information;

        public InformationManager(IInformation information)
        {
            _information = information;
        }

        public Information GetByID(int id)
        {
           return _information.GetByID(id);
        }

        public void TAdd(Information t)
        {
            _information.Insert(t);
        }

        public void TDelete(Information t)
        {
            _information.Delete(t);
        }

        public List<Information> TGetAll()
        {
            return _information.GetAll();
        }

        public List<Information> TGetAllByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Information t)
        {
            _information.Update(t);
        }
    }
}
