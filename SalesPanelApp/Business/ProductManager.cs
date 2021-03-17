using SalesPanelApp.Dal;
using SalesPanelApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesPanelApp.Business
{
    public class ProductManager 
    {
        public List<AdminBoardDto> GetAll(User user)
        {
                string UserRole = CheckUserRole(user.Id);
                if (UserRole == "admin")
                {
                    return GetAllProject();
                }
                else
                {
                    return GetAllProjectById(user.Id);
                }
        }

        public List<ProductDto> GetByIdProject(int? id)
        {
            using (BrandContext context = new BrandContext())
            {
                var ProjectList = from p in context.Products
                                  join pd in context.ProductDetails on p.ProductId equals pd.ProductId
                                  where p.ProductId == id
                                  select new ProductDto
                                  {
                                      ProductId = p.ProductId,
                                      ProductName = p.ProductName,
                                      UnitPrice = pd.UnitPrice,
                                      Mount = pd.Mount
                                  };

                return ProjectList.ToList();
            }
        }

        private List<AdminBoardDto> GetAllProject()
        {
            using (BrandContext context = new BrandContext())
            {
                var ProjectList = from b in context.Brands
                                  join p in context.Products on b.BrandId equals p.BrandId
                                  select new AdminBoardDto
                                  {
                                      ProductId=p.ProductId,
                                      BrandName = b.BrandName,
                                      ProductCode = p.ProductCode,
                                      ProductName = p.ProductName
                                  };

                return ProjectList.ToList();
            }
        }

        private List<AdminBoardDto> GetAllProjectById(int? id)
        {
            using (BrandContext context = new BrandContext())
            {
                var ProjectList = from b in context.Brands
                               join p in context.Products on b.BrandId equals p.BrandId
                               where b.ownerOperationClaimId == id
                               select new AdminBoardDto
                               {
                                   ProductId=p.ProductId,
                                   BrandName=b.BrandName,
                                   ProductCode=p.ProductCode,
                                   ProductName=p.ProductName
                               };

                return ProjectList.ToList();
            }
        }

        private string CheckUserRole(int id)
        {
            using (BrandContext context = new BrandContext())
            {
                var UserRole = from u in context.Users
                               join uoc in context.UserOperationClaims on u.Id equals uoc.UserId
                               join oc in context.OperationClaims on uoc.OperationClaimId equals oc.Id
                               where u.Id == id
                               select oc.Name;
                               

                return UserRole.SingleOrDefault();
            }
        }
    }
}