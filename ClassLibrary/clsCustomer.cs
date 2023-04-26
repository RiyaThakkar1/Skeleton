using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public bool createAppoinment;
        public string login;

        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int CustomerNo { get; set; }
        public int CustomerId { get; set; }
        public DateTime DOB { get; set; }
        public int Payment { get; set; }
    }
}