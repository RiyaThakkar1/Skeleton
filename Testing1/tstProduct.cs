using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstProduct
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsproduct Anproduct = new clsproduct();
            //test to see that it exits
            Assert.IsNotNull(Anproduct);
        }
    }
}
