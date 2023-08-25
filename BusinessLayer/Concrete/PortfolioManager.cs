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
    public class PortfolioManager : IGenericService<Portfolio>
    {
        IPortfolioDal _portfolıodal;

        public PortfolioManager(IPortfolioDal portfolıodal)
        {
            _portfolıodal = portfolıodal;
        }

        public void TAdd(Portfolio t)
        {
            _portfolıodal.Insert(t);
        }

        public void TDelete(Portfolio t)
        {
            _portfolıodal.Delete(t);
        }

        public Portfolio TGetByID(int id)
        {
            return _portfolıodal.GetByID(id);
        }

        public List<Portfolio> TGetList(Portfolio t)
        {
            return _portfolıodal.GetList();
        }

        public List<Portfolio>? TGetList()
        {
            return _portfolıodal.GetList();
        }

        public List<Portfolio> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Portfolio t)
        {
            _portfolıodal.Update(t);
        }
    }
}
