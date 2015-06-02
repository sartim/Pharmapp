using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductModel
/// </summary>
public class ProductModel
{
    public ProductModel()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public string InsertProduct(Product product)
    {
        try
        {
            PharmaDbEntities db = new PharmaDbEntities();
            db.Products.Add(product);
            db.SaveChanges();
            return product.Name + " was successfully inserted";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }
    public string UpdateProduct(int id, Product product)
    {
        try
        {
            PharmaDbEntities db = new PharmaDbEntities();

            //Fetch from db
            Product p = db.Products.Find(id);
            p.Name = product.Name;
            p.Price = product.Price;
            p.TypeId = product.TypeId;
            p.Description = product.Description;
            p.Image = product.Image;

            db.SaveChanges();
            return product.Name + " was successfully updated";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }
    public string DeleteProduct(int id)
    {
        try
        {
            PharmaDbEntities db = new PharmaDbEntities();
            Product product = db.Products.Find(id);

            db.Products.Attach(product);
            db.Products.Remove(product);
            db.SaveChanges();

            return product.Name + " was successfully deleted";

        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }

    private Product GetProduct(int id)
    {
        try
        {
            using (PharmaDbEntities db = new PharmaDbEntities())
            {
                Product product = db.Products.Find(id);
                return product;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }
    private List<Product> GetAllProducts()
        {
            try 
            { 
                using (PharmaDbEntities db = new PharmaDbEntities())
                {
                    List<Product> products = (from x in db.Products select x).ToList();
                    return products;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        
        private List<Product> GetProductsByType(int typeId)
        {
            try
            {
                using (PharmaDbEntities db = new PharmaDbEntities())
                {
                    List<Product> products = (from x in db.Products where x.TypeId == typeId select x).ToList();
                    return products;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
}