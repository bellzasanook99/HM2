using Core.Common;
using Core.Domain.Enum;
using Core.Interfaces;
using Core.Models;
using Core.Services;
using HMFront.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMFront.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        IJwtUtils _jwtUtils { get; set; }
        IToolsService _toolsService { get; set; }

        private readonly DomainSettings _domainSettings;

     
        public HomeController(ILogger<HomeController> logger, IJwtUtils jwtUtils, IToolsService toolsService, IOptions<DomainSettings>  domainSettings)
        {
            _logger = logger;
            _toolsService = toolsService;
            _jwtUtils = jwtUtils;
            _domainSettings = domainSettings.Value;
        }

        public IActionResult Index()
        {
   
            var data =   _toolsService.RestApiController(RestApiType.Post, _domainSettings.CoreAPIUrl+ "/api/Home/GetViewFrom", null);

           var dest = JsonConvert.DeserializeObject<ViewModels>(data.ToString());


            return View(data);
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
