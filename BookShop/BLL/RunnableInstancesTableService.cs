using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using BookShop.Model;
namespace BookShop.BLL
{
	/// <summary>
	/// 业务逻辑类RunnableInstancesTableService 的摘要说明。
	/// </summary>
	public class RunnableInstancesTableService
	{
		private readonly BookShop.DAL.RunnableInstancesTableDAL dal=new BookShop.DAL.RunnableInstancesTableDAL();
		public RunnableInstancesTableService()
		{}
		#region  成员方法

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(BookShop.Model.RunnableInstancesTable model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(BookShop.Model.RunnableInstancesTable model)
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
		public BookShop.Model.RunnableInstancesTable GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			return dal.GetModel();
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中。
		/// </summary>
		public BookShop.Model.RunnableInstancesTable GetModelByCache()
		{
			//该表无主键信息，请自定义主键/条件字段
			string CacheKey = "RunnableInstancesTableModel-" ;
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
			return (BookShop.Model.RunnableInstancesTable)objModel;
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
		public List<BookShop.Model.RunnableInstancesTable> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<BookShop.Model.RunnableInstancesTable> DataTableToList(DataTable dt)
		{
			List<BookShop.Model.RunnableInstancesTable> modelList = new List<BookShop.Model.RunnableInstancesTable>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				BookShop.Model.RunnableInstancesTable model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new BookShop.Model.RunnableInstancesTable();
					//model.SurrogateInstanceId=dt.Rows[n]["SurrogateInstanceId"].ToString();
					//model.WorkflowHostType=dt.Rows[n]["WorkflowHostType"].ToString();
					//model.ServiceDeploymentId=dt.Rows[n]["ServiceDeploymentId"].ToString();
					if(dt.Rows[n]["RunnableTime"].ToString()!="")
					{
						model.RunnableTime=DateTime.Parse(dt.Rows[n]["RunnableTime"].ToString());
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

