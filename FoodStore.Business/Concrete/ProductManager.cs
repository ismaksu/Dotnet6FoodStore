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
    public class ProductManager : IProductService
    {
        private readonly IProductDAL _productDal;

        public ProductManager(IProductDAL productDal)
        {
            _productDal = productDal;
        }

        public List<Product> ProductsWithCategories()
        {
            return _productDal.ProductsWithCategories();
        }

        public void TDelete(int id)
        {
            _productDal.Delete(id);
        }

        public List<Product> TGetAll()
        {
            return _productDal.GetAll();
        }

        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }

        public void TInsert(Product entity)
        {
            _productDal.Insert(entity);
        }

        public void TUpdate(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
