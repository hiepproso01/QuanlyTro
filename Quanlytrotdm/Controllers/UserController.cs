using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Capcha.HtmlHelpers;
using Quanlytrotdm.Models;
namespace Quanlytrotdm.Controllers
{
    public class UserController : Controller
    {
        QUANLYNHATROEntities1 ql=new QUANLYNHATROEntities1();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(DangKy dk)
        {
            STUDENT st = new STUDENT();

            if (ModelState.IsValid)
            {
                if (ql.STUDENTs.Count(x => x.USERNAME == dk.username) > 0)
                {
                    ModelState.AddModelError("", "Tên đăng nhập bị trùng");
                }
                else if (!this.CheckCapcha())
                {
                    ModelState.AddModelError("", "chưa nhập capcha");
                }
                else
                {

                    st.NAME = dk.Name;
                    st.PASSWORD = GetMD5(dk.password);
                    st.USERNAME = dk.username;
                    ql.STUDENTs.Add(st);
                    ql.SaveChanges();
                    return RedirectToAction("Login","User");

                }
            }

            return View();
        }
        [HttpGet]
        public ActionResult Login() 
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Dangnhap dn)
        {
            if (ModelState.IsValid)
            {
                var mk = GetMD5(dn.matkhau);
                var check = ql.STUDENTs.Where(x => x.USERNAME.Equals(dn.tendangnhap) && x.PASSWORD.Equals(mk)).ToList();
                if (check.Count > 0)
                {
                    Session["Taikhoan"] = check.FirstOrDefault().NAME;
                    return RedirectToAction("Index", "Home");

                }
                else
                {
                    ViewBag.error = "Login failed";
                }
            }

            return View();

        }
        public static string GetMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(str);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");

            }
            return byte2String;
        }
    }
}