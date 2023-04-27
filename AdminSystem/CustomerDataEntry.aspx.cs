using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 CustomerId;
    private object txtCreateAppoinment;
    private object lblError;

    protected void Page_Load(object sender, EventArgs e)
    {
        

    }



    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of claCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //capture the house no
        AnCustomer.CustomerNo = Convert.ToInt32(txtCustomerNo.Text);
        AnCustomer.CustomerId = Convert.ToInt32(txtCustomerId.Text);
        AnCustomer.createAppoinment = Convert.ToBoolean(txtCreateAppointment.Text);
        AnCustomer.login = txtLogin.Text;
        AnCustomer.DOB = Convert.ToDateTime(txtDOB.Text);
        AnCustomer.Payment = Convert.ToInt32(txtPayment.Text);

        //store the address in the session object 
        Session["AnCustomer"] = AnCustomer;
        //navigate to the viewer page
        Response.Redirect("CustomerViewer.aspx");
    }
}



