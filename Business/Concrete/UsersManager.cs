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
    public class UsersManager : IUsersService
    {
        IUsers _users;

        public UsersManager(IUsers users)
        {
            _users = users;
        }

        public RegisterUser GetByID(int id)
        {
            return _users.GetByID(id);  
        }

        public void TAdd(RegisterUser t)
        {
            _users.Insert(t);
        }

        public void TDelete(RegisterUser t)
        {
            _users.Delete(t);
        }

        public List<RegisterUser> TGetAll()
        {
            return _users.GetAll();
        }

        public List<RegisterUser> TGetAllByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(RegisterUser t)
        {
            _users.Update(t);
        }
    }
}
