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
    public class AddressManager : IAddressService
    {
        private readonly IAddressDAL _addressDal;

        public AddressManager(IAddressDAL addressDal)
        {
            _addressDal = addressDal;
        }

        public void TDelete(int id)
        {
            _addressDal.Delete(id);
        }

        public List<Address> TGetAll()
        {
            return _addressDal.GetAll();
        }

        public Address TGetById(int id)
        {
            return _addressDal.GetById(id);
        }

        public void TInsert(Address entity)
        {
            _addressDal.Insert(entity);
        }

        public void TUpdate(Address entity)
        {
            _addressDal.Update(entity);
        }
    }
}
