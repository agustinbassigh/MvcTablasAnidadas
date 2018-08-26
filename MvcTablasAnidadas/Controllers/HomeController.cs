using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcTablasAnidadas.Models;

namespace MvcTablasAnidadas.Controllers
{
    public class HomeController : Controller
    {
        NorthwindEntities contexto = null;
        public ActionResult Index()
        {
            contexto = new NorthwindEntities();
            List<Orders> ordenes = contexto.Orders.Take(10).ToList();
            return View(ordenes);
        }

        public ActionResult Detalle(int ordenId)
        {
            contexto = new NorthwindEntities();
            List<Order_Details> detalle = contexto.Order_Details.Where(m => m.OrderID == ordenId).ToList();
            return PartialView(detalle);
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