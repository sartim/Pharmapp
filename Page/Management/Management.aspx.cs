using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Page_Management_Man : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Unnamed1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        //Get sesected row
        GridViewRow row = grdProducts.Rows[e.NewEditIndex];

        //get id of sesected product
        int rowId = Convert.ToInt32(row.Cells[1].Text);

        //redirect user to ManageProducts along with the selected rowId
        Response.Redirect("~/Page/Management/ManageProducts.aspx?id" + rowId);
    }
}