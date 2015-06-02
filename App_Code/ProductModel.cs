﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ProductModel
{
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

    public Product GetProduct(int id)
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
    public List<Product> GetAllProducts()
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

    public List<Product> GetProductsByType(int typeId)
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
