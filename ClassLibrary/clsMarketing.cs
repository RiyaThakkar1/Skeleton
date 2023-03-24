using System;

namespace ClassLibrary
{
    public class clsMarketing
    {
        public int customer_id;
        public int order_id;
        public string customer_name;
        public DateTime order_date;
        public bool customer_satisfaction;

        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
    }
}