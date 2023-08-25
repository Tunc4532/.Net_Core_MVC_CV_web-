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
    public class ExperienceManager : IGenericService<Experience>
    {
        IExperienceDal _experieencedal;

        public ExperienceManager(IExperienceDal experieencedal)
        {
            _experieencedal = experieencedal;
        }

        public void TAdd(Experience t)
        {
            _experieencedal.Insert(t);
        }

        public void TDelete(Experience t)
        {
           _experieencedal.Delete(t);
        }

        public Experience TGetByID(int id)
        {
           return _experieencedal.GetByID(id);
        }

        public List<Experience> TGetList(Experience t)
        {
            return _experieencedal.GetList();
        }

        public List<Experience>? TGetList()
        {
            return _experieencedal.GetList();
        }

        public List<Experience> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Experience t)
        {
           _experieencedal.Update(t);
        }
    }
}
