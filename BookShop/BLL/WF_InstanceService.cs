using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using BookShop.Model;
namespace BookShop.BLL
{
	/// <summary>
	/// ҵ���߼���WF_InstanceService ��ժҪ˵����
	/// </summary>
	public class WF_InstanceService
	{
		private readonly BookShop.DAL.WF_InstanceDAL dal=new BookShop.DAL.WF_InstanceDAL();
		public WF_InstanceService()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ID)
		{
			return dal.Exists(ID);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(BookShop.Model.WF_Instance model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(BookShop.Model.WF_Instance model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int ID)
		{
			
			dal.Delete(ID);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public BookShop.Model.WF_Instance GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public BookShop.Model.WF_Instance GetModelByCache(int ID)
		{
			
			string CacheKey = "WF_InstanceModel-" + ID;
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
			return (BookShop.Model.WF_Instance)objModel;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// ���ǰ��������
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<BookShop.Model.WF_Instance> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<BookShop.Model.WF_Instance> DataTableToList(DataTable dt)
		{
			List<BookShop.Model.WF_Instance> modelList = new List<BookShop.Model.WF_Instance>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				BookShop.Model.WF_Instance model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new BookShop.Model.WF_Instance();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					model.Title=dt.Rows[n]["Title"].ToString();
					if(dt.Rows[n]["SubBy"].ToString()!="")
					{
						model.SubBy=int.Parse(dt.Rows[n]["SubBy"].ToString());
					}
					if(dt.Rows[n]["SubTime"].ToString()!="")
					{
						model.SubTime=DateTime.Parse(dt.Rows[n]["SubTime"].ToString());
					}
					if(dt.Rows[n]["OutTime"].ToString()!="")
					{
						model.OutTime=DateTime.Parse(dt.Rows[n]["OutTime"].ToString());
					}
					if(dt.Rows[n]["state"].ToString()!="")
					{
						model.state=int.Parse(dt.Rows[n]["state"].ToString());
					}
					if(dt.Rows[n]["Result"].ToString()!="")
					{
						model.Result=int.Parse(dt.Rows[n]["Result"].ToString());
					}
					model.Content=dt.Rows[n]["Content"].ToString();
					if(dt.Rows[n]["Level"].ToString()!="")
					{
						model.Level=int.Parse(dt.Rows[n]["Level"].ToString());
					}
					if(dt.Rows[n]["WF_TempID"].ToString()!="")
					{
						model.WF_TempID=int.Parse(dt.Rows[n]["WF_TempID"].ToString());
					}
					//model.InstanceId=dt.Rows[n]["InstanceId"].ToString();
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  ��Ա����
	}
}

