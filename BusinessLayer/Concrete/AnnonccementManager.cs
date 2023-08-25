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
    public class AnnonccementManager : IAnnonccementService
    {
        IAnnouncumentDal _announcumentDal;

        public AnnonccementManager(IAnnouncumentDal announcumentDal)
        {
            _announcumentDal = announcumentDal;
        }

        public void TAdd(Annonccement t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Annonccement t)
        {
            throw new NotImplementedException();
        }

        public Annonccement TGetByID(int id)
        {
            return _announcumentDal.GetByID(id);
        }

        public List<Annonccement> TGetList(Annonccement t)
        {
            return _announcumentDal.GetList();
        }

        public object TGetList()
        {
            return _announcumentDal.GetList();
        }

        public List<Annonccement> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Annonccement t)
        {
            throw new NotImplementedException();
        }
    }
}
