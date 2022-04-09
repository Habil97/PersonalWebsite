using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        ITestimonial _testimonial;

        public TestimonialManager(ITestimonial testimonial)
        {
            _testimonial = testimonial;
        }

        public Testimonial GetByID(int id)
        {
            return _testimonial.GetByID(id);
        }

        public void TAdd(Testimonial t)
        {
            _testimonial.Insert(t);
        }

        public void TDelete(Testimonial t)
        {
            _testimonial.Delete(t);
        }

        public List<Testimonial> TGetAll()
        {
            return _testimonial.GetAll();
        }

        public List<Testimonial> TGetAllByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Testimonial t)
        {
            _testimonial.Update(t);
        }
    }
}
