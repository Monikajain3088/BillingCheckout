using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatedCheckout
{
    interface ICheckout
    {
        void AddItem(int itemId);
        void AddItem(int itemId, double weight);
        double Sum();
    }
}
