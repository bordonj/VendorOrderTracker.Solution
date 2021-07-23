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
    List<Vendor> allCategories = Vendor.GetAll();
      return View(allCategories);
    }

  }
}