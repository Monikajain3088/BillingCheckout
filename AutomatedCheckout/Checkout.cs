using System;
using System.Collections.Generic;
using System.Linq;

namespace AutomatedCheckout
{
    public class Checkout: ICheckout
    {
        private List<Cart> cart;
        public Checkout()
        {
            cart = new List<Cart>();
        }

        // Method to add items without weight
        public void AddItem(int itemId)
        {
            int increment = 1;
            AddUpdateItem(itemId, increment);
           
        }
        // method to add items with weight
        public void AddItem(int itemId, double weight)
        {
            AddUpdateItem(itemId, weight);
        }

        // Calculate sum with offers
        public double Sum()
        {
            Offer.ApplyOffers(cart);
            // Calculate sum of items
            return cart.Sum(x => x.Amount);
        }
        // Method to Add or Update item into card during checkout
        private void AddUpdateItem(int itemId, double qty)
        {
            try
            {
                // if item exist in cart then update into cart list by adding quantity
                if (cart.Any(y => y.ItemId == itemId))
                    cart.Where(w => w.ItemId == itemId).FirstOrDefault(i => { i.Quantity = i.Quantity + qty; return true; });
                else // add new item in cart
                    cart.Add(new Cart() { ItemId = itemId, Quantity = qty });
            }
            catch(Exception ex)
            {

            }
        }

    }

    //Class for Items entered during the checkout
    public class Cart
    {
        public int ItemId;
        public Double Quantity;
        public double Amount;
    }
}
