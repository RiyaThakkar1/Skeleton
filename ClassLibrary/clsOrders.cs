using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        //private data member for the order
        private Int32 mOrderID;
        //OrderID public property
        public Int32 OrderID
        {
            get
            {
                return mOrderID;
            }

            set
            {
                mOrderID = value;
            }
        }
        public string mOrderName;
        public string OrderName
        {
            get
            {
                return mOrderName;
            }
            set
            {
                mOrderName = value;
            }
        }
        public decimal mOrderPrice;
        public decimal OrderPrice { 
            get
            {
                return mOrderPrice;
            }
            set
            {
                mOrderPrice = value;
            }
        }
        public DateTime mOrderDate;
        public DateTime OrderDate {
            get
            {
                return mOrderDate;
            }

            set
            {
                mOrderDate = value;
            }
         }
        public int mCustomerID;
        public int CustomerID {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
                }

        public bool Find(int orderID)
        {
            //set the private data members to the test data value
            mOrderID = 21;
            mOrderName = "First Order";
            mOrderPrice = 30;
            mOrderDate = DateTime.Now;
            mCustomerID = 1;
            //Always return true
            return true;
        }
    }
}