﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ANVI_Mvc.Models;

namespace ANVI_Mvc.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        protected AnviModel db;

        public HomeController()
        {
            db = new AnviModel();
        }
        public ActionResult Index()   //主頁面
        {
            return View();
        }
        public ActionResult ProductsPage() //商品頁面
        {
            return View();
        }
        public ActionResult ProductDetailPage()  //單一商品頁面
        {
            return View();
        }
        public ActionResult Cart()  //購物車頁面
        {
            return View();
        }
        public ActionResult Order_Customer()  //下單-客戶頁面(填入收件人)!沒有HEADER跟FOOTER
        {
            return View();
        }
        public ActionResult Order_Pay()  //下單-付費頁面!沒有HEADER跟FOOTER
        {
            return View();
        }
        public ActionResult Order_Check()  //下單-確認頁面!沒有HEADER跟FOOTER
        {
            return View();
        }
    }
}