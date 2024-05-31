using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Quanlytrotdm.Models
{
    public class Dangnhap
    {
        [Required(ErrorMessage = "Vui lòng nhập tên đăng nhập ")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Tối thiểu là 6 ký tự và tối đa là 20 ký tự")]
        [Display(Name = "Tên đăng nhập")]
        public string tendangnhap { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu ")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Tối thiểu là 6 ký tự và tối đa là 20 ký tự")]
        [Display(Name = "Mật khẩu")]
        public string matkhau { get; set; }
    }
}