﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieRental.Controllers
{
    public class RentalsController : Controller
    {
        // GET: Rentals
        [AllowAnonymous]
        public ActionResult New()
        {
            return View();
        }
    }
}