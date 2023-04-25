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
        private string mOrderName;
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
        private decimal mOrderPrice;
        public decimal OrderPrice
        {
            get
            {
                return mOrderPrice;
            }
            set
            {
                mOrderPrice = value;
            }
        }
        private DateTime mOrderDate;
        public DateTime OrderDate
        {
            get
            {
                return mOrderDate;
            }

            set
            {
                mOrderDate = value;
            }
        }
        private int mCustomerID;
        public int CustomerID
        {
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

            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the OrderID to search for
            DB.AddParameter("@OrderID", OrderID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            //if one record is found (there sould be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mOrderName = Convert.ToString(DB.DataTable.Rows[0]["OrderName"]);
                mOrderPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["OrderPrice"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                //return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string orderName, string orderPrice, string orderDate, string customerID)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable  to store date values
            DateTime DateTemp;
            //if the OrderName is blank
            if (OrderName.Length == 0)
            {
                //record the error
                Error = Error + "The OrderName may not be blank :";
            }
            //if the OrderName is greater than 15 characters
            if (OrderName.Length > 15)
            {
                //record the error
                Error = Error + "The OrderName must be less than 15 characters : ";
            }
            try
            { 
            //copy the OrderDate value to the DateTemp variable
            DateTemp = Convert.ToDateTime(OrderDate);
            if (DateTemp < DateTime.Now.Date)
            {
                //record the error
                Error = Error + "The date cannot be in the past : ";
            }
            //copy the OrderDate value to the DateTemp variable
            DateTemp = Convert.ToDateTime(OrderDate);
            if (DateTemp > DateTime.Now.Date)
            {
                //record the error
                Error = Error + "The date cannot be in the future : ";
            }
        }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }

            //return any error messages
            return Error;
        }
       
        }
}