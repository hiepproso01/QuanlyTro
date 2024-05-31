using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace Quanlytrotdm.Models
{
    public class DangKy
    {
        
        [Required(ErrorMessage = "Nhập Họ và tên")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Tối thiểu là 6 ký tự và tối đa là 20 ký tự")]
        [Display(Name = "Họ và tên")]
        public string Name { get; set; }
        [Required(ErrorMessage = "nhập Gmail")]
        [RegularExpression(@"([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)", ErrorMessage ="Định dạng gmail sai")]
        public string Email { get; set; }

        [Required(ErrorMessage = "nhập tên đăng nhập")]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Tối thiểu là 6 ký tự và tối đa là 20 ký tự")]
        [Display(Name = "Tên đăng nhập")]
        public string username { get; set; }
        [Required(ErrorMessage = "nhập password đăng nhập")]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Tối thiểu là 6 ký tự và tối đa là 20 ký tư")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$",ErrorMessage ="phải có ít nhất 1 ký tự in hoa, 1 ký tự in thường, 1 ký tự đặt biệt")]
        [Display(Name ="Mật khẩu")]
        public string password { get; set; }
        [Display(Name = "Hãy nhập lại mật khẩu")]
        [Required(ErrorMessage = "Hãy xác nhận password đăng nhập")]
        [System.ComponentModel.DataAnnotations.Compare("password", ErrorMessage = "Xác nhận mật khẩu không đúng")]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Tối thiểu là 6 ký tự và tối đa 20 ký tự")]
        public string confimpass { get; set; }
    }
}