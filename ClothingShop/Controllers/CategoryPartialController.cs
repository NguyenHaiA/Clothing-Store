﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClothingShop.Models;

namespace ClothingShop.Controllers
{
    public class CategoryPartialController : Controller
    {
        ClothingStoreEntities2 db = new ClothingStoreEntities2();
        // GET: CategoryPartial
        public ActionResult PartialCate()
        {
            ViewBag.CategoryList = db.Categories.ToList();
            return PartialView();
        }
    }
}