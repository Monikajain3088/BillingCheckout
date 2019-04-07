using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomatedCheckout;

namespace TestAutomatedCheckout
{
    [TestClass]
    public class UnitTest1
    {
        Checkout obj = new Checkout();
        [TestMethod]
        public void TestMethodToothpaste()
        {
            // 3 toothpaste
            obj.AddItem(1);
            obj.AddItem(1);
            obj.AddItem(1);

         var Totl=   obj.Sum();
        }
        [TestMethod]
        public void TestMethodCoffee()
        {
            //two coffee
            obj.AddItem(4);
            obj.AddItem(4);
            var Totl = obj.Sum();
        }
        [TestMethod]
        public void TestMethodOtherProduct()
        {
            //two coffee
            obj.AddItem(3);
            obj.AddItem(4);
            obj.AddItem(5);
            var Totl = obj.Sum();
        }
        [TestMethod]
        public void TestMethodFourToothpaste()
        {
            //two coffee
            obj.AddItem(7, 2.30);
            obj.AddItem(2);
            obj.AddItem(3);
            obj.AddItem(4);
            obj.AddItem(5);
            obj.AddItem(1);
            obj.AddItem(1);
            obj.AddItem(1);
            obj.AddItem(112);
            var Totl = obj.Sum();
        }
        [TestMethod]
        public void TestMethodNotExistId()
        {
            obj.AddItem(112);
            var Totl = obj.Sum();
        }
    }
}
