using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Model
{
    public class CartInfo
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
    }
}
