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

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsmarketing
        clsMarketing AnMarketing = new clsMarketing();
        //capture the customer name
        AnMarketing.customer_name = txtCustomerName.Text;
        AnMarketing.order_id = Convert.ToInt32(txtOrderId.Text);
        AnMarketing.customer_id = Convert.ToInt32(txtCustomerId.Text);
        AnMarketing.order_date = Convert.ToDateTime(txtOrderDate.Text);
        AnMarketing.customer_satisfaction = Convert.ToBoolean(txtCustomerSatis.Text);
        AnMarketing.Active = chkActive.Checked;
        //store the custome data in the session object
        Session["AnMarketing"] = AnMarketing;
        //navigate to the viewer page
        Response.Redirect("MarketingViewer.aspx");

    }
}