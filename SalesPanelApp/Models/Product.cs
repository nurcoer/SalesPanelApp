using System.Collections.Generic;

namespace SalesPanelApp.Models
{
    public class Product 
    {
        public int ProductId { get; set; }
        public int BrandId { get; set; }
        public string ProductName { get; set; }
        public int? ProductCode { get; set; }
    }
}