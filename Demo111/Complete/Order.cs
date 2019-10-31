using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo111
{
    public class Order
    {
        public int orderID { get; set; }
        public string TrainType { get; set; }
        public string trainCode { get; set; }
        public string startSite { get; set; }
        public string endSite { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
        public string userName { get; set; }
        public DateTime startDate { get; set; }
        public string PersonName { get; set; }
        public string IDType { get; set; }
        public string IDNum { get; set; }
        public string PhoneNum { get; set; }
        public DateTime OrderDate { get; set; }
        public string carriageNum { get; set; }
        public string seatNum { get; set; }
        public string seatType { get; set; }
        public string passengerType { get; set; }
        public decimal ticketPrice { get; set; }
        public int orderState { get; set; }
    }
}
