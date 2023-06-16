using Core.Domain.Database;
using Core.Interfaces;
using Core.Models;
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
    public class AuthController : Controller
    {

        private IUserService _userService;
        public IJwtUtils _jwtUtils;
        public AuthController(IUserService userService,IJwtUtils jwtUtils)
        {

            _userService = userService;
            _jwtUtils = jwtUtils;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetAllUser()
        {
            var user = _userService.GetAccount();
            while (!user.IsCompleted)
            {
               return Ok(user.Result);
            }
            return BadRequest();

        }


        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login(MdlLogin mdlLogin)
        {


       
            var user = _userService.GetAccountByPhone(mdlLogin.PhoneNumber);



            while (!user.IsCompleted)
            {
                if (user.Result != null)
                {
                    if (user.Result.Password == _userService.Md5Convert(mdlLogin.Password))
                    {
                        ResUser resUser = new ResUser();

                      
                        resUser.tblAccount = user.Result;
                        resUser.Token = _jwtUtils.GenerateToken(user.Result);
                        return Ok(resUser);
                    }
                    else
                    {
                        ErrorMessage errorMessage = new ErrorMessage("Password Invalid", 5);
                        return BadRequest(errorMessage);
                    }
                }
                else
                {
                    ErrorMessage errorMessage = new ErrorMessage("User not found", 6);
                    return BadRequest(errorMessage);
                }
            }
            return BadRequest();

        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Register(MdlRegister mdlRegister)
        {
        
            if (mdlRegister != null)
            {

                TblAccount tblAccount = new TblAccount();
                Guid guid = Guid.NewGuid();
                tblAccount.AccountRef = guid.ToString();
                tblAccount.Astate = 0;

                tblAccount.Active = true;
                tblAccount.AccountNo = 0;
                tblAccount.AmphuresId = mdlRegister.idAmphures;
                tblAccount.ProvinesId = mdlRegister.idprovice;
                tblAccount.AccountPhone = mdlRegister.AccountPhone;
        
                tblAccount.FistName = mdlRegister.FistName;
                tblAccount.LastName = mdlRegister.LastName;
                tblAccount.NickName = mdlRegister.NickName;
                tblAccount.Email = mdlRegister.Email;
                tblAccount.GenderType = mdlRegister.idGender;
                tblAccount.PermissionType = mdlRegister.idUsrTyp;
                tblAccount.CagsLists = mdlRegister.cagsLists;
                tblAccount.Birthday = Convert.ToDateTime(mdlRegister.birthday);

                tblAccount.Password = _userService.Md5Convert(mdlRegister.AccountPassword);

                int state = _userService.AddAccount(tblAccount).Result;

                return Ok(state);
            }
       
            return BadRequest();


        }

    }
}
