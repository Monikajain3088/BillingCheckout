using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomatedCheckout
{
    // Class to calculate offer
    public class Offer
    {
        // Method to apply offers
        public static void ApplyOffers(List<Cart> cart)
        {
            if (cart.Any(o => o.ItemId == Constant.CoffeeID)) // if cart item is coffee
            { 
                Calculate(Constant.CoffeeID, Constant.offerCoffeeQty, Constant.OfferCoffeePrice, cart);
            }
            if(cart.Any(o=>o.ItemId == Constant.ToothPasteID)) // if cart item is toothpaste
            {
                Calculate(Constant.ToothPasteID, Constant.offerTPQty, Constant.OfferTPPrice, cart);
            }
            ApplyOtherOffer(cart); 
        }
        // apply other offer
        private static void ApplyOtherOffer(List<Cart> cart)
        {
            cart.Where(w => (w.ItemId != Constant.CoffeeID && w.ItemId != Constant.ToothPasteID && w.ItemId != Constant.AppelID)).ToList()
            .ForEach(i => i.Amount = Products.items.ContainsKey(i.ItemId) ? Products.items[i.ItemId].Price * i.Quantity : 0.0);

            if (cart.Sum(i => i.Amount) >= Constant.offerAmt)
                cart.Where(w => w.ItemId == Constant.AppelID).FirstOrDefault(i => { i.Amount = i.Quantity * Constant.OfferAppelPrice; return true; });
            else
                cart.Where(w => w.ItemId == Constant.AppelID).FirstOrDefault(i => { i.Amount = i.Quantity * Products.items[Constant.AppelID].Price; return true; });
        }
        // method to find specific item count in cart, modulas, division, price
        private static void Calculate(int productId, int offerQty, double offerPrice, List<Cart> cart)
        {
            int itemCount = (int)cart.Where(o => o.ItemId == productId).Select(x => x.Quantity).FirstOrDefault();
            int div = itemCount / offerQty; //quotient 
            int mod = itemCount % offerQty; //remainder            
            cart.Where(w => w.ItemId == productId).FirstOrDefault(i => { i.Amount = Products.items[productId].Price * mod + offerPrice * div; return true; });
        }
    }
}
