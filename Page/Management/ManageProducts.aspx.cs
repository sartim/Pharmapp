using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Page_Management_ManageProducts : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GetImages();

            if(!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                FillPage(id);
            }
        }
            
    }

    private void FillPage(int id)
    {
        //Get selected product from DB
        ProductModel productModel = new ProductModel();
        Product product = productModel.GetProduct(id);

        //Fill Textboxes
        txtDescription.Text = product.Description;
        txtName.Text = product.Name;
        txtPrice.Text = product.Price.ToString();

        //Set dropdownlist values
        ddListImage.SelectedValue = product.Image;
        ddListType.SelectedValue = product.TypeId.ToString();

    }
   private void GetImages()
        {
            try 
            { 
                //Get all filepaths
                string[] images = Directory.GetFiles(Server.MapPath("~/Images/Products/"));

                //Get all filenames and add them to an arraylist
                ArrayList imageList = new ArrayList();
                foreach (string image in images)
                {
                    string imageName = image.Substring(image.LastIndexOf(@"\", StringComparison.Ordinal) + 1);
                    imageList.Add(imageName);
                }

                //Set the array  List as the dropdownview's datasource and refresh
                ddListImage.DataSource = imageList;
                ddListImage.AppendDataBoundItems = true;
                ddListImage.DataBind();
            }
            catch (Exception e)
            {
                lblResult.Text = e.ToString();
            }
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            
            ProductModel productModel = new ProductModel();
            Product product = CreateProduct();

            //Check if the url contains an id parameter
            if(!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                //ID exists -> Update existing row
                int id = Convert.ToInt32(Request.QueryString["id"]);
                lblResult.Text = productModel.UpdateProduct(id, product);
            }
            else
            {
                //ID does not exist -> Create a new row
                lblResult.Text = productModel.InsertProduct(product);
            }
          
        }

        private Product CreateProduct()
        {
            Product product = new Product();

            product.Name = txtName.Text;
            product.Price = Convert.ToInt32(txtPrice.Text);
            product.TypeId = Convert.ToInt32(ddListType.SelectedValue);
            product.Description = txtDescription.Text;
            product.Image = ddListImage.SelectedValue;
            return product;
        }
    }

