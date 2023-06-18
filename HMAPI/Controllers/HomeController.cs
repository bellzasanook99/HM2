using Core.Common;
using Core.Domain.Enum;
using Core.Interfaces;
using Core.Models;
using HMAPI.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace HMAPI.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class HomeController : Controller
    {
        private IUserService _userService;
        private IViewService _viewService;
        public IJwtUtils _jwtUtils;

        public HomeController(IUserService userService, IJwtUtils jwtUtils, IViewService viewService)
        {

            _userService = userService;
            _jwtUtils = jwtUtils;
            _viewService = viewService;
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult GetViewFrom(int? UserId)
        {
            ViewModels viewModels = new ViewModels();
          var bannerget =  _viewService.Getbanner();

            while (!bannerget.IsCompleted)
            {
                viewModels.tblPromoteImgs = bannerget.Result;
            }

            return Ok(viewModels);
        }

        [HttpPost]
        [Auth]
        public IActionResult GetTEST()
        {
          

            return Ok();
        }

    }
}
