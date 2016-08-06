using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using BookShop.Model;
namespace BookShop.BLL
{
	/// <summary>
	/// ҵ���߼���InstanceMetadataChangesTableService ��ժҪ˵����
	/// </summary>
	public class InstanceMetadataChangesTableService
	{
		private readonly BookShop.DAL.InstanceMetadataChangesTableDAL dal=new BookShop.DAL.InstanceMetadataChangesTableDAL();
		public InstanceMetadataChangesTableService()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(long ChangeTime)
		{
			return dal.Exists(ChangeTime);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(BookShop.Model.InstanceMetadataChangesTable model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(BookShop.Model.InstanceMetadataChangesTable model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(long ChangeTime)
		{
			
			dal.Delete(ChangeTime);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public BookShop.Model.InstanceMetadataChangesTable GetModel(long ChangeTime)
		{
			
			return dal.GetModel(ChangeTime);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
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
		public List<BookShop.Model.InstanceMetadataChangesTable> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
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

