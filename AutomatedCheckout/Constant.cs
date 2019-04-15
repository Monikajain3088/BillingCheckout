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
        public const int offerCoffeeQty = 2;
        public const double OfferCoffeePrice = 40;
        //Toothpaste Offer
        public const int offerTPQty = 3;
        public static double OfferTPPrice = Products.items[Constant.ToothPasteID].Price * 2;
        // Appel Offer
        public const double OfferAppelPrice = 16.95;
        public const double offerAmt = 150.00;

    }
}
