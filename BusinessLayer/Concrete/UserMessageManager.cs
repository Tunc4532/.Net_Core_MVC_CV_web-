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
    public class UserMessageManager : IUserMessageService
    {
        IUserMessageDal _usermessaggedal;

        public UserMessageManager(IUserMessageDal usermessaggedal)
        {
            _usermessaggedal = usermessaggedal;
        }

        public List<UserMessage> GetUserMessagesWithUserService()
        {
            return _usermessaggedal.GetUserMessagesWithUser();
        }

        public void TAdd(UserMessage t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(UserMessage t)
        {
            throw new NotImplementedException();
        }

        public UserMessage TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserMessage> TGetList(UserMessage t)
        {
            return _usermessaggedal.GetList();
        }

        public List<UserMessage>? TGetList()
        {
            return _usermessaggedal.GetList();
        }

        public List<UserMessage> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(UserMessage t)
        {
            throw new NotImplementedException();
        }
    }
}
