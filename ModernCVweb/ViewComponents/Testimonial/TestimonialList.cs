using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ModernCVweb.ViewComponents.Testimonial
{
    public class TestimonialList : ViewComponent
    {
        TestimonialManager testimonmanager = new TestimonialManager(new EfTestimonialDal());

        public IViewComponentResult Invoke()
        {
            var values = testimonmanager.TGetList();
            return View(values);
        }
    }
}
