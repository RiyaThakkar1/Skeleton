using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //var to store the primary key value of the session object
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the order to be deleted from the session object
        OrderID = Convert.ToInt32(Session["OrderID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create an instance of the order book class
        clsOrdersCollection OrderBook = new clsOrdersCollection();
        //find the record to delete
        OrderBook.ThisOrder.Find(OrderID);
        //delete the record
        OrderBook.Delete();
        //redirect bakc to the main page
        Response.Redirect("OrderList.aspx");
    }
}