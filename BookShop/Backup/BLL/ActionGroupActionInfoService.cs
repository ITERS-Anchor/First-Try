using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using BookShop.Model;
namespace BookShop.BLL
{
	/// <summary>
	/// 业务逻辑类ActionGroupActionInfoService 的摘要说明。
	/// </summary>
	public class ActionGroupActionInfoService
	{
		private readonly BookShop.DAL.ActionGroupActionInfoDAL dal=new BookShop.DAL.ActionGroupActionInfoDAL();
		public ActionGroupActionInfoService()
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
		public bool Exists(int ActionGroup_ID,int ActionInfo_ID)
		{
			return dal.Exists(ActionGroup_ID,ActionInfo_ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(BookShop.Model.ActionGroupActionInfo model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(BookShop.Model.ActionGroupActionInfo model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ActionGroup_ID,int ActionInfo_ID)
		{
			
			dal.Delete(ActionGroup_ID,ActionInfo_ID);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public BookShop.Model.ActionGroupActionInfo GetModel(int ActionGroup_ID,int ActionInfo_ID)
		{
			
			return dal.GetModel(ActionGroup_ID,ActionInfo_ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中。
		/// </summary>
		public BookShop.Model.ActionGroupActionInfo GetModelByCache(int ActionGroup_ID,int ActionInfo_ID)
		{
			
			string CacheKey = "ActionGroupActionInfoModel-" + ActionGroup_ID+ActionInfo_ID;
			object objModel = LTP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(ActionGroup_ID,ActionInfo_ID);
					if (objModel != null)
					{
						int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
						LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (BookShop.Model.ActionGroupActionInfo)objModel;
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
		public List<BookShop.Model.ActionGroupActionInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<BookShop.Model.ActionGroupActionInfo> DataTableToList(DataTable dt)
		{
			List<BookShop.Model.ActionGroupActionInfo> modelList = new List<BookShop.Model.ActionGroupActionInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				BookShop.Model.ActionGroupActionInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new BookShop.Model.ActionGroupActionInfo();
					if(dt.Rows[n]["ActionGroup_ID"].ToString()!="")
					{
						model.ActionGroup_ID=int.Parse(dt.Rows[n]["ActionGroup_ID"].ToString());
					}
					if(dt.Rows[n]["ActionInfo_ID"].ToString()!="")
					{
						model.ActionInfo_ID=int.Parse(dt.Rows[n]["ActionInfo_ID"].ToString());
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

