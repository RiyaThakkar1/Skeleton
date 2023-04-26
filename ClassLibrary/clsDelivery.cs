using System;

namespace ClassLibrary
{
    public class clsDelivery
    {
        public int customer_id;
        public int order_id;
        public int delivery_id;
        public int order_availability;
        public bool order_confirmation;
        public DateTime order_date;

        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
    }
}