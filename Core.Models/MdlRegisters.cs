using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Models
{
    public class MdlRegisters
    {
        public string test { get; set; }
    }

    public class MdlRegister
    {
        public String AccountRef { get; set; }

        public String RegisType { get; set; }

        public bool RegisTypebool { get; set; }

        [Required(ErrorMessage = "AccountPhone is required")]
        public string AccountPhone { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string AccountPassword { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Confirm Password required")]
        [Compare("AccountPassword", ErrorMessage = "Password doesn't match.")]
        public string AccountCPassword { get; set; }

        [Required(ErrorMessage = "FistName is required")]
        public string FistName { get; set; }
        [Required(ErrorMessage = "LastName is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "NickName is required")]
        public string NickName { get; set; }


        public int idDays { get; set; }
        public int idMonths { get; set; }
        public int idYears { get; set; }

        public int idUsrTyp { get; set; }

        public bool idUsrTypCheck { get; set; }

        public int idprovice { get; set; }
        public int idAmphures { get; set; }


        public int idGender { get; set; }


        //[Required(ErrorMessage = "Please select file.")]
        //public HttpPostedFileBase ProfileFile { get; set; }

        public string ProfileName { get; set; }



        public string birthday { get; set; }


        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }


        public string cagsLists { get; set; }
        public List<string> Datatype { get; set; }


        public List<MdlUserType> mdlUserTypes { get; set; }
        // public string cagsLists { get; set; }

    }

    public class MdlUserType
    {
        public int TypId { get; set; }
        public bool check { get; set; }
        public string UsrTypNm_th { get; set; }
        public string UsrTypNm_en { get; set; }
    }
}
