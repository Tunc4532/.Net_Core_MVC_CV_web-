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
    public class MesWriterManager : IMesWriterService
    {
        IMesWriterMessageDal _mesWriterMessageDal;

        public MesWriterManager(IMesWriterMessageDal mesWriterMessageDal)
        {
            _mesWriterMessageDal = mesWriterMessageDal;
        }

        public List<MesWriterMessage> GetListReceiverMessage(string p)
        {
            return _mesWriterMessageDal.GetByFilter(X => X.Receiver == p);
        }

        public List<MesWriterMessage> GetListSenderMessage(string p)
        {
            return _mesWriterMessageDal.GetByFilter(X => X.Sender == p);
        }

        public void TAdd(MesWriterMessage t)
        {
           _mesWriterMessageDal.Insert(t);
        }

        public void TAdd(MesWriterManager p)
        {
            throw new NotImplementedException();
        }

        public void TDelete(MesWriterMessage t)
        {
            throw new NotImplementedException();
        }

        public MesWriterMessage TGetByID(int id)
        {
            return _mesWriterMessageDal.GetByID(id);
        }

        public List<MesWriterMessage> TGetList(MesWriterMessage t)
        {
            throw new NotImplementedException();
        }

        //public List<MesWriterMessage> TGetListbyFilter(string p)
        //{
        //    return _mesWriterMessageDal.GetByFilter(X => X.Receiver == p);
        //}

        public List<MesWriterMessage> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(MesWriterMessage t)
        {
            throw new NotImplementedException();
        }
    }
}
