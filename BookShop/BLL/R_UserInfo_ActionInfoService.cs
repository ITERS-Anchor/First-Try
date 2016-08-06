using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using BookShop.Model;
namespace BookShop.BLL
{
	/// <summary>
	/// ҵ���߼���R_UserInfo_ActionInfoService ��ժҪ˵����
	/// </summary>
	public class R_UserInfo_ActionInfoService
	{
		private readonly BookShop.DAL.R_UserInfo_ActionInfoDAL dal=new BookShop.DAL.R_UserInfo_ActionInfoDAL();
		public R_UserInfo_ActionInfoService()
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
		public int  Add(BookShop.Model.R_UserInfo_ActionInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(BookShop.Model.R_UserInfo_ActionInfo model)
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
		public BookShop.Model.R_UserInfo_ActionInfo GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public BookShop.Model.R_UserInfo_ActionInfo GetModelByCache(int ID)
		{
			
			string CacheKey = "R_UserInfo_ActionInfoModel-" + ID;
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
			return (BookShop.Model.R_UserInfo_ActionInfo)objModel;
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
		public List<BookShop.Model.R_UserInfo_ActionInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<BookShop.Model.R_UserInfo_ActionInfo> DataTableToList(DataTable dt)
		{
			List<BookShop.Model.R_UserInfo_ActionInfo> modelList = new List<BookShop.Model.R_UserInfo_ActionInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				BookShop.Model.R_UserInfo_ActionInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new BookShop.Model.R_UserInfo_ActionInfo();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["IsPass"].ToString()!="")
					{
						model.IsPass=int.Parse(dt.Rows[n]["IsPass"].ToString());
					}
					if(dt.Rows[n]["ActionInfoID"].ToString()!="")
					{
						model.ActionInfoID=int.Parse(dt.Rows[n]["ActionInfoID"].ToString());
					}
					if(dt.Rows[n]["UserInfoID"].ToString()!="")
					{
						model.UserInfoID=int.Parse(dt.Rows[n]["UserInfoID"].ToString());
					}
					if(dt.Rows[n]["ActionInfo_ID"].ToString()!="")
					{
						model.ActionInfo_ID=int.Parse(dt.Rows[n]["ActionInfo_ID"].ToString());
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

