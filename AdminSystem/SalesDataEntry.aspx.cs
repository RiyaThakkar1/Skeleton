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
        //Create a new instance of clsSales
        clsSales AnSales = new clsSales();

        //Capture the Customer ID
        AnSales.CustomerID = txtCustomerID.Text;
        //Store the Customer ID in the session Object
        Session["AnSales"] = AnSales;

        //Capture the Customer First Name 
        AnSales.CustomerFirstName = txtCustomerFirstName.Text;
        //Store the Customer First Name in the session Object 
        Session["AnSales"] = AnSales;

        //Capture the Customer Last Name 
        AnSales.CustomerLastName = txtCustomerLastName.Text;
        //Store the Customer Last Name in the session object
        Session["AnSales"] = AnSales;

        //Capture the customer Date of Birth 
        AnSales.CustomerDOB = Convert.ToDateTime(txtCustomerDOB.Text);
        //Store the Customer Date of Birth in the Session Object 
        Session["AnSales"] = AnSales;

        //Capture the Customer Email ID
        AnSales.CustomerEmailID = txtCustomerEmailID.Text;
        //Store the Customer Email ID in the session object
        Session["AnSales"] = AnSales;

        //Capture the Customer contact number 
        AnSales.CustomerContactNumber =txtCustomerContactNumber.Text;
        //Store the Customer Contact Number in the Session Objecr 
        Session["AnSales"] = AnSales;

        //Capture the Order ID
        AnSales.OrderID = txtOrderID.Text;
        //Store the Order ID in the session object 
        Session["AnSales"] = AnSales;

        //Capture the Order Quantity 
        AnSales.OrderQuantity = txtOrderQuantity.Text;
        //Store the Order Quantity in the Session Object 
        Session["AnSales"] = AnSales;

        //Captrue the Order Quantity
        AnSales.OrderDescription = txtOrderDescription.Text;
        //Store the Order Description in the Session Object 
        Session["AnSales"] = AnSales;

        //Navigate to the viewer page
        Response.Redirect("SalesViewer.aspx");
    }
    
}

internal class txtCustomerDOB
{
    public static DateTime Text { get; internal set; }
}