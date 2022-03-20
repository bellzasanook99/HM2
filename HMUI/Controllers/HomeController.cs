using Core.Models;
using HMUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HMUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            MdlRegisters mdlRegisters = new MdlRegisters();
            mdlRegisters.test = "tttt";


            return View(mdlRegisters);
        }
        public IActionResult SignUp()
        {
           


            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
