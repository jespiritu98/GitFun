﻿using GitFun.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GitFun.Controllers
{
    public class HomeController : Controller
    {
 

        public HomeController(ILogger<HomeController> logger)
        {
         
        }

        public IActionResult Index()
        {
            return View();
        }


    }
}
