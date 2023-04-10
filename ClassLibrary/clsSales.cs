using System;

namespace ClassLibrary
{
    public class clsSales
    {
        public bool Active { get; set; }
        public string CustomerFirstName { get; set; }
        public DateTime CustomerDOB { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerEmailID { get; set; }
        public string CustomerContactNumber { get; set; }
        public string OrderID { get; set; }
        public string OrderQuantity { get; set; }
        public string OrderDescription { get; set; }
    }
}