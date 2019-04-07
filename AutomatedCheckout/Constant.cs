using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomatedCheckout
{
    public class Constant
    {
        public static int CoffeeID = Products.items.FirstOrDefault(x => x.Value.Name == "Coffee").Key; // Coffee Id - 4
        public static int ToothPasteID = Products.items.FirstOrDefault(x => x.Value.Name == "Toothpaste").Key; // ToothPasteId - 1
        public static int AppelID = Products.items.FirstOrDefault(x => x.Value.Name == "Appels").Key; // Appel - 1 
        // Coffee offer
        public static int offerCoffeeQty = 2;
        public static double OfferCoffeePrice = 40;
        //Toothpaste Offer
        public static int offerTPQty = 3;
        public static double OfferTPPrice = Products.items[Constant.ToothPasteID].Price * 2;
        // Appel Offer
        public static double OfferAppelPrice = 16.95;
        public static double offerAmt = 150.00;

    }
}
