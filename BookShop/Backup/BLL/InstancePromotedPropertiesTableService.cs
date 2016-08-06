using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using BookShop.Model;
namespace BookShop.BLL
{
	/// <summary>
	/// 业务逻辑类InstancePromotedPropertiesTableService 的摘要说明。
	/// </summary>
	public class InstancePromotedPropertiesTableService
	{
		private readonly BookShop.DAL.InstancePromotedPropertiesTableDAL dal=new BookShop.DAL.InstancePromotedPropertiesTableDAL();
		public InstancePromotedPropertiesTableService()
		{}
		#region  成员方法

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(BookShop.Model.InstancePromotedPropertiesTable model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(BookShop.Model.InstancePromotedPropertiesTable model)
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
		public BookShop.Model.InstancePromotedPropertiesTable GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			return dal.GetModel();
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中。
		/// </summary>
		public BookShop.Model.InstancePromotedPropertiesTable GetModelByCache()
		{
			//该表无主键信息，请自定义主键/条件字段
			string CacheKey = "InstancePromotedPropertiesTableModel-" ;
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
			return (BookShop.Model.InstancePromotedPropertiesTable)objModel;
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
		public List<BookShop.Model.InstancePromotedPropertiesTable> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<BookShop.Model.InstancePromotedPropertiesTable> DataTableToList(DataTable dt)
		{
			List<BookShop.Model.InstancePromotedPropertiesTable> modelList = new List<BookShop.Model.InstancePromotedPropertiesTable>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				BookShop.Model.InstancePromotedPropertiesTable model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new BookShop.Model.InstancePromotedPropertiesTable();
					//model.SurrogateInstanceId=dt.Rows[n]["SurrogateInstanceId"].ToString();
					model.PromotionName=dt.Rows[n]["PromotionName"].ToString();
					//model.Value1=dt.Rows[n]["Value1"].ToString();
					//model.Value2=dt.Rows[n]["Value2"].ToString();
					//model.Value3=dt.Rows[n]["Value3"].ToString();
					//model.Value4=dt.Rows[n]["Value4"].ToString();
					//model.Value5=dt.Rows[n]["Value5"].ToString();
					//model.Value6=dt.Rows[n]["Value6"].ToString();
					//model.Value7=dt.Rows[n]["Value7"].ToString();
					//model.Value8=dt.Rows[n]["Value8"].ToString();
					//model.Value9=dt.Rows[n]["Value9"].ToString();
					//model.Value10=dt.Rows[n]["Value10"].ToString();
					//model.Value11=dt.Rows[n]["Value11"].ToString();
					//model.Value12=dt.Rows[n]["Value12"].ToString();
					//model.Value13=dt.Rows[n]["Value13"].ToString();
					//model.Value14=dt.Rows[n]["Value14"].ToString();
					//model.Value15=dt.Rows[n]["Value15"].ToString();
					//model.Value16=dt.Rows[n]["Value16"].ToString();
					//model.Value17=dt.Rows[n]["Value17"].ToString();
					//model.Value18=dt.Rows[n]["Value18"].ToString();
					//model.Value19=dt.Rows[n]["Value19"].ToString();
					//model.Value20=dt.Rows[n]["Value20"].ToString();
					//model.Value21=dt.Rows[n]["Value21"].ToString();
					//model.Value22=dt.Rows[n]["Value22"].ToString();
					//model.Value23=dt.Rows[n]["Value23"].ToString();
					//model.Value24=dt.Rows[n]["Value24"].ToString();
					//model.Value25=dt.Rows[n]["Value25"].ToString();
					//model.Value26=dt.Rows[n]["Value26"].ToString();
					//model.Value27=dt.Rows[n]["Value27"].ToString();
					//model.Value28=dt.Rows[n]["Value28"].ToString();
					//model.Value29=dt.Rows[n]["Value29"].ToString();
					//model.Value30=dt.Rows[n]["Value30"].ToString();
					//model.Value31=dt.Rows[n]["Value31"].ToString();
					//model.Value32=dt.Rows[n]["Value32"].ToString();
					if(dt.Rows[n]["Value33"].ToString()!="")
					{
						model.Value33=(byte[])dt.Rows[n]["Value33"];
					}
					if(dt.Rows[n]["Value34"].ToString()!="")
					{
						model.Value34=(byte[])dt.Rows[n]["Value34"];
					}
					if(dt.Rows[n]["Value35"].ToString()!="")
					{
						model.Value35=(byte[])dt.Rows[n]["Value35"];
					}
					if(dt.Rows[n]["Value36"].ToString()!="")
					{
						model.Value36=(byte[])dt.Rows[n]["Value36"];
					}
					if(dt.Rows[n]["Value37"].ToString()!="")
					{
						model.Value37=(byte[])dt.Rows[n]["Value37"];
					}
					if(dt.Rows[n]["Value38"].ToString()!="")
					{
						model.Value38=(byte[])dt.Rows[n]["Value38"];
					}
					if(dt.Rows[n]["Value39"].ToString()!="")
					{
						model.Value39=(byte[])dt.Rows[n]["Value39"];
					}
					if(dt.Rows[n]["Value40"].ToString()!="")
					{
						model.Value40=(byte[])dt.Rows[n]["Value40"];
					}
					if(dt.Rows[n]["Value41"].ToString()!="")
					{
						model.Value41=(byte[])dt.Rows[n]["Value41"];
					}
					if(dt.Rows[n]["Value42"].ToString()!="")
					{
						model.Value42=(byte[])dt.Rows[n]["Value42"];
					}
					if(dt.Rows[n]["Value43"].ToString()!="")
					{
						model.Value43=(byte[])dt.Rows[n]["Value43"];
					}
					if(dt.Rows[n]["Value44"].ToString()!="")
					{
						model.Value44=(byte[])dt.Rows[n]["Value44"];
					}
					if(dt.Rows[n]["Value45"].ToString()!="")
					{
						model.Value45=(byte[])dt.Rows[n]["Value45"];
					}
					if(dt.Rows[n]["Value46"].ToString()!="")
					{
						model.Value46=(byte[])dt.Rows[n]["Value46"];
					}
					if(dt.Rows[n]["Value47"].ToString()!="")
					{
						model.Value47=(byte[])dt.Rows[n]["Value47"];
					}
					if(dt.Rows[n]["Value48"].ToString()!="")
					{
						model.Value48=(byte[])dt.Rows[n]["Value48"];
					}
					if(dt.Rows[n]["Value49"].ToString()!="")
					{
						model.Value49=(byte[])dt.Rows[n]["Value49"];
					}
					if(dt.Rows[n]["Value50"].ToString()!="")
					{
						model.Value50=(byte[])dt.Rows[n]["Value50"];
					}
					if(dt.Rows[n]["Value51"].ToString()!="")
					{
						model.Value51=(byte[])dt.Rows[n]["Value51"];
					}
					if(dt.Rows[n]["Value52"].ToString()!="")
					{
						model.Value52=(byte[])dt.Rows[n]["Value52"];
					}
					if(dt.Rows[n]["Value53"].ToString()!="")
					{
						model.Value53=(byte[])dt.Rows[n]["Value53"];
					}
					if(dt.Rows[n]["Value54"].ToString()!="")
					{
						model.Value54=(byte[])dt.Rows[n]["Value54"];
					}
					if(dt.Rows[n]["Value55"].ToString()!="")
					{
						model.Value55=(byte[])dt.Rows[n]["Value55"];
					}
					if(dt.Rows[n]["Value56"].ToString()!="")
					{
						model.Value56=(byte[])dt.Rows[n]["Value56"];
					}
					if(dt.Rows[n]["Value57"].ToString()!="")
					{
						model.Value57=(byte[])dt.Rows[n]["Value57"];
					}
					if(dt.Rows[n]["Value58"].ToString()!="")
					{
						model.Value58=(byte[])dt.Rows[n]["Value58"];
					}
					if(dt.Rows[n]["Value59"].ToString()!="")
					{
						model.Value59=(byte[])dt.Rows[n]["Value59"];
					}
					if(dt.Rows[n]["Value60"].ToString()!="")
					{
						model.Value60=(byte[])dt.Rows[n]["Value60"];
					}
					if(dt.Rows[n]["Value61"].ToString()!="")
					{
						model.Value61=(byte[])dt.Rows[n]["Value61"];
					}
					if(dt.Rows[n]["Value62"].ToString()!="")
					{
						model.Value62=(byte[])dt.Rows[n]["Value62"];
					}
					if(dt.Rows[n]["Value63"].ToString()!="")
					{
						model.Value63=(byte[])dt.Rows[n]["Value63"];
					}
					if(dt.Rows[n]["Value64"].ToString()!="")
					{
						model.Value64=(byte[])dt.Rows[n]["Value64"];
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

