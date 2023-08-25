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
    public class ServiceManager : IGenericService<Service>
    {
        IServiceDal _servicedal;

        public ServiceManager(IServiceDal servicedal)
        {
            _servicedal = servicedal;
        }

        public void TAdd(Service t)
        {
            _servicedal.Insert(t);
        }

        public void TDelete(Service t)
        {
            _servicedal.Delete(t);
        }

        public Service TGetByID(int id)
        {
            return _servicedal.GetByID(id);
        }

        public List<Service> TGetList(Service t)
        {
            return _servicedal.GetList();
        }

        public List<Service>? TGetList()
        {
            return _servicedal.GetList();
        }

        public List<Service> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Service t)
        {
           _servicedal.Update(t);
        }
    }
}
