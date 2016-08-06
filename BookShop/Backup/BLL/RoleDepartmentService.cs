using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using BookShop.Model;
namespace BookShop.BLL
{
	/// <summary>
	/// ҵ���߼���RoleDepartmentService ��ժҪ˵����
	/// </summary>
	public class RoleDepartmentService
	{
		private readonly BookShop.DAL.RoleDepartmentDAL dal=new BookShop.DAL.RoleDepartmentDAL();
		public RoleDepartmentService()
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
		public bool Exists(int Role_ID,int Department_ID)
		{
			return dal.Exists(Role_ID,Department_ID);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(BookShop.Model.RoleDepartment model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(BookShop.Model.RoleDepartment model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int Role_ID,int Department_ID)
		{
			
			dal.Delete(Role_ID,Department_ID);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public BookShop.Model.RoleDepartment GetModel(int Role_ID,int Department_ID)
		{
			
			return dal.GetModel(Role_ID,Department_ID);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
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
		public List<BookShop.Model.RoleDepartment> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
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

