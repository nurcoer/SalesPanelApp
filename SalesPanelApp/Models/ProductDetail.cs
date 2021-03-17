using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SalesPanelApp.Models
{ 
    public class ProductDetail
    {
        public int ProductDetailId { get; set; }
        public int ProductId { get; set; }

        public string Mount { get; set; }
        public decimal UnitPrice { get; set; }


    }
}