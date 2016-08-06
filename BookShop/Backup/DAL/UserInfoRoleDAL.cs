using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//������������
namespace BookShop.DAL
{
	/// <summary>
	/// ���ݷ�����UserInfoRoleDAL��
	/// </summary>
	public class UserInfoRoleDAL
	{
		public UserInfoRoleDAL()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("UserInfo_ID", "UserInfoRole"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int UserInfo_ID,int Role_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from UserInfoRole");
			strSql.Append(" where UserInfo_ID=@UserInfo_ID and Role_ID=@Role_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@UserInfo_ID", SqlDbType.Int,4),
					new SqlParameter("@Role_ID", SqlDbType.Int,4)};
			parameters[0].Value = UserInfo_ID;
			parameters[1].Value = Role_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(BookShop.Model.UserInfoRole model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into UserInfoRole(");
			strSql.Append("UserInfo_ID,Role_ID)");
			strSql.Append(" values (");
			strSql.Append("@UserInfo_ID,@Role_ID)");
			SqlParameter[] parameters = {
					new SqlParameter("@UserInfo_ID", SqlDbType.Int,4),
					new SqlParameter("@Role_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.UserInfo_ID;
			parameters[1].Value = model.Role_ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(BookShop.Model.UserInfoRole model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update UserInfoRole set ");
");
			strSql.Append(" where UserInfo_ID=@UserInfo_ID and Role_ID=@Role_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@UserInfo_ID", SqlDbType.Int,4),
					new SqlParameter("@Role_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.UserInfo_ID;
			parameters[1].Value = model.Role_ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int UserInfo_ID,int Role_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UserInfoRole ");
			strSql.Append(" where UserInfo_ID=@UserInfo_ID and Role_ID=@Role_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@UserInfo_ID", SqlDbType.Int,4),
					new SqlParameter("@Role_ID", SqlDbType.Int,4)};
			parameters[0].Value = UserInfo_ID;
			parameters[1].Value = Role_ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public BookShop.Model.UserInfoRole GetModel(int UserInfo_ID,int Role_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 UserInfo_ID,Role_ID from UserInfoRole ");
			strSql.Append(" where UserInfo_ID=@UserInfo_ID and Role_ID=@Role_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@UserInfo_ID", SqlDbType.Int,4),
					new SqlParameter("@Role_ID", SqlDbType.Int,4)};
			parameters[0].Value = UserInfo_ID;
			parameters[1].Value = Role_ID;

			BookShop.Model.UserInfoRole model=new BookShop.Model.UserInfoRole();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["UserInfo_ID"].ToString()!="")
				{
					model.UserInfo_ID=int.Parse(ds.Tables[0].Rows[0]["UserInfo_ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Role_ID"].ToString()!="")
				{
					model.Role_ID=int.Parse(ds.Tables[0].Rows[0]["Role_ID"].ToString());
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
			strSql.Append("select UserInfo_ID,Role_ID ");
			strSql.Append(" FROM UserInfoRole ");
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
			strSql.Append(" UserInfo_ID,Role_ID ");
			strSql.Append(" FROM UserInfoRole ");
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
			parameters[0].Value = "UserInfoRole";
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
