using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;

namespace VendorOrder.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendor")]
    public ActionResult Index()
    {
    // List<Vendor> allCategories = Category.GetAll();
    //   return View(allCategories);
    }
    // [HttpGet("/vendor/new")]
    // public ActionResult New()
    // {
    //   return View();
    // }
    // [HttpPost("/categories")]
    // public ActionResult Create(string categoryName)
    // {
    //   Category newCategory = new Category(categoryName);
    //   return RedirectToAction("Index");
    // }

    // [HttpGet("/categories/{id}")]
    // public ActionResult Show(int id)
    // {
    //   Dictionary<string, object> model = new Dictionary<string, object>();
    //   Category selectedCategory = Category.Find(id);
    //   List<Item> categoryItems = selectedCategory.Items;
    //   model.Add("category", selectedCategory);
    //   model.Add("items", categoryItems);
    //   return View(model);
    // }

  }
}