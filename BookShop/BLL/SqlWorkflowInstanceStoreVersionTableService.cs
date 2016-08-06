using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using BookShop.Model;
namespace BookShop.BLL
{
	/// <summary>
	/// 业务逻辑类SqlWorkflowInstanceStoreVersionTableService 的摘要说明。
	/// </summary>
	public class SqlWorkflowInstanceStoreVersionTableService
	{
		private readonly BookShop.DAL.SqlWorkflowInstanceStoreVersionTableDAL dal=new BookShop.DAL.SqlWorkflowInstanceStoreVersionTableDAL();
		public SqlWorkflowInstanceStoreVersionTableService()
		{}
		#region  成员方法

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(BookShop.Model.SqlWorkflowInstanceStoreVersionTable model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(BookShop.Model.SqlWorkflowInstanceStoreVersionTable model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			dal.Delete();
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public BookShop.Model.SqlWorkflowInstanceStoreVersionTable GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			return dal.GetModel();
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中。
		/// </summary>
		public BookShop.Model.SqlWorkflowInstanceStoreVersionTable GetModelByCache()
		{
			//该表无主键信息，请自定义主键/条件字段
			string CacheKey = "SqlWorkflowInstanceStoreVersionTableModel-" ;
			object objModel = LTP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel();
					if (objModel != null)
					{
						int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
						LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (BookShop.Model.SqlWorkflowInstanceStoreVersionTable)objModel;
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
		public List<BookShop.Model.SqlWorkflowInstanceStoreVersionTable> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<BookShop.Model.SqlWorkflowInstanceStoreVersionTable> DataTableToList(DataTable dt)
		{
			List<BookShop.Model.SqlWorkflowInstanceStoreVersionTable> modelList = new List<BookShop.Model.SqlWorkflowInstanceStoreVersionTable>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				BookShop.Model.SqlWorkflowInstanceStoreVersionTable model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new BookShop.Model.SqlWorkflowInstanceStoreVersionTable();
					//model.Major=dt.Rows[n]["Major"].ToString();
					//model.Minor=dt.Rows[n]["Minor"].ToString();
					//model.Build=dt.Rows[n]["Build"].ToString();
					//model.Revision=dt.Rows[n]["Revision"].ToString();
					if(dt.Rows[n]["LastUpdated"].ToString()!="")
					{
						model.LastUpdated=DateTime.Parse(dt.Rows[n]["LastUpdated"].ToString());
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

