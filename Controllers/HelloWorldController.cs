﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;

namespace MveMovie5.Controllers
{
    public class HelloWorldController : Controller
    {

        //
        //GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }
        //
        //Get: /HelloWorld/Welcome/
       // public IActionResult Index()
       public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();

        }
       

      
        }
    }

