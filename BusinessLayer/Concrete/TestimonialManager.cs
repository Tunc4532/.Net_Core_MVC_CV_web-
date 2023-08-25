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
    public class TestimonialManager : IGenericService<Testimonial>
    {
        ITestimonialDal _testmondal;

        public TestimonialManager(ITestimonialDal testmondal)
        {
            _testmondal = testmondal;
        }

        public void TAdd(Testimonial t)
        {
            _testmondal.Insert(t);
        }

        public void TDelete(Testimonial t)
        {
           _testmondal.Delete(t);
        }

        public Testimonial TGetByID(int id)
        {
           return _testmondal.GetByID(id);
        }

        public List<Testimonial> TGetList(Testimonial t)
        {
            return _testmondal.GetList();
        }

        public List<Testimonial>? TGetList()
        {
            return _testmondal.GetList();
        }

        public List<Testimonial> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Testimonial t)
        {
            _testmondal.Update(t);
        }
    }
}
