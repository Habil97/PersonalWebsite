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
    public class MessageUserManager : IMessageUserService
    {
        IMessageUser _messageUser;


        public MessageUserManager(IMessageUser messageUser)
        {
            _messageUser = messageUser;
        }

        public List<MessageUser> GetAllReceiverMessage(string p)
        {
            return _messageUser.GetByFilter(x => x.Receiver == p);
        }

        public List<MessageUser> GetAllSenderMessage(string p)
        {
            return _messageUser.GetByFilter(x => x.Sender == p);
        }

        public MessageUser GetByID(int id)
        {
           return _messageUser.GetByID(id); 
        }

        public void TAdd(MessageUser t)
        {
            _messageUser.Insert(t);
        }

        public void TDelete(MessageUser t)
        {
            _messageUser.Delete(t);
        }

        public List<MessageUser> TGetAll()
        {
            return _messageUser.GetAll();
        }

        public List<MessageUser> TGetAllByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(MessageUser t)
        {
            _messageUser.Update(t);
        }
    }
}
