using SalesPanelApp.Dal;
using SalesPanelApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesPanelApp.Business
{
    public class AdminBoardManager 
    {
        public List<AdminBoardDto> GetAll()
        {
            using (BrandContext context = new BrandContext())
            {
                var result = from p in context.Products
                             join b in context.Brands on p.BrandId equals b.BrandId
                             select new AdminBoardDto
                             {
                                 ProductName = p.ProductName,
                                 ProductCode = p.ProductCode,
                                 BrandName = b.BrandName,


                             };

                return result.ToList();
            }
        }
    }

}