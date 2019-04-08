using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomatedCheckout;

namespace TestAutomatedCheckout
{
    [TestClass]
    public class UnitTest1
    {
        private readonly Checkout _checkout;
        public UnitTest1()
        {
            _checkout = new Checkout();
        }
        [TestMethod]
        public void TestMethodToothpaste()
        {
            // 3 toothpaste
            _checkout.AddItem(1);
            _checkout.AddItem(1);
            _checkout.AddItem(1);

         var Totl= _checkout.Sum();
            Assert.AreEqual(49.88, Totl);
        }
        [TestMethod]
        public void TestMethodCoffee()
        {
            //two coffee
            _checkout.AddItem(4);
            _checkout.AddItem(4);
            var Totl = _checkout.Sum();
            Assert.AreEqual(40, Totl);
        }
        [TestMethod]
        public void TestMethodOtherProduct()
        {
            //two coffee
            _checkout.AddItem(3);
            _checkout.AddItem(4);
            _checkout.AddItem(5);
            var Totl = _checkout.Sum();
            Assert.AreEqual(67.39, Totl);
        }
        [TestMethod]
        public void TestMethodLargeAmt()
        {
            //four toothpaste and items total > 150
            _checkout.AddItem(7, 2);
            _checkout.AddItem(4);
            _checkout.AddItem(5);
            _checkout.AddItem(1);
            _checkout.AddItem(1);
            _checkout.AddItem(1);
            _checkout.AddItem(1);
            var Totl = _checkout.Sum();
            Assert.AreEqual(300.26, Totl);
        }
        [TestMethod]
        public void TestMethodNotExistId()
        {
            _checkout.AddItem(112);
            var Totl = _checkout.Sum();
            Assert.AreEqual(0, Totl); // as invalid itemid
        }
        [TestMethod]
        public void TestMethodSingleItem()
        {
            _checkout.AddItem(80000000);
            var Totl = _checkout.Sum();
            Assert.AreEqual(0, Totl);
        }

    }
}
