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

        public bool Find(int customer_id)
        {
            mcustomer_id = 12302;
            morder_id = 7;
            mcustomer_name = "Het";
            morder_date = Convert.ToDateTime("09/07/2022");
            mcustomer_satisfaction = true;
            return true;        
         
           
            
        }
        private Int32 mcustomer_id;
        public Int32 Customer_id
        {
            get
            {
                return mcustomer_id;
            }
            set
            {
                mcustomer_id = value;
            }
        }
        private DateTime morder_date;
        public DateTime Order_date
        {
            get
            {
                return morder_date;
            }
            set
            {
                morder_date = value;
            }
        }
        private Int32 morder_id;
        public Int32 Order_id
        {
            get
            {
                return morder_id;
            }
            set
            {
                morder_id = value;
            }
        }
        private String mcustomer_name;
        public String Customer_name
        {
            get
            {
                return mcustomer_name;
            }
            set
            {
                mcustomer_name = value;
            }
        }
        private Boolean mcustomer_satisfaction;
        public Boolean Customer_satisfaction
        {
            get
            {
                return mcustomer_satisfaction;
            }
            set
            {
                mcustomer_satisfaction = value;
            }
        }
       
    }


}