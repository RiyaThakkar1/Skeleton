using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6
{
    [TestClass]
    public class tstDelivery
    {
        private object details;

        [TestMethod]
        public void InstanceOK()
        {
            clsDelivery AnDelivery = new clsDelivery();
            Assert.IsNotNull(AnDelivery);
        }
        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsDelivery AnDelivery = new clsDelivery();            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnDelivery.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnDelivery.Active, TestData);
        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsDelivery AnDelivery = new clsDelivery();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnDelivery.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnDelivery.DateAdded, TestData);
        }
        [TestMethod]
        public void customer_idPropertyOK()
        {
            //create an instance of the class we want to create
            clsDelivery AnDelivery = new clsDelivery();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnDelivery.customer_id = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnDelivery.customer_id, TestData);
        }
        [TestMethod]
        public void order_idPropertyOK()
        {
            //create an instance of the class we want to create
            clsDelivery AnDelivery = new clsDelivery();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnDelivery.order_id = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnDelivery.order_id, TestData);
        }
        [TestMethod]
        public void delivery_idPropertyOK()
        {
            //create an instance of the class we want to create
            clsDelivery AnDelivery = new clsDelivery();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnDelivery.delivery_id = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnDelivery.delivery_id, TestData);
        }
        [TestMethod]
        public void order_availabilityPropertyOK()
        {
            //create an instance of the class we want to create
            clsDelivery AnDelivery = new clsDelivery();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnDelivery.order_availability = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnDelivery.order_availability, TestData);
        }
        [TestMethod]
        public void order_confirmationPropertyOK()
        {
            //create an instance of the class we want to create
            clsDelivery AnDelivery = new clsDelivery();            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnDelivery.order_confirmation = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnDelivery.order_confirmation, TestData);
        }
        [TestMethod]
        public void order_datePropertyOK()
        {
            //create an instance of the class we want to create
            clsDelivery AnDelivery = new clsDelivery();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnDelivery.order_date = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnDelivery.order_date, TestData);
        }
     }  
}
