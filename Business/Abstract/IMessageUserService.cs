using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMessageUserService : IGenericService<MessageUser>
    {
        List<MessageUser> GetAllSenderMessage(string p);
        List<MessageUser> GetAllReceiverMessage(string p);
    }
}
