using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using BookShop.Model;
namespace BookShop.BLL
{
	/// <summary>
	/// ҵ���߼���SqlWorkflowInstanceStoreVersionTableService ��ժҪ˵����
	/// </summary>
	public class SqlWorkflowInstanceStoreVersionTableService
	{
		private readonly BookShop.DAL.SqlWorkflowInstanceStoreVersionTableDAL dal=new BookShop.DAL.SqlWorkflowInstanceStoreVersionTableDAL();
		public SqlWorkflowInstanceStoreVersionTableService()
		{}
		#region  ��Ա����

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(BookShop.Model.SqlWorkflowInstanceStoreVersionTable model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(BookShop.Model.SqlWorkflowInstanceStoreVersionTable model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			dal.Delete();
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public BookShop.Model.SqlWorkflowInstanceStoreVersionTable GetModel()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			return dal.GetModel();
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public BookShop.Model.SqlWorkflowInstanceStoreVersionTable GetModelByCache()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
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
		public List<BookShop.Model.SqlWorkflowInstanceStoreVersionTable> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
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

