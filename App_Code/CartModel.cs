
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CartModel
/// </summary>
public class CartModel
{
	public CartModel()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public string InsertCart(Cart cart)
    {
        try
        {
            PharmaDbEntities db = new PharmaDbEntities();
            db.Carts.Add(cart);
            db.SaveChanges();

            return "Added to cart on " + cart.DatePurchased;
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }
    public string UpdateCart(int id, Cart cart)
    {
        try
        {
            PharmaDbEntities db = new PharmaDbEntities();

            //Fetch from db
            Cart p = db.Carts.Find(id);
            p.DatePurchased = cart.DatePurchased;
            p.ClientID = cart.ClientID;
            p.Amount = cart.Amount;
            p.IsInCart = cart.IsInCart;
            p.ProductID = cart.ProductID;

            db.SaveChanges();
            return cart.DatePurchased + " was successfully updated";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }
    public string DeleteCart(int id)
    {
        try
        {
            PharmaDbEntities db = new PharmaDbEntities();
            Cart cart = db.Carts.Find(id);

            db.Carts.Attach(cart);
            db.Carts.Remove(cart);
            db.SaveChanges();

            return cart.DatePurchased + " was successfully deleted";

        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }
    public List<Cart> GetOrdersInCart(string userId) 
    { 
        PharmaDbEntities db = new PharmaDbEntities();
        List<Cart> orders = (from x in db.Carts
                                where x.ClientID == userId
                                && x.IsInCart
                                orderby x.DatePurchased
                                 select x).ToList();
        return orders;
    }
    public int GetAmountOfOrders(string userId)
    {
        try 
        {
            PharmaDbEntities db = new PharmaDbEntities();
            int amount = (from x in db.Carts
                          where x.ClientID == userId
                          && x.IsInCart
                          orderby x.DatePurchased
                          select x.Amount).Sum();
            return amount;
        }
        catch 
        {
            return 0;
        }
    }
    public void UpdateQuantity (int id, int quantity)
    {
        PharmaDbEntities db = new PharmaDbEntities();
        Cart cart = db.Carts.Find(id);
        cart.Amount = quantity;
        db.SaveChanges();
    }
    public void MarkOrdersAsPaid(List<Cart> carts)
    {
        PharmaDbEntities db = new PharmaDbEntities();

        if(carts !=null)
        {
            foreach(Cart cart in carts)
            {
                Cart oldCart = db.Carts.Find(cart.Id);
                oldCart.DatePurchased = DateTime.Now;
                oldCart.IsInCart = false;
            }
            db.SaveChanges();
        }
    }
}