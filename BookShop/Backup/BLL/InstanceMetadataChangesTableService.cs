using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using BookShop.Model;
namespace BookShop.BLL
{
	/// <summary>
	/// 业务逻辑类InstanceMetadataChangesTableService 的摘要说明。
	/// </summary>
	public class InstanceMetadataChangesTableService
	{
		private readonly BookShop.DAL.InstanceMetadataChangesTableDAL dal=new BookShop.DAL.InstanceMetadataChangesTableDAL();
		public InstanceMetadataChangesTableService()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long ChangeTime)
		{
			return dal.Exists(ChangeTime);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(BookShop.Model.InstanceMetadataChangesTable model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(BookShop.Model.InstanceMetadataChangesTable model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(long ChangeTime)
		{
			
			dal.Delete(ChangeTime);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public BookShop.Model.InstanceMetadataChangesTable GetModel(long ChangeTime)
		{
			
			return dal.GetModel(ChangeTime);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中。
		/// </summary>
		public BookShop.Model.InstanceMetadataChangesTable GetModelByCache(long ChangeTime)
		{
			
			string CacheKey = "InstanceMetadataChangesTableModel-" + ChangeTime;
			object objModel = LTP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(ChangeTime);
					if (objModel != null)
					{
						int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
						LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (BookShop.Model.InstanceMetadataChangesTable)objModel;
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
		public List<BookShop.Model.InstanceMetadataChangesTable> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<BookShop.Model.InstanceMetadataChangesTable> DataTableToList(DataTable dt)
		{
			List<BookShop.Model.InstanceMetadataChangesTable> modelList = new List<BookShop.Model.InstanceMetadataChangesTable>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				BookShop.Model.InstanceMetadataChangesTable model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new BookShop.Model.InstanceMetadataChangesTable();
					//model.SurrogateInstanceId=dt.Rows[n]["SurrogateInstanceId"].ToString();
					//model.ChangeTime=dt.Rows[n]["ChangeTime"].ToString();
					if(dt.Rows[n]["EncodingOption"].ToString()!="")
					{
						model.EncodingOption=int.Parse(dt.Rows[n]["EncodingOption"].ToString());
					}
					if(dt.Rows[n]["Change"].ToString()!="")
					{
						model.Change=(byte[])dt.Rows[n]["Change"];
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

