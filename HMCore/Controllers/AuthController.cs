using Core.Common;
using Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace HMCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Get(MdlLogin UserName)
        {

            if (UserName.PhoneNumber == "test")
            {
                string token = JwtManager.GenerateToken(UserName.PhoneNumber);


                return Ok();
            }
            return Unauthorized();

            // return Messagex;
        }

        [HttpGet]
        [JwtAuthentication]
        public IActionResult Getdata()
        {


            return Ok("test");

            // return Messagex;
        }
    }
}
