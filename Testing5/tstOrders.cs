using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstOrders
    {
            
        //good test data
        //create some test data to pass to the method
        string OrderName = "Jeans";
        string OrderPrice = 30.ToString();
        string OrderDate = DateTime.Now.Date.ToString();
        string CustomerID = 2.ToString();

    [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //test to see if it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }

        [TestMethod]
        public void OrderNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            string TestData = "First Order";
            //assign the data to the property
            AnOrder.OrderName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderName, TestData);
        }

        [TestMethod]
        public void OrderPricePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            decimal TestData = 30;
            //assign the data to the property
            AnOrder.OrderPrice = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderPrice, TestData);
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.OrderDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void CustomerIDOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            AnOrder.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerID, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderID = 21;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestOrderIDFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //Boolean variable to store the results of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 21;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the property
            if (AnOrder.OrderID != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        public void TestOrderNameFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //Boolean variable to store the results of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 21;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the property
            if (AnOrder.OrderName != "First Order")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        public void TestOrderPriceFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //Boolean variable to store the results of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 21;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the property
            if (AnOrder.OrderPrice != 30)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //Boolean variable to store the results of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 21;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the property
            if (AnOrder.OrderDate != DateTime.Now)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        public void TestCutomerIDFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //Boolean variable to store the results of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 21;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the address no
            if (AnOrder.CustomerID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(OrderName, OrderPrice, OrderDate, CustomerID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

      [TestMethod]
        public void OrderNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderName = ""; //this should trigger an error
            //invoke the method 
            Error = AnOrder.Valid(OrderName, OrderPrice, OrderDate, CustomerID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNameMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "a";
            //create some test data to pass to the method
            string OrderName = ""; //this should trigger an error
            //invoke the method 
            Error = AnOrder.Valid(OrderName, OrderPrice, OrderDate, CustomerID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "aa";
            //create some test data to pass to the method
            string OrderName = ""; //this should trigger an error
            //invoke the method 
            Error = AnOrder.Valid(OrderName, OrderPrice, OrderDate, CustomerID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "aaaaaaaaaaaaaa";
            //create some test data to pass to the method
            string OrderName = ""; //this should trigger an error
            //invoke the method 
            Error = AnOrder.Valid(OrderName, OrderPrice, OrderDate, CustomerID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNameMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "aaaaaaaaaaaaaaa";
            //create some test data to pass to the method
            string OrderName = ""; //this should trigger an error
            //invoke the method 
            Error = AnOrder.Valid(OrderName, OrderPrice, OrderDate, CustomerID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNameMid()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "aaaaaaa";
            //create some test data to pass to the method
            string OrderName = ""; //this should trigger an error
            //invoke the method 
            Error = AnOrder.Valid(OrderName, OrderPrice, OrderDate, CustomerID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "aaaaaaaaaaaaaaaa";//this should fail
            //create some test data to pass to the method
            string OrderName = ""; //this should trigger an error
            //invoke the method 
            Error = AnOrder.Valid(OrderName, OrderPrice, OrderDate, CustomerID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";//this should fail
            //create some test data to pass to the method
            string OrderName = ""; //this should trigger an error
            OrderName = OrderName.PadRight(500, 'a');//this should fail
            //invoke the method 
            Error = AnOrder.Valid(OrderName, OrderPrice, OrderDate, CustomerID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderName, OrderPrice, OrderDate, CustomerID);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); 
        }

        [TestMethod]
        public void OrderDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderName, OrderPrice, OrderDate, CustomerID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderName, OrderPrice, OrderDate, CustomerID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderName, OrderPrice, OrderDate, CustomerID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderName, OrderPrice, OrderDate, CustomerID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void OrderDateInvalidData()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //convert the date variable to a string variable
            string OrderDate = "This is not a date";
            //invoke the method
            Error = AnOrder.Valid(OrderName, OrderPrice, OrderDate, CustomerID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}

