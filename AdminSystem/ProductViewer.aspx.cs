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


        //create a new instance of clsProduct
        clsProduct AnProduct = new clsProduct();

        //get the data from session object 
        AnProduct = (clsProduct)Session["AnProduct"];
        //disply the product name for this entry 
        Response.Write(AnProduct.Product_Id);
        //disply the product name for this entry 
        Response.Write(AnProduct.Product_Name);
        //disply the product name for this entry 
        Response.Write(AnProduct.Producct_Price);
        //disply the product name for this entry 
        Response.Write(AnProduct.Product_Description);
        //disply the product name for this entry 
        Response.Write(AnProduct.Launch_Date);
        //disply the product name for this entry 
        Response.Write(AnProduct.Product_Availability); 
        
    }
    
}