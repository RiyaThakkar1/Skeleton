using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6
{
    [TestClass]
    public class tstDelivery
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsDelivery AnDelivery = new clsDelivery();
            Assert.IsNotNull(AnDelivery);
        }
    }
}
