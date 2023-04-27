using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 OrderID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the order to be processed
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (OrderID != -1)
            {
                //display the current data for the record
                DisplayOrder();
            }
        }
    }

    void DisplayOrder()
    {
        //create an instance of the order book
        clsOrdersCollection OrderBook = new clsOrdersCollection();
        //find the record to update
        OrderBook.ThisOrder.Find(OrderID);
        //display the data for this record
        txtOrderID.Text = OrderBook.ThisOrder.OrderID.ToString();
        txtOrderName.Text = OrderBook.ThisOrder.OrderName;
        txtOrderPrice.Text = OrderBook.ThisOrder.OrderPrice.ToString();
        txtOrderDate.Text = OrderBook.ThisOrder.OrderDate.ToString();
        txtCustomerID.Text = OrderBook.ThisOrder.CustomerID.ToString();

    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrders AnOrder = new clsOrders();
        //capture the OrderName
        string OrderName = txtOrderName.Text;
        //capture the OrderDate
        string OrderDate = txtOrderDate.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnOrder.Valid(OrderName, OrderDate);
        if (Error == "")
        {
            //capture the OrderName
            AnOrder.OrderName = OrderName;
            //capture the OrderDate
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            //create a new instance of the order collection
            clsOrdersCollection OrderList = new clsOrdersCollection();
            
            //if this is a new record i.e. OrderID = -1 the add the data
            if (OrderID == -1)
            {
                //set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //add the new record
                OrderList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                OrderList.ThisOrder.Find(OrderID);
                //set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //update the record
                OrderList.Update();
            }
            //redirect to the listpage
            Response.Write("OrderList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //variable to store the primary key
            Int32 OrderID;
            //variable to store the result of the find operation
            Boolean Found = false;
            //get the primary key entered by the user
            OrderID = Convert.ToInt32(txtOrderID.Text);
            //find the record
            Found = AnOrder.Find(OrderID);
            //if found
            if (Found == true)
            {
                //display the value of the properties in the form
                txtOrderName.Text = AnOrder.OrderName;
                txtOrderPrice.Text = AnOrder.OrderPrice.ToString();
                txtOrderDate.Text = AnOrder.OrderDate.ToString();
                txtCustomerID.Text = AnOrder.CustomerID.ToString();
            }
        }
    }
}

