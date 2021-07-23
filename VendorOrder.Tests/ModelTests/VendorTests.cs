using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test name", "test description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetNameAndDescription_ReturnsNameAndDescription_String()
    {
      //Arrange
      string name = "Test Name";
      string description = "Test Description";
      Vendor newVendor = new Vendor(name, description);

      //Act
      string resultName = newVendor.Name;
      string resultDescription = newVendor.Description;

      //Assert
      Assert.AreEqual(name, resultName);
      Assert.AreEqual(description, resultDescription);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      string name = "Test Name";
      string description = "Test Description";
      Vendor newVendor = new Vendor(name, description);

      //Act
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      string vendorName1 = "Suzie's Cafe";
      string vendorDesc1 = "A place for people to study and eat baked goodies.";
      string vendorName2 = "Potato's Sitdown";
      string vendorDesc2  = "A place for potatoes to sit down and enjoy baked goodes";
      Vendor newVendor1 = new Vendor(vendorName1, vendorDesc1);
      Vendor newVendor2 = new Vendor(vendorName2, vendorDesc2);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectCategory_Category()
    {
      //Arrange
      string vendorName1 = "Suzie's Cafe";
      string vendorDesc1 = "A place for people to study and eat baked goodies.";
      string vendorName2 = "Potato's Sitdown";
      string vendorDesc2  = "A place for potatoes to sit down and enjoy baked goodes";
      Vendor newVendor1 = new Vendor(vendorName1, vendorDesc1);
      Vendor newVendor2 = new Vendor(vendorName2, vendorDesc2);

      //Act
      Vendor result = Vendor.Find(2);

      //Assert
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      //Arrange
      string orderTitle = "A party of 20";
      string orderDesc = "50 croissants";
      string date = "July 20, 2021";
      int price = 50;
      Order newOrder = new Order(orderTitle, orderDesc, date, price);
      List<Order> newList = new List<Order> { newOrder };
      string vendorName = "Suzie's Cafe";
      string vendorDesc = "A hot spot for studying and Pierre's baked goods";
      Vendor newVendor = new Vendor(vendorName, vendorDesc);
      newVendor.AddOrder(newOrder);
      //Act
      List<Order> result = newVendor.Orders;

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
    
  }
}