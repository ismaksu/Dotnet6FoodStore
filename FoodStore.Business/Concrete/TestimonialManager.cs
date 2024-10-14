using FoodStore.Business.Abstract;
using FoodStore.DataAccess.Abstract;
using FoodStore.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStore.Business.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDAL _testimonialDal;

        public TestimonialManager(ITestimonialDAL testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void TDelete(int id)
        {
            _testimonialDal.Delete(id);
        }

        public List<Testimonial> TGetAll()
        {
            return _testimonialDal.GetAll();
        }

        public Testimonial TGetById(int id)
        {
            return _testimonialDal.GetById(id);
        }

        public void TInsert(Testimonial entity)
        {
            _testimonialDal.Insert(entity);
        }

        public void TUpdate(Testimonial entity)
        {
            _testimonialDal.Update(entity);
        }
    }
}
