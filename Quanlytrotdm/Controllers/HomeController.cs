using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.Expressions;
using Quanlytrotdm.Models;
namespace Quanlytrotdm.Controllers
{
    public class HomeController : Controller
    {
        QUANLYNHATROEntities1 ql=new QUANLYNHATROEntities1();
        public ActionResult Index()
        {
          return View();
        }
        public ActionResult Tromoi()
        {
           
            if(ModelState.IsValid) 
            { 
                var main = from n in ql.ROOMs select n;
                var a = main.ToList();
                var orderby = from n in a.OrderByDescending(n => n.NGAYDANG) select n;
                return PartialView(orderby);
            }
            return PartialView();
        }
        public ActionResult Detailroom(int id)
        {
            var detailsach = from n in ql.ROOMs join b in ql.MOTELs on n.IDMOTEL equals b.ID where n.ID == id select n;
                
            return View(detailsach);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }

   
}