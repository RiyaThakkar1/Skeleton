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

        public bool Find(int product_Id)
        {
            mProduct_Id = 1;
            mProduct_Name = "CSK Jersey";
            mProduct_Description = "Long sleeve";
            mProduct_Availability = false;
            mProducct_Price = 20;
            mDateAdded = Convert.ToDateTime("31/03/2023");
            return true;
        }
    
            private Int32 mProduct_Id;

            public Int32 Product_Id
            {
                get
                {
                    return mProduct_Id;
                }
                set
                {
                    mProduct_Id = value;
                }
            }
        private DateTime mDateAdded;
        public DateTime Launch_Date
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }

        private string mProduct_Name;
        public string product_Name
        {
            get
            {
                return mProduct_Name;
            }
            set
            {
                mProduct_Name = value;
            }
        }

        private Int32 mProducct_Price;

        public Int32 producct_Price
        {
            get
            {
                return mProducct_Price;
            }
            set
            {
                mProducct_Price = value;
            }
        }
        private string mProduct_Description;
        public string product_Description
        {
            get
            {
                return mProduct_Description;
            }
            set
            {
                mProduct_Description = value;
            }
        }
        private Boolean mProduct_Availability;

        public Boolean product_Availability
        {
            get
            {
                return mProduct_Availability;
            }
            set
            {
                mProduct_Availability = value;
            }
        } 
        

    }
}

