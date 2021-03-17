using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using SalesPanelApp.Business;
using SalesPanelApp.Dal;
using SalesPanelApp.Models;

namespace SalesPanelApp.Controllers
{
    public class UsersController : Controller
    {
        UserManager userManager = new UserManager();

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login( User user)
        {

            ViewBag.message = PasswordAndUserNameEmpty(user.UserName, user.Password);
            if (ModelState.IsValid )
            {
                User Findeduser = userManager.CheckUser(user);
                if (Findeduser != null)
                {
                    return RedirectToAction("ChangePassword", new { id = Findeduser.Id });
                }
                else { ViewBag.message = "Bilgilerinizi kontrol ediniz."; }
            }
            return View(user);
        }

        public ActionResult ChangePassword(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = userManager.GetUser(id);
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangePassword(User user)
        {
            ViewBag.message = user.Password != "" ? "" : "lütfen şifre giriniz";
            if (ModelState.IsValid)
            {
                User newUser = userManager.GetUser(user.Id);
                newUser.Password = user.Password;
                if (userManager.UpdatePassword(newUser))
                {
                    return RedirectToAction("index","ProductDetails",newUser);
                }
            }
            return View(user);
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

        protected string  PasswordAndUserNameEmpty(string userName, string password)
        {
            if (userName == "" || password == "")
            {
                return "Lütfen Değerlerinizi kontrol ediniz";
            }
            return "";
        }
    }
}
