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
        [TestMethod]
        public void ActiveProperty()

        {
            //create an instance of the class we want to create
            clsMarketing AnMarketing = new clsMarketing();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnMarketing.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnMarketing.Active, TestData);

        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsMarketing AnMarketing = new clsMarketing();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnMarketing.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnMarketing.DateAdded, TestData);
        }
        [TestMethod]
        public void customer_idPropertyOK()
        {
            //create an instance of the class we want to create
            clsMarketing AnMarketing = new clsMarketing();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnMarketing.customer_id = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnMarketing.customer_id, TestData);
        }
        [TestMethod]
        public void order_idPropertyOK()
        {
            //create an instance of the class we want to create
            clsMarketing AnMarketing = new clsMarketing();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnMarketing.order_id = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnMarketing.order_id, TestData);
        }
        [TestMethod]
        public void customer_namePropertyOK()
        {
            //create an instance of the class we want to create
            clsMarketing AnMarketing = new clsMarketing();
            //create some test data to assign to the property
            string TestData = "pragnesh";
            //assign the data to the property
            AnMarketing.customer_name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnMarketing.customer_name, TestData);
        }
        [TestMethod]
        public void order_datePropertyOK()
        {
            //create an instance of the class we want to create
            clsMarketing AnMarketing = new clsMarketing();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnMarketing.order_date = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnMarketing.order_date, TestData);
        }
        [TestMethod]
        public void customer_satisfactionProperty()

        {
            //create an instance of the class we want to create
            clsMarketing AnMarketing = new clsMarketing();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnMarketing.customer_satisfaction = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnMarketing.customer_satisfaction, TestData);

        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsMarketing AnMarketing = new clsMarketing();
            Boolean Found = false;
            Int32 customer_id = 12302;
            Found = AnMarketing.Find(customer_id);
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void Testcustomer_idFound()
        {
            clsMarketing AnMarketing = new clsMarketing();
            Boolean Found = false;
            Boolean OK = true;
            Int32 customer_id = 12302;
            Found = AnMarketing.Find(customer_id);
            if (AnMarketing.Customer_id != 12302)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            clsMarketing AnMarketing = new clsMarketing();
            Boolean Found = false;
            Boolean OK = true;
            Int32 customer_id = 12302;
            Found = AnMarketing.Find(customer_id);
            if (AnMarketing.Order_date != Convert.ToDateTime ("09/07/2022"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void Testorder_idFound()
        {
            clsMarketing AnMarketing = new clsMarketing();
            Boolean Found = false;
            Boolean OK = true;
            Int32 customer_id = 12302;
            Found = AnMarketing.Find(customer_id);
            if (AnMarketing.Order_id != 7)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void Testcustomer_nameFound()
        {
            clsMarketing AnMarketing = new clsMarketing();
            Boolean Found = false;
            Boolean OK = true;
            Int32 customer_id = 12302;
            Found = AnMarketing.Find(customer_id);
            if (AnMarketing.Customer_name != "Het")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void Testcustomer_satisfactionFound()
        {
            clsMarketing AnMarketing = new clsMarketing();
            Boolean Found = false;
            Boolean OK = true;
            Int32 customer_id = 12302;
            Found = AnMarketing.Find(customer_id);
            if (AnMarketing.Customer_satisfaction != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


    }
}
