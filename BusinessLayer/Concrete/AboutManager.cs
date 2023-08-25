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
    public class AboutManager : IGenericService<About>
    {
        IAboutDal _aboutdal;

        public AboutManager(IAboutDal aboutdal)
        {
            _aboutdal = aboutdal;
        }

        public void TAdd(About t)
        {
            _aboutdal.Insert(t);
        }

        public void TDelete(About t)
        {
           _aboutdal.Delete(t);
        }

        public About TGetByID(int id)
        {
            return _aboutdal.GetByID(id);
        }

        public List<About> TGetList(About t)
        {
            return _aboutdal.GetList();
        }

        public List<About>? TGetList()
        {
            return _aboutdal.GetList();
        }

        public List<About> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(About t)
        {
            _aboutdal.Update(t);
        }
    }
}
