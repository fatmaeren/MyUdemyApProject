using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concreate;
using HotelProject.DataAccessLayer.Repository;
using HotelProject.EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(Context context) : base(context)
        {
        }

        public void BookinStatusChangeApproved(Booking booking)
        {
            var context= new Context();
            var value= context.Bookings.Where(z=>z.ID==booking.ID).FirstOrDefault();
            value.Status = "Onaylandı";
            context.SaveChanges();
        }
    }
}
