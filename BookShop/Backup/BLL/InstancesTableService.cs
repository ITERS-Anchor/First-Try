using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using BookShop.Model;
namespace BookShop.BLL
{
	/// <summary>
	/// 业务逻辑类InstancesTableService 的摘要说明。
	/// </summary>
	public class InstancesTableService
	{
		private readonly BookShop.DAL.InstancesTableDAL dal=new BookShop.DAL.InstancesTableDAL();
		public InstancesTableService()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long SurrogateInstanceId)
		{
			return dal.Exists(SurrogateInstanceId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(BookShop.Model.InstancesTable model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(BookShop.Model.InstancesTable model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(long SurrogateInstanceId)
		{
			
			dal.Delete(SurrogateInstanceId);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public BookShop.Model.InstancesTable GetModel(long SurrogateInstanceId)
		{
			
			return dal.GetModel(SurrogateInstanceId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中。
		/// </summary>
		public BookShop.Model.InstancesTable GetModelByCache(long SurrogateInstanceId)
		{
			
			string CacheKey = "InstancesTableModel-" + SurrogateInstanceId;
			object objModel = LTP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(SurrogateInstanceId);
					if (objModel != null)
					{
						int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
						LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (BookShop.Model.InstancesTable)objModel;
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
		public List<BookShop.Model.InstancesTable> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<BookShop.Model.InstancesTable> DataTableToList(DataTable dt)
		{
			List<BookShop.Model.InstancesTable> modelList = new List<BookShop.Model.InstancesTable>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				BookShop.Model.InstancesTable model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new BookShop.Model.InstancesTable();
					//model.Id=dt.Rows[n]["Id"].ToString();
					//model.SurrogateInstanceId=dt.Rows[n]["SurrogateInstanceId"].ToString();
					//model.SurrogateLockOwnerId=dt.Rows[n]["SurrogateLockOwnerId"].ToString();
					if(dt.Rows[n]["PrimitiveDataProperties"].ToString()!="")
					{
						model.PrimitiveDataProperties=(byte[])dt.Rows[n]["PrimitiveDataProperties"];
					}
					if(dt.Rows[n]["ComplexDataProperties"].ToString()!="")
					{
						model.ComplexDataProperties=(byte[])dt.Rows[n]["ComplexDataProperties"];
					}
					if(dt.Rows[n]["WriteOnlyPrimitiveDataProperties"].ToString()!="")
					{
						model.WriteOnlyPrimitiveDataProperties=(byte[])dt.Rows[n]["WriteOnlyPrimitiveDataProperties"];
					}
					if(dt.Rows[n]["WriteOnlyComplexDataProperties"].ToString()!="")
					{
						model.WriteOnlyComplexDataProperties=(byte[])dt.Rows[n]["WriteOnlyComplexDataProperties"];
					}
					if(dt.Rows[n]["MetadataProperties"].ToString()!="")
					{
						model.MetadataProperties=(byte[])dt.Rows[n]["MetadataProperties"];
					}
					if(dt.Rows[n]["DataEncodingOption"].ToString()!="")
					{
						model.DataEncodingOption=int.Parse(dt.Rows[n]["DataEncodingOption"].ToString());
					}
					if(dt.Rows[n]["MetadataEncodingOption"].ToString()!="")
					{
						model.MetadataEncodingOption=int.Parse(dt.Rows[n]["MetadataEncodingOption"].ToString());
					}
					//model.Version=dt.Rows[n]["Version"].ToString();
					if(dt.Rows[n]["PendingTimer"].ToString()!="")
					{
						model.PendingTimer=DateTime.Parse(dt.Rows[n]["PendingTimer"].ToString());
					}
					if(dt.Rows[n]["CreationTime"].ToString()!="")
					{
						model.CreationTime=DateTime.Parse(dt.Rows[n]["CreationTime"].ToString());
					}
					if(dt.Rows[n]["LastUpdated"].ToString()!="")
					{
						model.LastUpdated=DateTime.Parse(dt.Rows[n]["LastUpdated"].ToString());
					}
					//model.WorkflowHostType=dt.Rows[n]["WorkflowHostType"].ToString();
					//model.ServiceDeploymentId=dt.Rows[n]["ServiceDeploymentId"].ToString();
					model.SuspensionExceptionName=dt.Rows[n]["SuspensionExceptionName"].ToString();
					model.SuspensionReason=dt.Rows[n]["SuspensionReason"].ToString();
					model.BlockingBookmarks=dt.Rows[n]["BlockingBookmarks"].ToString();
					model.LastMachineRunOn=dt.Rows[n]["LastMachineRunOn"].ToString();
					model.ExecutionStatus=dt.Rows[n]["ExecutionStatus"].ToString();
					if(dt.Rows[n]["IsInitialized"].ToString()!="")
					{
						if((dt.Rows[n]["IsInitialized"].ToString()=="1")||(dt.Rows[n]["IsInitialized"].ToString().ToLower()=="true"))
						{
						model.IsInitialized=true;
						}
						else
						{
							model.IsInitialized=false;
						}
					}
					if(dt.Rows[n]["IsSuspended"].ToString()!="")
					{
						if((dt.Rows[n]["IsSuspended"].ToString()=="1")||(dt.Rows[n]["IsSuspended"].ToString().ToLower()=="true"))
						{
						model.IsSuspended=true;
						}
						else
						{
							model.IsSuspended=false;
						}
					}
					if(dt.Rows[n]["IsReadyToRun"].ToString()!="")
					{
						if((dt.Rows[n]["IsReadyToRun"].ToString()=="1")||(dt.Rows[n]["IsReadyToRun"].ToString().ToLower()=="true"))
						{
						model.IsReadyToRun=true;
						}
						else
						{
							model.IsReadyToRun=false;
						}
					}
					if(dt.Rows[n]["IsCompleted"].ToString()!="")
					{
						if((dt.Rows[n]["IsCompleted"].ToString()=="1")||(dt.Rows[n]["IsCompleted"].ToString().ToLower()=="true"))
						{
						model.IsCompleted=true;
						}
						else
						{
							model.IsCompleted=false;
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

