﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClothingShop.Models;

namespace ClothingShop.Controllers
{
    public class ProductDetailController : Controller
    {
        ClothingStoreEntities2 db = new ClothingStoreEntities2();
        // GET: ProductDetail
        public ActionResult Index(int id)
        {
            ViewBag.Product = db.Products.FirstOrDefault(p => p.ProductID == id);

            
            ViewBag.ProdList = db.Products.ToList().Take(4);
            return View();
        }
    }
}