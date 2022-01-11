﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllupStore.Areas.Admin.Controllers
{
    [Area("Admin")]
  
    public class DashboardController : Controller
    {
        public IActionResult Index() 
        {
            return View();
        }
    }
}
