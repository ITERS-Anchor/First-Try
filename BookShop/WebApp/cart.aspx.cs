using BookShop.BLL;
using BookShop.Model;
using BookShop.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class cart : BasePage
    {
        CartBLL cartbll = new CartBLL();
        BooksBLL bookbll = new BooksBLL();
        public IEnumerable<CartInfo> CartList { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsSignIn)
            {
                OnlineCart();
            }
            else
            {
                OfflineCart();
            }

        }        
        /// <summary>
        /// 登陆情况下的购物车
        /// </summary>
        private void OnlineCart()
        {
            int productId;
            if (Int32.TryParse(Request["item"], out productId))
            {
                Books b = bookbll.QuerySingle(productId);
                if (b != null)
                {
                    // db 判断购物车中是否已存在该商品
                    Cart exist = cartbll.QuerySingle(new { BookId = productId, __o = "and", UserId = CurrentUser.Id });
                    if (exist != null)
                    {
                        // 如果已经存在
                        exist.Count += 1;
                        cartbll.Update(exist);
                    }
                    else
                    {
                        // 创建一个购物车对象加入到购物车表中
                        exist = new Cart();
                        exist.BookId = b.Id; // cart是否可能已经存在
                        exist.UserId = CurrentUser.Id;
                        exist.Count = 1;
                        cartbll.Insert(exist);
                    }
                }
            }
            CartList = cartbll.GetCartInfos(CurrentUser.Id);
        }

        /// <summary>
        /// 未登录情况下的购物车
        /// </summary>
        /// Dic
        private void OfflineCart()
        {
            // 1.取现有的购物车信息
            IDictionary<int, int> existDict = CookieHelper.Get<IDictionary<int, int>>("cart_dict") ?? new Dictionary<int, int>();
            #region 添加

            //int productId = Request["item"].ToInt32();
            // 判断是否是添加购物车操作
            int productId;
            if (Int32.TryParse(Request["item"], out productId))
            {
                // 判断ID 的合法性
                Books b = bookbll.QuerySingle(productId);
                if (b != null)
                {
                    // 判断当前购物车中是否已经存在当前这个商品
                    if (existDict.ContainsKey(productId))
                    {
                        // 存在
                        existDict[productId]++;
                    }
                    else
                    {
                        // 不存在
                        existDict.Add(productId, 1);
                    }
                }
            }
            #endregion

            if (existDict.Count > 0)
            {
                CartList = cartbll.GetOfflineCartInfos(existDict.Keys.ToArray()).ToList();

                foreach (var item in CartList)
                {
                    item.Count = existDict[item.ProductId];
                }
            }
            else
            {
                CartList = new List<CartInfo>();
            }
            // 设置回客户端
            CookieHelper.Set("cart_dict", existDict, DateTime.Now.AddYears(1));
        }

        /// <summary>
        /// ""JSON,存在问题
        /// </summary>
        private void OfflineCart1()
        {
            // 1.取现有的购物车信息
            IList<CookieCart> exist = CookieHelper.Get<IList<CookieCart>>("cart_list") ?? new List<CookieCart>();

            //IList<CookieCart> exist = JsonHelper.Deserialize<IList<IList<CookieCart>>>(CookieHelper.Get("cart_list"));
            #region 添加
            int productId;
            if (Int32.TryParse(Request["item"], out productId))
            {
                // 判断ID 的合法性
                Books model = bookbll.QuerySingle(productId);
                if (model != null)
                {
                    bool ex = false;
                    // 判断当前购物车信息中是否已经有该商品
                    foreach (var item in exist)
                    {
                        if (item.ProductId == productId)
                        {
                            ex = true;
                            item.Count++;
                            break;
                        }
                    }
                    if (!ex)
                    {
                        // 当前购物车没有此商品 添加新的
                        exist.Add(new CookieCart() { ProductId = productId, Count = 1 });
                    }
                }
            }
            #endregion
            // 
            int[] existIds = exist.Select(e => e.ProductId).ToArray();
            if (existIds.Length > 0)
            {
                // 购物车有数据
                CartList = cartbll.GetOfflineCartInfos(existIds);
            }
            else
            {
                CartList = new List<CartInfo>();
            }

            CartList = CartList.ToList();
            foreach (var item in CartList)
            {
                item.Count = exist.FirstOrDefault(e => e.ProductId == item.ProductId).Count;
            }
            // 设置回客户端
            CookieHelper.Set("cart_list", exist, DateTime.Now.AddYears(1));

        }

        /// <summary>
        /// 未登录情况下
        /// </summary>
        private void OfflineCart2()
        {
            IDictionary<int, int> dict = new Dictionary<int, int>();

            string cartCookie = CookieHelper.Get("cart_list"); //"1213:1;232123:1;"
                                                               // cookie
            #region 添加逻辑
            // 接收要添加到购物车的商品ID
            int productId;
            if (Int32.TryParse(Request["item"], out productId))
            {
                // 判断ID 的合法性
                Books b = bookbll.QuerySingle(productId);
                if (b != null)
                {
                    // cookie "1213:1;232123:1;"
                    string[] products = cartCookie.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                    //{"1213:1","232123:1"}
                    bool exist = false;
                    #region 由于foreach是只读 所以一下不能用
                    //foreach (var item in products)
                    //{
                    //    // item:"1213:1"
                    //    string[] temp = item.Split(new[] { '：' }, StringSplitOptions.RemoveEmptyEntries); //{"1213","1"}
                    //    if (temp.Length != 2)
                    //        continue;
                    //    if (temp[0] == productId.ToString())
                    //    {
                    //        // 已经存在
                    //        temp[1] = (temp[1].ToInt32() + 1).ToString(); //2
                    //        exist = true;
                    //    }
                    //} 
                    #endregion

                    for (int i = 0; i < products.Length; i++)
                    {
                        string item = products[i]; // item:"1213:1"
                        string[] temp = item.Split(new[] { '：' }, StringSplitOptions.RemoveEmptyEntries); //{"1213","1"}
                        if (temp.Length != 2)
                            continue;
                        if (temp[0] == productId.ToString())
                        {
                            // 已经存在
                            temp[1] = (Convert.ToInt32(temp[1]) + 1).ToString(); //2
                            exist = true;
                            products[i] = string.Join(":", temp);// "1213:2"
                        }//{"1213:2","232123:1"}
                        // 添加到列表中
                        dict.Add(Convert.ToInt32(temp[0]), Convert.ToInt32(temp[1]));
                    }

                    if (!exist)
                    {
                        // 新添加
                        cartCookie = string.Format("{0}{1}:{2};", cartCookie, productId, 1);
                        dict.Add(productId, 1);
                    }
                    else
                    {
                        // 修改现有的购物车信息
                        cartCookie = string.Join(";", products);
                    }
                    CookieHelper.Set("cart_list", cartCookie, DateTime.Now.AddYears(1));
                }
            }
            #endregion

            // 查询数据
            //if (dict.Count > 0 && !string.IsNullOrEmpty(cartCookie))
            //{
            //    CartList = _cartService.GetOfflineCartInfos(dict.Keys.ToArray());
            //    foreach (var item in CartList)
            //    {
            //        item.Count = dict[item.ProductId];
            //    }
            //}
            //else
            //{
            //    CartList = new List<CartInfo>();
            //}

            // 判断当前购物车是否有数据
            if (dict.Count == 0)
            {
                // 如果这个
                if (string.IsNullOrEmpty(cartCookie))
                {
                    CartList = new List<CartInfo>();
                }
                else
                {
                    string[] products = cartCookie.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var item in products)
                    {
                        string[] temp = item.Split(':');
                        dict.Add(Convert.ToInt32(temp[0]), Convert.ToInt32(temp[1]));
                    }
                    CartList = cartbll.GetOfflineCartInfos(dict.Keys.ToArray());
                    // foreach 不可以修改 成员属性
                    // foreach (var item in CartList)
                    // {
                    //     item.Count = dict[item.ProductId];
                    // }
                }
            }
            else
            {
                CartList = cartbll.GetOfflineCartInfos(dict.Keys.ToArray());
                // foreach 不可以修改 成员属性
                //foreach (var item in CartList)
                //{
                //    item.Count = dict[item.ProductId];
                //}
            }
        }

    }
    class CookieCart
    {
        public int ProductId { get; set; }
        public int Count { get; set; }
    }
}