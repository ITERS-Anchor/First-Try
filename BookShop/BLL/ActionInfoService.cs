using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using BookShop.Model;
namespace BookShop.BLL
{
	/// <summary>
	/// 业务逻辑类ActionInfoService 的摘要说明。
	/// </summary>
	public class ActionInfoService
	{
		private readonly BookShop.DAL.ActionInfoDAL dal=new BookShop.DAL.ActionInfoDAL();
		public ActionInfoService()
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
		public bool Exists(int ID)
		{
			return dal.Exists(ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(BookShop.Model.ActionInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(BookShop.Model.ActionInfo model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			
			dal.Delete(ID);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public BookShop.Model.ActionInfo GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中。
		/// </summary>
		public BookShop.Model.ActionInfo GetModelByCache(int ID)
		{
			
			string CacheKey = "ActionInfoModel-" + ID;
			object objModel = LTP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(ID);
					if (objModel != null)
					{
						int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
						LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (BookShop.Model.ActionInfo)objModel;
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
		public List<BookShop.Model.ActionInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<BookShop.Model.ActionInfo> DataTableToList(DataTable dt)
		{
			List<BookShop.Model.ActionInfo> modelList = new List<BookShop.Model.ActionInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				BookShop.Model.ActionInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new BookShop.Model.ActionInfo();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					model.ActionInfoName=dt.Rows[n]["ActionInfoName"].ToString();
					model.Url=dt.Rows[n]["Url"].ToString();
					if(dt.Rows[n]["HttpMethod"].ToString()!="")
					{
						model.HttpMethod=int.Parse(dt.Rows[n]["HttpMethod"].ToString());
					}
					model.Remark=dt.Rows[n]["Remark"].ToString();
					if(dt.Rows[n]["DelFalg"].ToString()!="")
					{
						model.DelFalg=int.Parse(dt.Rows[n]["DelFalg"].ToString());
					}
					if(dt.Rows[n]["SubTime"].ToString()!="")
					{
						model.SubTime=DateTime.Parse(dt.Rows[n]["SubTime"].ToString());
					}
					if(dt.Rows[n]["IsMenu"].ToString()!="")
					{
						if((dt.Rows[n]["IsMenu"].ToString()=="1")||(dt.Rows[n]["IsMenu"].ToString().ToLower()=="true"))
						{
						model.IsMenu=true;
						}
						else
						{
							model.IsMenu=false;
						}
					}
					if(dt.Rows[n]["R_UserInfo_ActionInfoID"].ToString()!="")
					{
						model.R_UserInfo_ActionInfoID=int.Parse(dt.Rows[n]["R_UserInfo_ActionInfoID"].ToString());
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

