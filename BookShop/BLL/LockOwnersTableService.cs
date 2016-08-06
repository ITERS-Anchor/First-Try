using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using BookShop.Model;
namespace BookShop.BLL
{
	/// <summary>
	/// 业务逻辑类LockOwnersTableService 的摘要说明。
	/// </summary>
	public class LockOwnersTableService
	{
		private readonly BookShop.DAL.LockOwnersTableDAL dal=new BookShop.DAL.LockOwnersTableDAL();
		public LockOwnersTableService()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long SurrogateLockOwnerId)
		{
			return dal.Exists(SurrogateLockOwnerId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(BookShop.Model.LockOwnersTable model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(BookShop.Model.LockOwnersTable model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(long SurrogateLockOwnerId)
		{
			
			dal.Delete(SurrogateLockOwnerId);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public BookShop.Model.LockOwnersTable GetModel(long SurrogateLockOwnerId)
		{
			
			return dal.GetModel(SurrogateLockOwnerId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中。
		/// </summary>
		public BookShop.Model.LockOwnersTable GetModelByCache(long SurrogateLockOwnerId)
		{
			
			string CacheKey = "LockOwnersTableModel-" + SurrogateLockOwnerId;
			object objModel = LTP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(SurrogateLockOwnerId);
					if (objModel != null)
					{
						int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
						LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (BookShop.Model.LockOwnersTable)objModel;
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
		public List<BookShop.Model.LockOwnersTable> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<BookShop.Model.LockOwnersTable> DataTableToList(DataTable dt)
		{
			List<BookShop.Model.LockOwnersTable> modelList = new List<BookShop.Model.LockOwnersTable>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				BookShop.Model.LockOwnersTable model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new BookShop.Model.LockOwnersTable();
					//model.Id=dt.Rows[n]["Id"].ToString();
					//model.SurrogateLockOwnerId=dt.Rows[n]["SurrogateLockOwnerId"].ToString();
					if(dt.Rows[n]["LockExpiration"].ToString()!="")
					{
						model.LockExpiration=DateTime.Parse(dt.Rows[n]["LockExpiration"].ToString());
					}
					//model.WorkflowHostType=dt.Rows[n]["WorkflowHostType"].ToString();
					model.MachineName=dt.Rows[n]["MachineName"].ToString();
					if(dt.Rows[n]["EnqueueCommand"].ToString()!="")
					{
						if((dt.Rows[n]["EnqueueCommand"].ToString()=="1")||(dt.Rows[n]["EnqueueCommand"].ToString().ToLower()=="true"))
						{
						model.EnqueueCommand=true;
						}
						else
						{
							model.EnqueueCommand=false;
						}
					}
					if(dt.Rows[n]["DeletesInstanceOnCompletion"].ToString()!="")
					{
						if((dt.Rows[n]["DeletesInstanceOnCompletion"].ToString()=="1")||(dt.Rows[n]["DeletesInstanceOnCompletion"].ToString().ToLower()=="true"))
						{
						model.DeletesInstanceOnCompletion=true;
						}
						else
						{
							model.DeletesInstanceOnCompletion=false;
						}
					}
					if(dt.Rows[n]["PrimitiveLockOwnerData"].ToString()!="")
					{
						model.PrimitiveLockOwnerData=(byte[])dt.Rows[n]["PrimitiveLockOwnerData"];
					}
					if(dt.Rows[n]["ComplexLockOwnerData"].ToString()!="")
					{
						model.ComplexLockOwnerData=(byte[])dt.Rows[n]["ComplexLockOwnerData"];
					}
					if(dt.Rows[n]["WriteOnlyPrimitiveLockOwnerData"].ToString()!="")
					{
						model.WriteOnlyPrimitiveLockOwnerData=(byte[])dt.Rows[n]["WriteOnlyPrimitiveLockOwnerData"];
					}
					if(dt.Rows[n]["WriteOnlyComplexLockOwnerData"].ToString()!="")
					{
						model.WriteOnlyComplexLockOwnerData=(byte[])dt.Rows[n]["WriteOnlyComplexLockOwnerData"];
					}
					if(dt.Rows[n]["EncodingOption"].ToString()!="")
					{
						model.EncodingOption=int.Parse(dt.Rows[n]["EncodingOption"].ToString());
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

