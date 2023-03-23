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
            clsProduct Anproduct = new clsProduct();
            //test to see that it exits
            Assert.IsNotNull(Anproduct);
        }
        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnProduct.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnProduct.Active, TestData);
        }

        [TestMethod]
        public void Product_AvailabilityPropertyOK()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnProduct.Product_Availability = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnProduct.Product_Availability, TestData);
        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnProduct.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnProduct.DateAdded, TestData);
        }
        [TestMethod]
        public void Product_IDPropertyOK()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnProduct.Product_ID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnProduct.Product_ID, TestData);
        }
        [TestMethod]
        public void Product_NamePropertyOK()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //create some test data to assign to the property
            string TestData = "";
            //assign the data to the property
            AnProduct.Product_Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnProduct.Product_Name, TestData);
        }
        [TestMethod]
        public void Product_DescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //create some test data to assign to the property
            string TestData = "Some Street";
            //assign the data to the property
            AnProduct.Product_Description = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnProduct.Product_Description, TestData);
        }
        [TestMethod]
        public void Producct_PricePropertyOK()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnProduct.Producct_Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnProduct.Producct_Price, TestData);
        }
        [TestMethod]
        public void Launch_DataPropertyOK()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnProduct.Launch_Data = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnProduct.Launch_Data, TestData);
        }

    }

}
