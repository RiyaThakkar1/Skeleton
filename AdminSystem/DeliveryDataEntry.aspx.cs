using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1_DataEntry : System.Web.UI.Page
{
    private object txtcustomer_id;

    protected void Page_Load(object sender, EventArgs e)
    {
        /*
        //create a new instance clsCusotmer
        clsDelivery AnDelivery = new clsDelivery();
        //get the data from the session object 
        AnDelivery = (clsDelivery)Session["AnDelivery"];
        //display the house number for the entry 
        Response.Write(AnDelivery.customer_id);
        */
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //create a new instance of claCustomer
        clsDelivery AnDelivery = new clsDelivery();
        //capture the house no
        AnDelivery.customer_id = Convert.ToInt32(Txtcustomer_id.Text);
        //store the address in the session object 
        Session["AnDelivery"] = AnDelivery;
        //navigate to the viewer page 
        Response.Redirect("DeliveryViewer.aspx");
    }

    protected void btncancel_Click(object sender, EventArgs e)
    {
        //create a new instance of claCustomer
        clsDelivery AnDelivery = new clsDelivery();
        //capture the house no
        AnDelivery.customer_id = Convert.ToInt32(Txtcustomer_id.Text);
        AnDelivery.order_id = Convert.ToInt32(Txtorder_id.Text);
        AnDelivery.delivery_id = Convert.ToInt32(Txtdelivery_id.Text);
        AnDelivery.delivery_description = Txtdelivery_id.Text.ToString();
        AnDelivery.order_availability = Convert.ToInt32(Txtorder_availability.Text);
        AnDelivery.order_confirmation = Convert.ToBoolean(Txtorder_confirmation.Text);
        AnDelivery.order_date = Convert.ToDateTime(Txtorder_date.Text);

       




        //store the address in the session object 
        Session["AnDelivery"] = AnDelivery;
        //navigate to the viewer page
        Response.Redirect("DeliveryViewer.aspx");
    }
}


   