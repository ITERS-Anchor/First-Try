using BookShop.Model;
using BookShop.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.DAL
{
    public partial class CartDAL
    {
        // crud
        //public IEnumerable<Cart> GetList()
        //{
        //    string sql = "select * from Cart";
        //    //IList<Cart> list = new List<Cart>();
        //    using (SqlDataReader reader = SqlHelper.ExecuteReader(sql))
        //    {
        //        if (reader.HasRows)
        //        {
        //            while (reader.Read())
        //            {
        //                yield return SqlHelper.MapEntity<Cart>(reader);
        //                //Cart cart = new Cart();
        //                //cart.Id = reader.GetInt32(0);
        //                //list.Add(cart);
        //            }
        //        }
        //    }
        //    //return list;
        //}

        public IEnumerable<CartInfo> GetCartInfos(int userId)
        {
            string sql = @"
select 
	c.Id as CartId
	, b.Id as ProductId
	, b.ISBN as ISBN
	, b.Title as Title
	, b.UnitPrice as Price
	, c.[Count] as [Count]
from
	Cart c
inner join Books b
on c.BookId=b.Id
where c.UserId = @UserId;";
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql, new SqlParameter("@UserId", userId)))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())// 指针下移
                    {
                        //CartInfo entity = new CartInfo();
                        //entity.CartId = reader.GetInt32(reader.GetOrdinal("CartId"));
                        //entity.ProductId = reader.GetInt32(reader.GetOrdinal("ProductId"));
                        //entity.ISBN = reader.GetString(reader.GetOrdinal("ISBN"));
                        //entity.Title = reader.GetString(reader.GetOrdinal("Title"));
                        //entity.Count = reader.GetInt32(reader.GetOrdinal("Count"));
                        CartInfo entity = SqlHelper.MapEntity<CartInfo>(reader);
                        yield return entity;
                    }
                }
            }
        }

        public IEnumerable<CartInfo> GetOfflineCartInfos(params int[] ids)
        {
            string sql = string.Format(@"select 
	Id as ProductId
	, ISBN as ISBN
	, Title as Title
	, UnitPrice as Price from Books where Id in ({0})", string.Join(",", ids));
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())// 指针下移
                    {
                        //CartInfo entity = new CartInfo();
                        //entity.CartId = reader.GetInt32(reader.GetOrdinal("CartId"));
                        //entity.ProductId = reader.GetInt32(reader.GetOrdinal("ProductId"));
                        //entity.ISBN = reader.GetString(reader.GetOrdinal("ISBN"));
                        //entity.Title = reader.GetString(reader.GetOrdinal("Title"));
                        //entity.Count = reader.GetInt32(reader.GetOrdinal("Count"));
                        CartInfo entity = SqlHelper.MapEntity<CartInfo>(reader);
                        yield return entity;
                    }
                }
            }
        }

    }
}
