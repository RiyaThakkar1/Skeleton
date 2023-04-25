using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing6
{
    class tblDelivery
    {
        [TestMethod]
        public void instanceOK()
        {//create an instance of the class we want to create
            clsDelivery AnDelivery = new clsDelivery();
            //test to see that it exists
            Assert.IsNotNull(AnDelivery);

        }
    }
}
