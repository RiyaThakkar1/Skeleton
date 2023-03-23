using System;

namespace ClassLibrary
{
    public class clsProduct
    {
        public DateTime DateAdded { get; set; }
        public int Product_ID { get; set; }
        public string Product_Name { get; set; }
        public string Product_Description { get; set; }
        public int Producct_Price { get; set; }
        public DateTime Launch_Data { get; set; }
        public bool Product_Availability { get; set; }
        public bool Active { get; set; }
    }
}