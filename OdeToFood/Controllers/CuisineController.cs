﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Filters;

namespace OdeToFood.Controllers
{
    [Log]
    public class CuisineController : Controller
    {
        //[HttpPost]
        //[HttpGet]
        //[Authorize]
        public ActionResult Search(string name)
        {
            var message = Server.HtmlEncode(name); 

            return Content(message);
        }
    }
}