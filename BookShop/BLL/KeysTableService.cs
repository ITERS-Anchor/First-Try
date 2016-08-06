using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using BookShop.Model;
namespace BookShop.BLL
{
	/// <summary>
	/// 业务逻辑类KeysTableService 的摘要说明。
	/// </summary>
	public class KeysTableService
	{
		private readonly BookShop.DAL.KeysTableDAL dal=new BookShop.DAL.KeysTableDAL();
		public KeysTableService()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long SurrogateKeyId)
		{
			return dal.Exists(SurrogateKeyId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(BookShop.Model.KeysTable model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(BookShop.Model.KeysTable model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(long SurrogateKeyId)
		{
			
			dal.Delete(SurrogateKeyId);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public BookShop.Model.KeysTable GetModel(long SurrogateKeyId)
		{
			
			return dal.GetModel(SurrogateKeyId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中。
		/// </summary>
		public BookShop.Model.KeysTable GetModelByCache(long SurrogateKeyId)
		{
			
			string CacheKey = "KeysTableModel-" + SurrogateKeyId;
			object objModel = LTP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(SurrogateKeyId);
					if (objModel != null)
					{
						int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
						LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (BookShop.Model.KeysTable)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<BookShop.Model.KeysTable> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<BookShop.Model.KeysTable> DataTableToList(DataTable dt)
		{
			List<BookShop.Model.KeysTable> modelList = new List<BookShop.Model.KeysTable>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				BookShop.Model.KeysTable model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new BookShop.Model.KeysTable();
					//model.Id=dt.Rows[n]["Id"].ToString();
					//model.SurrogateKeyId=dt.Rows[n]["SurrogateKeyId"].ToString();
					//model.SurrogateInstanceId=dt.Rows[n]["SurrogateInstanceId"].ToString();
					if(dt.Rows[n]["EncodingOption"].ToString()!="")
					{
						model.EncodingOption=int.Parse(dt.Rows[n]["EncodingOption"].ToString());
					}
					if(dt.Rows[n]["Properties"].ToString()!="")
					{
						model.Properties=(byte[])dt.Rows[n]["Properties"];
					}
					if(dt.Rows[n]["IsAssociated"].ToString()!="")
					{
						if((dt.Rows[n]["IsAssociated"].ToString()=="1")||(dt.Rows[n]["IsAssociated"].ToString().ToLower()=="true"))
						{
						model.IsAssociated=true;
						}
						else
						{
							model.IsAssociated=false;
						}
					}
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  成员方法
	}
}

