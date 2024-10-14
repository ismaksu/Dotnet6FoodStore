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
    public class FeaturedManager : IFeaturedService
    {
        private readonly IFeaturedDAL _featuredDal;

        public FeaturedManager(IFeaturedDAL featuredDal)
        {
            _featuredDal = featuredDal;
        }

        public void TDelete(int id)
        {
            _featuredDal.Delete(id);
        }

        public List<Featured> TGetAll()
        {
            return _featuredDal.GetAll();
        }

        public Featured TGetById(int id)
        {
            return _featuredDal.GetById(id);
        }

        public void TInsert(Featured entity)
        {
            _featuredDal.Insert(entity);
        }

        public void TUpdate(Featured entity)
        {
            _featuredDal.Update(entity);
        }
    }
}
