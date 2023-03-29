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
        //create a new instance of clsmarketing
        clsMarketing AnMarketing = new clsMarketing();
        //get the data from the session object 
        AnMarketing = (clsMarketing)Session["AnMarketing"];
        //disply the customer name 
        Response.Write(AnMarketing.order_id);

        Response.Write(AnMarketing.customer_id); 

        Response.Write(AnMarketing.customer_name);
        
        Response.Write(AnMarketing.order_date);

        Response.Write(AnMarketing.customer_satisfaction);
    }
}