using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static System.Net.Mime.MediaTypeNames;

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

        [TestMethod]
        public void ActiveOrderOK()
        {
            //Create an instance of the class we want to create 
            clsSales AnSales = new clsSales();
            //Create some test data 
            Boolean TestData = true;
            //Assign the data to the property 
            AnSales.Active = TestData;
            //Test to see if the two values are the same 
            Assert.AreEqual(AnSales.Active, TestData);
        }

        [TestMethod]
        public void CustomerIDOK()
        {
            //Create an instance of the class we want to create 
            clsSales AnSales = new clsSales();
            //Create some test data 
            String TestData = "KATHA2003";
            //Assign the data to the property 
            AnSales.CustomerEmailID = TestData;
            //Test to see if the two values are the same 
            Assert.AreEqual(AnSales.CustomerEmailID, TestData);
        }

        [TestMethod]
        public void CustomerFirstNameOK()
        {
            //Create an instance of the class we want to create 
            clsSales AnSales = new clsSales();
            //Create some test data 
            string TestData = "Kavipiriya";
            //Assign the test data to the property
            AnSales.CustomerFirstName = TestData;
            //Test to see if the two values are the same 
            Assert.AreEqual(AnSales.CustomerFirstName, TestData);
        }

        [TestMethod]
        public void CustomerLastNameOK()
        {
            //Create an instance of the class we want to create 
            clsSales AnSales = new clsSales();
            //Create some test data 
            string TestData = "Thamilmaran";
            //Assign the test data to the property
            AnSales.CustomerLastName = TestData;
            //Test to see if the two values are the same 
            Assert.AreEqual(AnSales.CustomerLastName, TestData);
        }

        [TestMethod]
        public void CustomerDOBOK()
        {
            //Create an instance of the class we want to create 
            clsSales AnSales = new clsSales();
            //Create some test data 
            DateTime TestData = DateTime.Now.Date;
            //Assign the data to the property 
            AnSales.CustomerDOB = TestData;
            //Test to see that the two values are the same 
            Assert.AreEqual(AnSales.CustomerDOB, TestData);
        }

        [TestMethod]
        public void CustomerEmailIDOK()
        {
            //Create an instance of the class we want to create 
            clsSales AnSales = new clsSales();
            //Create some test data 
            String TestData = "K.THAMILMARAN@Gmail.com";
            //Assign the data to the property 
            AnSales.CustomerEmailID = TestData;
            //Test to see that the two values are the same 
            Assert.AreEqual(AnSales.CustomerEmailID, TestData);
        }

        [TestMethod]
        public void CustomerContactNumberOK()
        {
            //Create an instance of the class we want to create 
            clsSales AnSales = new clsSales();
            //Create some test data 
            String TestData = "07536836257";
            //Assign the data to the property 
            AnSales.CustomerContactNumber = TestData;
            //Test to see that the two values are the same 
            Assert.AreEqual(AnSales.CustomerContactNumber, TestData);
        }

        [TestMethod]
        public void OrderIDOK()
        {
            //Create an instance of the class we want to create 
            clsSales AnSales = new clsSales();
            //Create some test data 
            String TestData = "24";
            //Assign the data to the property 
            AnSales.OrderID = TestData;
            //Test to see that the two values are the same 
            Assert.AreEqual(AnSales.OrderID, TestData);
        }

        [TestMethod]
        public void OrderQuantityOK()
        {
            //Create an instance of the class we want to create 
            clsSales AnSales = new clsSales();
            //Create some test data
            String TestData = "2";
            //Assign the data to the property 
            AnSales.OrderQuantity = TestData;
            //Test to see that the two values are the same 
            Assert.AreEqual(AnSales.OrderQuantity, TestData);
        }

        [TestMethod]
        public void OrderDescriptionOK()
        {
            //Create an instance of the class we want to create 
            clsSales AnSales = new clsSales();
            //Create some test data 
            String TestData = "Black sleeveless shirt";
            //Assign the data to the Quantity 
            AnSales.OrderDescription = TestData;
            //Test to see that the two values are the same 
            Assert.AreEqual(AnSales.OrderDescription, TestData);
        }
    }
}


