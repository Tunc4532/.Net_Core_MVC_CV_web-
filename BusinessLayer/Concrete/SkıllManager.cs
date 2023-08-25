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
    public class SkıllManager : IGenericService<Skill>
    {
        ISkıllDal _skıldal;

        public SkıllManager(ISkıllDal skıldal)
        {
            _skıldal = skıldal;
        }

        public void TAdd(Skill t)
        {
           _skıldal.Insert(t);
        }

        public void TDelete(Skill t)
        {
            _skıldal.Delete(t);
        }

        public Skill TGetByID(int id)
        {
            return _skıldal.GetByID(id);
        }

        public List<Skill> TGetList(Skill t)
        {
            return _skıldal.GetList();
        }

        public List<Skill>? TGetList()
        {
            return _skıldal.GetList();
        }

        public List<Skill> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Skill t)
        {
           _skıldal.Update(t);
        }
    }
}
