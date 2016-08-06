using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//�����������
namespace BookShop.DAL
{
	/// <summary>
	/// ���ݷ�����ActionGroupActionInfoDAL��
	/// </summary>
	public class ActionGroupActionInfoDAL
	{
		public ActionGroupActionInfoDAL()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ActionGroup_ID", "ActionGroupActionInfo"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ActionGroup_ID,int ActionInfo_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ActionGroupActionInfo");
			strSql.Append(" where ActionGroup_ID=@ActionGroup_ID and ActionInfo_ID=@ActionInfo_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ActionGroup_ID", SqlDbType.Int,4),
					new SqlParameter("@ActionInfo_ID", SqlDbType.Int,4)};
			parameters[0].Value = ActionGroup_ID;
			parameters[1].Value = ActionInfo_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(BookShop.Model.ActionGroupActionInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ActionGroupActionInfo(");
			strSql.Append("ActionGroup_ID,ActionInfo_ID)");
			strSql.Append(" values (");
			strSql.Append("@ActionGroup_ID,@ActionInfo_ID)");
			SqlParameter[] parameters = {
					new SqlParameter("@ActionGroup_ID", SqlDbType.Int,4),
					new SqlParameter("@ActionInfo_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.ActionGroup_ID;
			parameters[1].Value = model.ActionInfo_ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(BookShop.Model.ActionGroupActionInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ActionGroupActionInfo set ");

			strSql.Append(" where ActionGroup_ID=@ActionGroup_ID and ActionInfo_ID=@ActionInfo_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ActionGroup_ID", SqlDbType.Int,4),
					new SqlParameter("@ActionInfo_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.ActionGroup_ID;
			parameters[1].Value = model.ActionInfo_ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int ActionGroup_ID,int ActionInfo_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ActionGroupActionInfo ");
			strSql.Append(" where ActionGroup_ID=@ActionGroup_ID and ActionInfo_ID=@ActionInfo_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ActionGroup_ID", SqlDbType.Int,4),
					new SqlParameter("@ActionInfo_ID", SqlDbType.Int,4)};
			parameters[0].Value = ActionGroup_ID;
			parameters[1].Value = ActionInfo_ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public BookShop.Model.ActionGroupActionInfo GetModel(int ActionGroup_ID,int ActionInfo_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ActionGroup_ID,ActionInfo_ID from ActionGroupActionInfo ");
			strSql.Append(" where ActionGroup_ID=@ActionGroup_ID and ActionInfo_ID=@ActionInfo_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ActionGroup_ID", SqlDbType.Int,4),
					new SqlParameter("@ActionInfo_ID", SqlDbType.Int,4)};
			parameters[0].Value = ActionGroup_ID;
			parameters[1].Value = ActionInfo_ID;

			BookShop.Model.ActionGroupActionInfo model=new BookShop.Model.ActionGroupActionInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ActionGroup_ID"].ToString()!="")
				{
					model.ActionGroup_ID=int.Parse(ds.Tables[0].Rows[0]["ActionGroup_ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ActionInfo_ID"].ToString()!="")
				{
					model.ActionInfo_ID=int.Parse(ds.Tables[0].Rows[0]["ActionInfo_ID"].ToString());
				}
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ActionGroup_ID,ActionInfo_ID ");
			strSql.Append(" FROM ActionGroupActionInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// ���ǰ��������
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" ActionGroup_ID,ActionInfo_ID ");
			strSql.Append(" FROM ActionGroupActionInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "ActionGroupActionInfo";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  ��Ա����
	}
}

