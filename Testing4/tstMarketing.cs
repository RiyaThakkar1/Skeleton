using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstMarketing
    {
        [TestMethod]
        public void InstanceOK()

        {
            //create an instance of the class we want to create
            clsMarketing AnMarketing = new clsMarketing();
            //test to see that it exists
            Assert.IsNotNull(AnMarketing);
        }
    }
}
