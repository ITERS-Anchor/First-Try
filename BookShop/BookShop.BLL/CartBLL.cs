using BookShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.BLL
{
    public partial class CartBLL
    {
        public IEnumerable<CartInfo> GetCartInfos(int userId)
        {
            return _dao.GetCartInfos(userId);
        }
        public IEnumerable<CartInfo> GetOfflineCartInfos(params int[] ids)
        {
            return _dao.GetOfflineCartInfos(ids);
        }
    }
}
