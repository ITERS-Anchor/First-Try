using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using BookShop.Model;
namespace BookShop.BLL
{
	/// <summary>
	/// 业务逻辑类WF_StepService 的摘要说明。
	/// </summary>
	public class WF_StepService
	{
		private readonly BookShop.DAL.WF_StepDAL dal=new BookShop.DAL.WF_StepDAL();
		public WF_StepService()
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
		public int  Add(BookShop.Model.WF_Step model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(BookShop.Model.WF_Step model)
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
		public BookShop.Model.WF_Step GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中。
		/// </summary>
		public BookShop.Model.WF_Step GetModelByCache(int ID)
		{
			
			string CacheKey = "WF_StepModel-" + ID;
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
			return (BookShop.Model.WF_Step)objModel;
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
		public List<BookShop.Model.WF_Step> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<BookShop.Model.WF_Step> DataTableToList(DataTable dt)
		{
			List<BookShop.Model.WF_Step> modelList = new List<BookShop.Model.WF_Step>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				BookShop.Model.WF_Step model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new BookShop.Model.WF_Step();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["subTime"].ToString()!="")
					{
						model.subTime=DateTime.Parse(dt.Rows[n]["subTime"].ToString());
					}
					if(dt.Rows[n]["ProcessTime"].ToString()!="")
					{
						model.ProcessTime=DateTime.Parse(dt.Rows[n]["ProcessTime"].ToString());
					}
					if(dt.Rows[n]["ProcessBy"].ToString()!="")
					{
						model.ProcessBy=int.Parse(dt.Rows[n]["ProcessBy"].ToString());
					}
					model.StepName=dt.Rows[n]["StepName"].ToString();
					model.Comment=dt.Rows[n]["Comment"].ToString();
					if(dt.Rows[n]["FlowTo"].ToString()!="")
					{
						model.FlowTo=int.Parse(dt.Rows[n]["FlowTo"].ToString());
					}
					if(dt.Rows[n]["IsStart"].ToString()!="")
					{
						if((dt.Rows[n]["IsStart"].ToString()=="1")||(dt.Rows[n]["IsStart"].ToString().ToLower()=="true"))
						{
						model.IsStart=true;
						}
						else
						{
							model.IsStart=false;
						}
					}
					if(dt.Rows[n]["IsEnd"].ToString()!="")
					{
						if((dt.Rows[n]["IsEnd"].ToString()=="1")||(dt.Rows[n]["IsEnd"].ToString().ToLower()=="true"))
						{
						model.IsEnd=true;
						}
						else
						{
							model.IsEnd=false;
						}
					}
					if(dt.Rows[n]["State"].ToString()!="")
					{
						model.State=int.Parse(dt.Rows[n]["State"].ToString());
					}
					if(dt.Rows[n]["ParentStepId"].ToString()!="")
					{
						model.ParentStepId=int.Parse(dt.Rows[n]["ParentStepId"].ToString());
					}
					if(dt.Rows[n]["Sort"].ToString()!="")
					{
						model.Sort=int.Parse(dt.Rows[n]["Sort"].ToString());
					}
					if(dt.Rows[n]["WF_InstanceID"].ToString()!="")
					{
						model.WF_InstanceID=int.Parse(dt.Rows[n]["WF_InstanceID"].ToString());
					}
					//model.InstanceId=dt.Rows[n]["InstanceId"].ToString();
					if(dt.Rows[n]["IsProcessed"].ToString()!="")
					{
						if((dt.Rows[n]["IsProcessed"].ToString()=="1")||(dt.Rows[n]["IsProcessed"].ToString().ToLower()=="true"))
						{
						model.IsProcessed=true;
						}
						else
						{
							model.IsProcessed=false;
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

