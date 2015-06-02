using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Page_Management_ManageProductTypes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        ProductTypeModel model = new ProductTypeModel();
        ProductType pt = CreateProductType();
        lblResult.Text = model.InsertProductType(pt);
    }
    private ProductType CreateProductType()
    {
        ProductType p = new ProductType();
        p.Name = txtName.Text;
        return p;
    }
}