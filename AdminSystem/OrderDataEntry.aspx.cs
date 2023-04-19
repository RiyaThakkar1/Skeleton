using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrders
        clsOrders AnOrder = new clsOrders();
        //capture the OrderName
        AnOrder.OrderName = txtOrderName.Text;
        //store the order in the session object
        Session["AnOrder"] = AnOrder;
        //navigate to the viewer panner
        Response.Redirect("OrderViewer.aspx");
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
