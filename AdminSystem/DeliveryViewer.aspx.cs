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
        clsDelivery AnDelivery = new clsDelivery();
        //get the data from session object 
        AnDelivery = (clsDelivery)Session["AnDelivery"];
        //disply the product name for this entry 
        Response.Write(AnDelivery.customer_id);
        Response.Write(AnDelivery.order_id);
        Response.Write(AnDelivery.delivery_id);
        Response.Write(AnDelivery.delivery_description);
        Response.Write(AnDelivery.order_availability);
        Response.Write(AnDelivery.order_confirmation);
        Response.Write(AnDelivery.order_date);
    }
}