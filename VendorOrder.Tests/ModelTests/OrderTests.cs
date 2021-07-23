using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrder.Models;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("title", "description", "date", 0);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetProperties_ReturnsProperties_CorrectType()
    {
      //Arrange
      string title = "100 croissants";
      string description = "Make and deliver 100 croissants in the morning";
      string date = "July 23, 2021";
      int price = 75;

      //Act
      Order newOrder = new Order(title, description, date, price);
      string resultTitle = newOrder.Title;
      string resultDesc = newOrder.Description;
      string resultDate = newOrder.Date;
      int resultPrice = newOrder.Price;

      //Assert
      Assert.AreEqual(title, resultTitle);
      Assert.AreEqual(description, resultDesc);
      Assert.AreEqual(date, resultDate);
      Assert.AreEqual(price, resultPrice);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string title = "100 croissants";
      string description = "Make and deliver 100 croissants in the morning";
      string date = "July 23, 2021";
      int price = 75;
      Order newOrder = new Order(title, description, date, price);

      //Act
      string updatedDescription = "Make and deliver 10000 croissants in the morning";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    // [TestMethod]
    // public void GetAll_ReturnsEmptyList_OrderList()
    // {
    //   // Arrange
    //   List<Order> newList = new List<Order> { };

    //   // Act
    //   List<Order> result = Order.GetAll();

    //   // Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }

    // [TestMethod]
    // public void GetAll_ReturnsOrders_OrderList()
    // {
    //   //Arrange
    //   string description01 = "Walk the dog";
    //   string description02 = "Wash the dishes";
    //   Order newOrder1 = new Order(description01);
    //   Order newOrder2 = new Order(description02);
    //   List<Order> newList = new List<Order> { newOrder1, newOrder2 };

    //   //Act
    //   List<Order> result = Order.GetAll();

    //   //Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }
  }
}