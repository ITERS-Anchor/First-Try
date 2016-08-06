using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using BookShop.Model;
namespace BookShop.BLL
{
	/// <summary>
	/// 业务逻辑类ServiceDeploymentsTableService 的摘要说明。
	/// </summary>
	public class ServiceDeploymentsTableService
	{
		private readonly BookShop.DAL.ServiceDeploymentsTableDAL dal=new BookShop.DAL.ServiceDeploymentsTableDAL();
		public ServiceDeploymentsTableService()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long Id)
		{
			return dal.Exists(Id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(BookShop.Model.ServiceDeploymentsTable model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(BookShop.Model.ServiceDeploymentsTable model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(long Id)
		{
			
			dal.Delete(Id);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public BookShop.Model.ServiceDeploymentsTable GetModel(long Id)
		{
			
			return dal.GetModel(Id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中。
		/// </summary>
		public BookShop.Model.ServiceDeploymentsTable GetModelByCache(long Id)
		{
			
			string CacheKey = "ServiceDeploymentsTableModel-" + Id;
			object objModel = LTP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Id);
					if (objModel != null)
					{
						int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
						LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (BookShop.Model.ServiceDeploymentsTable)objModel;
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
		public List<BookShop.Model.ServiceDeploymentsTable> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<BookShop.Model.ServiceDeploymentsTable> DataTableToList(DataTable dt)
		{
			List<BookShop.Model.ServiceDeploymentsTable> modelList = new List<BookShop.Model.ServiceDeploymentsTable>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				BookShop.Model.ServiceDeploymentsTable model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new BookShop.Model.ServiceDeploymentsTable();
					//model.Id=dt.Rows[n]["Id"].ToString();
					//model.ServiceDeploymentHash=dt.Rows[n]["ServiceDeploymentHash"].ToString();
					model.SiteName=dt.Rows[n]["SiteName"].ToString();
					model.RelativeServicePath=dt.Rows[n]["RelativeServicePath"].ToString();
					model.RelativeApplicationPath=dt.Rows[n]["RelativeApplicationPath"].ToString();
					model.ServiceName=dt.Rows[n]["ServiceName"].ToString();
					model.ServiceNamespace=dt.Rows[n]["ServiceNamespace"].ToString();
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

