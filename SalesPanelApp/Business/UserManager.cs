using SalesPanelApp.Dal;
using SalesPanelApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SalesPanelApp.Business
{
    public class UserManager
    {
        public User CheckUser(User user)
        {
            using (BrandContext context = new BrandContext())
            {
                var FindedUser = context.Users.Where(u => u.UserName.Equals(user.UserName) && u.Password.Equals(user.Password)).FirstOrDefault();
                return FindedUser;
            }
        }

        public User GetUser(int? id)
        {
            using (BrandContext context = new BrandContext())
            {
                var FindedUser = context.Users.Find(id);
                return FindedUser;
            }
        }

        public bool UpdatePassword(User user)
        {
            using (BrandContext context = new BrandContext())
            {

                context.Entry(user).State = EntityState.Modified;
                context.SaveChanges();
                return true;
            }
        }
    }
}