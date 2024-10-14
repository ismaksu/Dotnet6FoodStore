using FoodStore.DataAccess.Abstract;
using FoodStore.DataAccess.Context;
using FoodStore.DataAccess.Repositories;
using FoodStore.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStore.DataAccess.EntityFramework
{
    public class EFProductDAL : GenericRepository<Product>, IProductDAL
    {
        private readonly FoodStoreContext _context;

        public EFProductDAL(FoodStoreContext context) : base(context)
        {
            _context = context;
        }

        public List<Product> ProductsWithCategories()
        {
            return _context.Products.Include(x => x.Category).ToList();
        }
    }
}
