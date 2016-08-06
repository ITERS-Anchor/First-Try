using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using BookShop.Model;
namespace BookShop.BLL
{
	/// <summary>
	/// 业务逻辑类RoleDepartmentService 的摘要说明。
	/// </summary>
	public class RoleDepartmentService
	{
		private readonly BookShop.DAL.RoleDepartmentDAL dal=new BookShop.DAL.RoleDepartmentDAL();
		public RoleDepartmentService()
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
		public bool Exists(int Role_ID,int Department_ID)
		{
			return dal.Exists(Role_ID,Department_ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(BookShop.Model.RoleDepartment model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(BookShop.Model.RoleDepartment model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int Role_ID,int Department_ID)
		{
			
			dal.Delete(Role_ID,Department_ID);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public BookShop.Model.RoleDepartment GetModel(int Role_ID,int Department_ID)
		{
			
			return dal.GetModel(Role_ID,Department_ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中。
		/// </summary>
		public BookShop.Model.RoleDepartment GetModelByCache(int Role_ID,int Department_ID)
		{
			
			string CacheKey = "RoleDepartmentModel-" + Role_ID+Department_ID;
			object objModel = LTP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Role_ID,Department_ID);
					if (objModel != null)
					{
						int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
						LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (BookShop.Model.RoleDepartment)objModel;
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
		public List<BookShop.Model.RoleDepartment> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<BookShop.Model.RoleDepartment> DataTableToList(DataTable dt)
		{
			List<BookShop.Model.RoleDepartment> modelList = new List<BookShop.Model.RoleDepartment>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				BookShop.Model.RoleDepartment model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new BookShop.Model.RoleDepartment();
					if(dt.Rows[n]["Role_ID"].ToString()!="")
					{
						model.Role_ID=int.Parse(dt.Rows[n]["Role_ID"].ToString());
					}
					if(dt.Rows[n]["Department_ID"].ToString()!="")
					{
						model.Department_ID=int.Parse(dt.Rows[n]["Department_ID"].ToString());
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

