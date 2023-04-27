using System;
using ClassLibrary;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrdersCollection
    {
        //private data member for the list
        List<clsOrders> mOrderList = new List<clsOrders>();
        //private data member thisOrder
        clsOrders mThisOrder = new clsOrders();

        //public property for the Order List
        public List<clsOrders> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }
            set
            {
                //we shall worry abou this later
            }
        }
        public clsOrders ThisOrder 
        {
            get
            {
                //return the private data
                return mThisOrder;
            }
            set
            {
                //set the private data
                mThisOrder = value;
            } 
        }

       //constructor for class
        public clsOrdersCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank order
                clsOrders AnOrder = new clsOrders();
                //read in the fields from the current record
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.OrderName = Convert.ToString(DB.DataTable.Rows[Index]["OrderName"]);
                AnOrder.OrderPrice =Convert.ToDecimal(DB.DataTable.Rows[Index]["OrderPrice"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                //add the record to the private data member
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of ThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("OrderName", mThisOrder.OrderName);
            DB.AddParameter("OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("OrderPrice", mThisOrder.OrderPrice);
            DB.AddParameter("CustomerID", mThisOrder.CustomerID);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrders_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of this order
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("OrderID", mThisOrder.OrderID);
            DB.AddParameter("OrderName", mThisOrder.OrderName);
            DB.AddParameter("OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("OrderPrice", mThisOrder.OrderPrice);
            DB.AddParameter("CustomerID", mThisOrder.CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by ThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_Delete");
        }
    }
}