using Microsoft.AspNetCore.Mvc;
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
       //public string Welcome(string name, int numTimes = 1)
       public string Welcome(string name, int ID =1)

        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");

           //return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
            
            
             
            //return "This is the Welcome Action method..";
            
            //return View();
        }
    }
}
