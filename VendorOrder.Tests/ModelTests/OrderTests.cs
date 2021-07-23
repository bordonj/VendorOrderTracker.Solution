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

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newList = new List<Order> { };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      //Arrange
      string title1 = "100 croissants";
      string description1 = "Make and deliver 100 croissants in the morning";
      string date1 = "July 23, 2021";
      int price1 = 75;
      string title2 = "100 cookies";
      string description2 = "Make and deliver 100 cookies in the morning";
      string date2 = "July 23, 2021";
      int price2 = 60;
      Order newOrder1 = new Order(title1, description1, date1, price1);
      Order newOrder2 = new Order(title2, description2, date2, price2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      //Act
      List<Order> result = Order.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}