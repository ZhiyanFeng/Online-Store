using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineStore.Models;

namespace OnlineStore.Controllers
{
    public class HomeController : Controller
    {
        private OnlineStoreContext storeDB = new OnlineStoreContext();

        public ActionResult Index()
        {
            // Get most popular albums
            var cellPhone = GetTopPriceCellPhone(6);

            return View(cellPhone);
        }

        private List<Product> GetTopPriceCellPhone(int count)
        {
            // Group the order details by album and return
            // the albums with the highest count
            var product = storeDB.Products;
            return storeDB.Products
                .OrderByDescending(a => a.Price)
                .Take(count)
                .ToList();
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

        public ActionResult DailyDeal()
        {
            var phone = GetDailyDeal();
            return PartialView("_DailyDeal", phone);
        }

        private Product GetDailyDeal()
        {
            var phone = storeDB.Products.OrderBy(a => System.Guid.NewGuid()).First();
            phone.Price = phone.Price / 2;
            return phone;
        }
    }
}