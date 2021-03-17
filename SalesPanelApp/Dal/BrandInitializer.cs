using SalesPanelApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesPanelApp.Dal
{
    public class BrandInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BrandContext>
    {
        protected override void Seed(BrandContext context)
        {
            var users = new List<User>
                    {
                    new User{Id=1, Email="kkk@gmail.com", UserName="Nur", Password= "12345"},
                    new User{Id=2, Email="kk1@gmail.com", UserName="Ali", Password= "123456789"},
                    new User{Id=3, Email="kk2@gmail.com", UserName="Hakan", Password= "987654"},
                    };

            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();
            var operationClaims = new List<OperationClaim>
                    {
                    new OperationClaim{Id= 1, Name= "admin"},
                    new OperationClaim{Id= 2, Name= "Owner"},
                    };
            operationClaims.ForEach(oc => context.OperationClaims.Add(oc));
            context.SaveChanges();
            var userOperationClaims = new List<UserOperationClaim>
                    {
                    new UserOperationClaim {Id=1, OperationClaimId=1, UserId= 1},
                    new UserOperationClaim {Id=2, OperationClaimId=2, UserId= 2},
                    new UserOperationClaim {Id=3, OperationClaimId=2, UserId= 3},
                    };
            userOperationClaims.ForEach(uo => context.UserOperationClaims.Add(uo));
            context.SaveChanges();
            var productDetails = new List<ProductDetail>
                    {
                    new ProductDetail {ProductDetailId=1, ProductId = 1, UnitPrice = 220.000M, Mount = "Şubat" },
                                      new ProductDetail {ProductDetailId=2, ProductId = 1,  UnitPrice = 200.000M, Mount = "Mart"},
                                        new ProductDetail { ProductDetailId=3, ProductId = 1,  UnitPrice = 100.000M, Mount = "Nisan" },
                                        new ProductDetail { ProductDetailId=4, ProductId = 1,  UnitPrice = 100.000M, Mount = "Mayıs" },
                                        new ProductDetail { ProductDetailId=5, ProductId = 1,  UnitPrice = 160.000M, Mount = "Haziran"},
                                        new ProductDetail { ProductDetailId=6, ProductId = 1,  UnitPrice = 145.000M, Mount = "Temmuz" },
                                        new ProductDetail { ProductDetailId=7, ProductId = 1,  UnitPrice = 145.000M, Mount = "Ağustos"},
                                        new ProductDetail { ProductDetailId=8, ProductId = 1,  UnitPrice = 150.000M, Mount = "Eylül"},
                                        new ProductDetail { ProductDetailId=9, ProductId = 1,  UnitPrice = 160.000M, Mount = "Ekim"},
                                        new ProductDetail { ProductDetailId=10, ProductId = 1,  UnitPrice = 165.000M, Mount = "Kasım "},
                                        new ProductDetail { ProductDetailId=11, ProductId = 1,  UnitPrice = 170.000M, Mount = "Aralık"},
                                        new ProductDetail { ProductDetailId=12, ProductId = 1,  UnitPrice = 170.000M, Mount = "Ocak"},


                                        new ProductDetail {ProductDetailId=13, ProductId = 2, UnitPrice = 220.000M, Mount = "Şubat "},
                                      new ProductDetail {ProductDetailId=14, ProductId = 2,  UnitPrice = 200.000M, Mount = "Mart"},
                                        new ProductDetail { ProductDetailId=15, ProductId = 2,  UnitPrice = 150.000M, Mount = "Nisan" },
                                        new ProductDetail { ProductDetailId=16, ProductId = 2,  UnitPrice = 100.000M, Mount = "Mayıs "},
                                        new ProductDetail { ProductDetailId=17, ProductId = 2,  UnitPrice = 160.000M, Mount = "Haziran"},
                                        new ProductDetail { ProductDetailId=18, ProductId = 2,  UnitPrice = 145.000M, Mount = "Temmuz "},
                                        new ProductDetail { ProductDetailId=19, ProductId = 2,  UnitPrice = 145.000M, Mount = "Ağustos"},
                                        new ProductDetail { ProductDetailId=20, ProductId = 2,  UnitPrice = 150.000M, Mount = "Eylül"},
                                        new ProductDetail { ProductDetailId=21, ProductId = 2,  UnitPrice = 160.000M, Mount = "Ekim"},
                                        new ProductDetail { ProductDetailId=22, ProductId = 2,  UnitPrice = 165.000M, Mount = "Kasım "},
                                        new ProductDetail { ProductDetailId=23, ProductId = 2,  UnitPrice = 170.000M, Mount = "Aralık"},
                                        new ProductDetail { ProductDetailId=24, ProductId = 2,  UnitPrice = 170.000M, Mount = "Ocak"},


                                        new ProductDetail {ProductDetailId=25, ProductId = 3, UnitPrice = 220.000M, Mount = "Şubat "},
                                      new ProductDetail {ProductDetailId=26, ProductId = 3,  UnitPrice = 200.000M, Mount = "Mart"},
                                        new ProductDetail { ProductDetailId=27, ProductId = 3,  UnitPrice = 150.000M, Mount = "Nisan" },
                                        new ProductDetail { ProductDetailId=28, ProductId = 3,  UnitPrice = 100.000M, Mount = "Mayıs "},
                                        new ProductDetail { ProductDetailId=29, ProductId = 3,  UnitPrice = 160.000M, Mount = "Haziran"},
                                        new ProductDetail { ProductDetailId=30, ProductId = 3,  UnitPrice = 145.000M, Mount = "Temmuz "},
                                        new ProductDetail { ProductDetailId=31, ProductId = 3,  UnitPrice = 145.000M, Mount = "Ağustos"},
                                        new ProductDetail { ProductDetailId=32, ProductId = 3,  UnitPrice = 150.000M, Mount = "Eylül"},
                                        new ProductDetail { ProductDetailId=33, ProductId = 3,  UnitPrice = 160.000M, Mount = "Ekim"},
                                        new ProductDetail { ProductDetailId=34, ProductId = 3,  UnitPrice = 165.000M, Mount = "Kasım "},
                                        new ProductDetail { ProductDetailId=35, ProductId = 3,  UnitPrice = 170.000M, Mount = "Aralık"},
                                        new ProductDetail { ProductDetailId=36, ProductId = 3,  UnitPrice = 170.000M, Mount = "Ocak"},


                                        new ProductDetail {ProductDetailId=37, ProductId = 4, UnitPrice = 220.000M, Mount = "Şubat, " },
                                      new ProductDetail {ProductDetailId=38, ProductId = 4, UnitPrice = 200.000M, Mount = "Mart"},
                                        new ProductDetail { ProductDetailId=39, ProductId = 4,  UnitPrice = 150.000M, Mount = "Nisan" },
                                        new ProductDetail { ProductDetailId=40, ProductId = 4,  UnitPrice = 100.000M, Mount = "Mayıs "},
                                        new ProductDetail { ProductDetailId=41, ProductId = 4,  UnitPrice = 160.000M, Mount = "Haziran"},
                                        new ProductDetail { ProductDetailId=42, ProductId = 4,  UnitPrice = 145.000M, Mount = "Temmuz "},
                                        new ProductDetail { ProductDetailId=43, ProductId = 4,  UnitPrice = 145.000M, Mount = "Ağustos"},
                                        new ProductDetail { ProductDetailId=44, ProductId = 4,  UnitPrice = 150.000M, Mount = "Eylül"},
                                        new ProductDetail { ProductDetailId=45, ProductId = 4,  UnitPrice = 160.000M, Mount = "Ekim"},
                                        new ProductDetail { ProductDetailId=46, ProductId = 4,  UnitPrice = 165.000M, Mount = "Kasım" },
                                        new ProductDetail { ProductDetailId=47, ProductId = 4,  UnitPrice = 170.000M, Mount = "Aralık"},
                                        new ProductDetail { ProductDetailId=48, ProductId = 4,  UnitPrice = 170.000M, Mount = "Ocak"},
                };
            productDetails.ForEach(p => context.ProductDetails.Add(p));
            context.SaveChanges();
            var products = new List<Product>
                    {
                    new Product{ProductId= 1, ProductName="product1", BrandId = 1},
                    new Product{ProductId= 2, ProductName="product2", BrandId = 1},
                    new Product{ProductId= 3, ProductName="product1", BrandId = 2},
                    new Product{ProductId= 4, ProductName="product2", BrandId = 2},

                    };
            products.ForEach(p => context.Products.Add(p));
            context.SaveChanges();
            var brands = new List<Brand>
                    {
                    new Brand{BrandId=1, BrandName="LcWaikiki", ownerOperationClaimId = 2},
                    new Brand{BrandId=2, BrandName="Teknosa", ownerOperationClaimId = 3},
                    };
            brands.ForEach(b => context.Brands.Add(b));
            context.SaveChanges();
        }
    }
}