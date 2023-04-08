using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstSales
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create 
            clsSales AnSales = new clsSales();
            //Test to see that it exists 
            Assert.IsNotNull(AnSales);
        }
    }
}
