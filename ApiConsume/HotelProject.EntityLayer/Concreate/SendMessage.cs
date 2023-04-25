using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concreate
{
    public class SendMessage
    {
        public int ID { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverMail { get; set; }
        public string SenderName { get; set; }
        public string SenderMail { get; set; }
        public string Subject { get; set; }
        public string Messages { get; set; }
        public DateTime Date { get; set; }
    }
}
