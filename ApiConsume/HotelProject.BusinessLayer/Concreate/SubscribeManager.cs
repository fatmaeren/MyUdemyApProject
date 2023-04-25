using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concreate
{
    public class SubscribeManager : ISubscribeService
    {
        private readonly ISubscribesDal _subscribersDal;

        public SubscribeManager(ISubscribesDal subscribersDal)
        {
            _subscribersDal = subscribersDal;
        }

        public void TDelete(Subscribe t)
        {
            _subscribersDal.Delete(t);
        }

        public Subscribe TGetById(int id)
        {
            return _subscribersDal.GetById(id);
        }

        public List<Subscribe> TGetList()
        {
            return _subscribersDal.GetList();
        }

        public void TInsert(Subscribe t)
        {
            _subscribersDal.Insert(t);
        }

        public void TUpdate(Subscribe t)
        {
            _subscribersDal.Update(t);
        }
    }
}
