using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _mesagedal;

        public MessageManager(IMessageDal mesagedal)
        {
            _mesagedal = mesagedal;
        }

        public void TAdd(Message t)
        {
            _mesagedal.Insert(t);
        }

        public void TDelete(Message t)
        {
            _mesagedal.Delete(t);
        }

        public Message TGetByID(int id)
        {
            return _mesagedal.GetByID(id);
        }

        public List<Message> TGetList(Message t)
        {
            return _mesagedal.GetList();
                /* new List<Message>();*/
        }

        public List<Message>? TGetList()
        {
            return _mesagedal.GetList();
        }

        public List<Message> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Message t)
        {
            throw new NotImplementedException();
        }
    }
}
