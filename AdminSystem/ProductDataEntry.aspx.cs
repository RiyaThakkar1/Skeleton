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
    protected void Button1_Click(object sender, EventArgs e)
    {

        //create a new instance of clsProduct
        clsProduct AnProduct = new clsProduct();
        //caputre the house number
        AnProduct.Product_ID = Convert.ToInt32(txtProductID.Text);
        AnProduct.Product_Name = txtProductName.Text;
        AnProduct.Producct_Price = Convert.ToInt32(txtProductPrice.Text);
        //AnProduct.Producct_Price = Convert.ToDouble(txtProductPrice.Text);
        //AnProduct.Producct_Price = Convert.ToDecimal(txtProductPrice.Text);
        AnProduct.Product_Description = txtProductDecription.Text;
        AnProduct.Launch_Data = Convert.ToDateTime(txtLaunchData.Text);
        //AnProduct.DateAdded = Convert.ToDateTime(txtLaunchData.Text);
        AnProduct.Product_Availability = Convert.ToBoolean(txtProductAvailability.Text);
        AnProduct.Active = chkActive.Checked;
        //store the product in the session object 
        Session["AnProduct"] = AnProduct;
        //navigate to tge viewer page 
        Response.Redirect("ProductViewer.aspx");
    }

}

