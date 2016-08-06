using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using BookShop.Model;
namespace BookShop.BLL
{
	/// <summary>
	/// 业务逻辑类UserInfoRoleService 的摘要说明。
	/// </summary>
	public class UserInfoRoleService
	{
		private readonly BookShop.DAL.UserInfoRoleDAL dal=new BookShop.DAL.UserInfoRoleDAL();
		public UserInfoRoleService()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int UserInfo_ID,int Role_ID)
		{
			return dal.Exists(UserInfo_ID,Role_ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(BookShop.Model.UserInfoRole model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(BookShop.Model.UserInfoRole model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int UserInfo_ID,int Role_ID)
		{
			
			dal.Delete(UserInfo_ID,Role_ID);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public BookShop.Model.UserInfoRole GetModel(int UserInfo_ID,int Role_ID)
		{
			
			return dal.GetModel(UserInfo_ID,Role_ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中。
		/// </summary>
		public BookShop.Model.UserInfoRole GetModelByCache(int UserInfo_ID,int Role_ID)
		{
			
			string CacheKey = "UserInfoRoleModel-" + UserInfo_ID+Role_ID;
			object objModel = LTP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(UserInfo_ID,Role_ID);
					if (objModel != null)
					{
						int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
						LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (BookShop.Model.UserInfoRole)objModel;
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
		public List<BookShop.Model.UserInfoRole> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<BookShop.Model.UserInfoRole> DataTableToList(DataTable dt)
		{
			List<BookShop.Model.UserInfoRole> modelList = new List<BookShop.Model.UserInfoRole>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				BookShop.Model.UserInfoRole model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new BookShop.Model.UserInfoRole();
					if(dt.Rows[n]["UserInfo_ID"].ToString()!="")
					{
						model.UserInfo_ID=int.Parse(dt.Rows[n]["UserInfo_ID"].ToString());
					}
					if(dt.Rows[n]["Role_ID"].ToString()!="")
					{
						model.Role_ID=int.Parse(dt.Rows[n]["Role_ID"].ToString());
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

