using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Create a new instance of clsAddress
        clsSales AnSales = new clsSales();

        //get the data from the session object 
        AnSales = (clsSales)Session["AnSales"];
        //Display the order ID for this entry 
        Response.Write(AnSales.CustomerID);

        //get the data from the session object 
        AnSales = (clsSales)Session["AnSales"];
        //Display the Customer First Name for this enty 
        Response.Write(AnSales.CustomerFirstName);

        //get the data from the session Object 
        AnSales = (clsSales)Session["AnSales"];
        //Display the Customer Last name for thie entry 
        Response.Write(AnSales.CustomerLastName);

        //get the data from the session object 
        AnSales = (clsSales)Session["AnSales"];
        //Display the Customer Date of Birth for this entry 
        Response.Write(AnSales.CustomerDOB);

        //get the data from the session object 
        AnSales = (clsSales)Session["AnSales"];
        //Display the Customer Email ID for this entry 
        Response.Write(AnSales.CustomerEmailID);

        //get the data from the session object 
        AnSales = (clsSales)Session["AnSales"];
        //Disaply the Customer Contact Number 
        Response.Write(AnSales.CustomerContactNumber);

        //Get the data from the session object 
        AnSales = (clsSales)Session["AnSales"];
        //Display the Order ID for this entry 
        Response.Write(AnSales.OrderID);

        //get the data from the session object 
        AnSales = (clsSales)Session["AnSales"];
        //Display the Order Quantity for this entry 
        Response.Write(AnSales.OrderQuantity);

        //get the data from the session object 
        AnSales = (clsSales)Session["AnSales"];
        //Display the Order Description for this entry 
        Response.Write(AnSales.OrderDescription);
    }
}