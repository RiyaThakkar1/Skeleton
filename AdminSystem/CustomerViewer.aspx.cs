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
        clsCustomer AnCustomer = new clsCustomer();

        //get the data from session object 
        AnCustomer = (clsCustomer)Session["AnCustomer"];
        //disply the product name for this entry 
        Response.Write(AnCustomer.CustomerId);
        Response.Write(AnCustomer.CustomerNo);
        Response.Write(AnCustomer.createAppoinment);
        Response.Write(AnCustomer.login);
        Response.Write(AnCustomer.DOB);
        Response.Write(AnCustomer.Payment);
    }
}