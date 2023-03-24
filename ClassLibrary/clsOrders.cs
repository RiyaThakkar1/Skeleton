using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int OrderID { get; set; }
        public string OrderName { get; set; }
        public decimal OrderPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerID { get; set; }
    }
}