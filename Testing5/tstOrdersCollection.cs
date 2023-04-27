using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    class tstOrdersCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListProperty()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrders> TestList = new List<clsOrders>();
            //add an item to the list
            //create the item of test data
            clsOrders TestItem = new clsOrders();
            //set its properties
            TestItem.OrderID = 1;
            TestItem.OrderName = "Shorts";
            TestItem.OrderPrice = 45;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.CustomerID = 1;
            //add the item to the test List
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to the that the two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllOrders.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, SomeCount);
        }


    [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create some test data to assign to the property
            clsOrders TestOrder = new clsOrders();
            //set the property of the test object
            TestOrder.OrderID = 1;
            TestOrder.OrderName = "Shorts";
            TestOrder.OrderPrice = 45;
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.CustomerID = 1;
            //assign the data to the property
            AllOrders.ThisOrder =  TestOrder;
            //test to the that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create some test data to assign to the property
            List<clsOrders> TestList = new List<clsOrders>();
            //add an item to the list
            //create the item of test data
            clsOrders TestItem = new clsOrders(); 
            //set the property of the test object
            TestItem.OrderID = 1;
            TestItem.OrderName = "Shorts";
            TestItem.OrderPrice = 45;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.CustomerID = 1;
            //add the item to the testList
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to the that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, 2);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create the item of test data
            clsOrders TestItem = new clsOrders();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderID = 1;
            TestItem.OrderName = "Jeans";
            TestItem.OrderPrice = 45;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.CustomerID = 1;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create the item of test data
            clsOrders TestItem = new clsOrders();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderName = "Jeans";
            TestItem.OrderPrice = 45;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.CustomerID = 1;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //modify the test data
            TestItem.OrderName = "Shorts";
            TestItem.OrderPrice = 20;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.CustomerID = 2;
            //set the record based on the new test data
            AllOrders.ThisOrder = TestItem;
            //update the record
            AllOrders.Update();
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see ThisAddress matches the test data
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create the item of test data
            clsOrders TestItem = new clsOrders();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderName = "Jeans";
            TestItem.OrderPrice = 45;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.CustomerID = 1;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //delete the record
            AllOrders.Delete();
            //now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByOrderNameMethodOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create an instance of the filtered data
            clsOrdersCollection FilteredOrders = new clsOrdersCollection();
            //apply a blank string (should return all records)
            FilteredOrders.ReportByOrderName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByOrderNameNoneFound()
        {
            //create an instance of the filtered data
            clsOrdersCollection FilteredOrder = new clsOrdersCollection();
            //apply a name that doesn't exist
            FilteredOrder.ReportByOrderName("xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredOrder.Count);
        }

        [TestMethod]
        public void ReportByOrderNameTestDataFound()
        {
            //create an instance of the filtered data
            clsOrdersCollection FilteredOrders = new clsOrdersCollection();
            //var to store outcome 
            Boolean OK = true;
            //apply an order name that doesn't exist
            FilteredOrders.ReportByOrderName("XXX");
            //check if the correct number of records are found
            if (FilteredOrders.Count == 2)
            {
               //check if the first record is ID 36
               if (FilteredOrders.OrderList[0].OrderID != 36)
                {
                    OK = false;

                }
                //check if the first record is ID 37
                if (FilteredOrders.OrderList[1].OrderID != 37)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}