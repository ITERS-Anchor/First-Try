using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using BookShop.Model;
namespace BookShop.BLL
{
	/// <summary>
	/// ҵ���߼���RoleActionGroupService ��ժҪ˵����
	/// </summary>
	public class RoleActionGroupService
	{
		private readonly BookShop.DAL.RoleActionGroupDAL dal=new BookShop.DAL.RoleActionGroupDAL();
		public RoleActionGroupService()
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
		public bool Exists(int Role_ID,int ActionGroup_ID)
		{
			return dal.Exists(Role_ID,ActionGroup_ID);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(BookShop.Model.RoleActionGroup model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(BookShop.Model.RoleActionGroup model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int Role_ID,int ActionGroup_ID)
		{
			
			dal.Delete(Role_ID,ActionGroup_ID);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public BookShop.Model.RoleActionGroup GetModel(int Role_ID,int ActionGroup_ID)
		{
			
			return dal.GetModel(Role_ID,ActionGroup_ID);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public BookShop.Model.RoleActionGroup GetModelByCache(int Role_ID,int ActionGroup_ID)
		{
			
			string CacheKey = "RoleActionGroupModel-" + Role_ID+ActionGroup_ID;
			object objModel = LTP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Role_ID,ActionGroup_ID);
					if (objModel != null)
					{
						int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
						LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (BookShop.Model.RoleActionGroup)objModel;
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
		public List<BookShop.Model.RoleActionGroup> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<BookShop.Model.RoleActionGroup> DataTableToList(DataTable dt)
		{
			List<BookShop.Model.RoleActionGroup> modelList = new List<BookShop.Model.RoleActionGroup>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				BookShop.Model.RoleActionGroup model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new BookShop.Model.RoleActionGroup();
					if(dt.Rows[n]["Role_ID"].ToString()!="")
					{
						model.Role_ID=int.Parse(dt.Rows[n]["Role_ID"].ToString());
					}
					if(dt.Rows[n]["ActionGroup_ID"].ToString()!="")
					{
						model.ActionGroup_ID=int.Parse(dt.Rows[n]["ActionGroup_ID"].ToString());
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

