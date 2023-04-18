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
            AnProduct.Product_Id = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnProduct.Product_Id, TestData);
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
            AnProduct.Launch_Date = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnProduct.Launch_Date, TestData);
        }

        
        //new test
        [TestMethod]
        public void FindMethodOK()
        {
            clsProduct AnProduct = new clsProduct();
            Boolean Found = false;
            Int32 Product_Id = 1;
            Found = AnProduct.Find(Product_Id);
            Assert.IsTrue(Found);

        }
        //test product ID
        [TestMethod]
        public void TestProduct_IdNotFound()
        {
            clsProduct AnProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Product_Id = 1;
            Found = AnProduct.Find(Product_Id);
            if (AnProduct.Product_Id != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //product name
        [TestMethod]
        public void TestProduct_NameFound()
        {
            clsProduct AnProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Product_Id = 1;
            Found = AnProduct.Find(Product_Id);
            if (AnProduct.Product_Name != "CSK Jersey")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        //product price
        [TestMethod]
        public void TestProducct_PriceFound()
        {
            clsProduct AnProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Product_Id = 1;
            Found = AnProduct.Find(Product_Id);
            if (AnProduct.Producct_Price != 20)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        //product decription 
        [TestMethod]
        public void TestProduct_DescriptionFound()
        {
            clsProduct AnProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Product_Id = 1;
            Found = AnProduct.Find(Product_Id);
            if (AnProduct.Product_Description != "Long sleeve")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        //product launch date
        [TestMethod]
        public void TestDateAddedFound()
        {
            clsProduct AnProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Product_Id = 1;
            Found = AnProduct.Find(Product_Id);
            if (AnProduct.Launch_Date != Convert.ToDateTime("31/03/2023"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        
        
        //product avaliblity 
        [TestMethod]
        public void TestProduct_AvailabilityFound()
        {
            clsProduct AnProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Product_Id = 1;
            Found = AnProduct.Find(Product_Id);
            if (AnProduct.Product_Availability != false)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }







    }

}
