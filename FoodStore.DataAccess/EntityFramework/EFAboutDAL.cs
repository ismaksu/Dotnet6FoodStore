using FoodStore.DataAccess.Abstract;
using FoodStore.DataAccess.Context;
using FoodStore.DataAccess.Repositories;
using FoodStore.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStore.DataAccess.EntityFramework
{
    public class EFAboutDAL : GenericRepository<About>,IAboutDAL
    {
        public EFAboutDAL(FoodStoreContext context) : base(context)
        {
        }
    }
}
