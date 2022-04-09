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
    public class ServiceManager : IServiceService
    {
        IService _service;

        public ServiceManager(IService service)
        {
            _service = service;
        }

        public Service GetByID(int id)
        {
          return _service.GetByID(id);
        }

        public void TAdd(Service t)
        {
            _service.Insert(t);
        }

        public void TDelete(Service t)
        {
            _service.Delete(t);
        }

        public List<Service> TGetAll()
        {
            return _service.GetAll();
        }

        public List<Service> TGetAllByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Service t)
        {
            _service.Update(t);
        }
    }
}
