using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using SalesPanelApp.Business;
using SalesPanelApp.Dal;
using SalesPanelApp.Models;

namespace SalesPanelApp.Controllers
{
    public class ProductDetailsController : Controller
    {
        ProductManager productManager = new ProductManager();

        // GET: ProductDetails
        public ActionResult Index(User user)
        {
            var result = productManager.GetAll(user);
            return View(result);
        }


        public ActionResult ProjectDetail(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ViewBag.id = id;
            return View();
        }
        public ActionResult GetData(int id)
        {
            var result = productManager.GetByIdProject(id);
            return Json(result, JsonRequestBehavior.AllowGet);
        }



        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                using (BrandContext context = new BrandContext())
                {
                    context.Dispose();
                }
            }
            base.Dispose(disposing);
        }
    }
}
