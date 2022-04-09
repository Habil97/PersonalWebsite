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
    public class MessageManager : IMessageService
    {
        IMessage _message;

        public MessageManager(IMessage message)
        {
            _message = message;
        }

        public Message GetByID(int id)
        {
           return _message.GetByID(id);
        }

        public void TAdd(Message t)
        {
            _message.Insert(t);
        }

        public void TDelete(Message t)
        {
          _message.Delete(t);
        }

        public List<Message> TGetAll()
        {
            return _message.GetAll();
        }

        public List<Message> TGetAllByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Message t)
        {
            _message.Update(t);
        }
    }
}
