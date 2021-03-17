using System.Linq;
using System.Web;

namespace SalesPanelApp.Models
{
    public class AdminBoardDto 
    {
        public string ProductName { get; set; }
        public int ProductId { get; set; }
        public int? ProductCode { get; set; }
        public string BrandName { get; set; }
    }
}