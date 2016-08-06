using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//������������
namespace BookShop.DAL
{
	/// <summary>
	/// ���ݷ�����UserInfoDAL��
	/// </summary>
	public class UserInfoDAL
	{
		public UserInfoDAL()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "UserInfo"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from UserInfo");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(BookShop.Model.UserInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into UserInfo(");
			strSql.Append("UserName,UserPass,RegTime,Email)");
			strSql.Append(" values (");
			strSql.Append("@UserName,@UserPass,@RegTime,@Email)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.NVarChar,32),
					new SqlParameter("@UserPass", SqlDbType.NVarChar,32),
					new SqlParameter("@RegTime", SqlDbType.DateTime),
					new SqlParameter("@Email", SqlDbType.NVarChar,32)};
			parameters[0].Value = model.UserName;
			parameters[1].Value = model.UserPass;
			parameters[2].Value = model.RegTime;
			parameters[3].Value = model.Email;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 1;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(BookShop.Model.UserInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update UserInfo set ");
			strSql.Append("UserName=@UserName,");
			strSql.Append("UserPass=@UserPass,");
			strSql.Append("RegTime=@RegTime,");
			strSql.Append("Email=@Email");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.NVarChar,32),
					new SqlParameter("@UserPass", SqlDbType.NVarChar,32),
					new SqlParameter("@RegTime", SqlDbType.DateTime),
					new SqlParameter("@Email", SqlDbType.NVarChar,32)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.UserName;
			parameters[2].Value = model.UserPass;
			parameters[3].Value = model.RegTime;
			parameters[4].Value = model.Email;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UserInfo ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public BookShop.Model.UserInfo GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,UserName,UserPass,RegTime,Email from UserInfo ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			BookShop.Model.UserInfo model=new BookShop.Model.UserInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				model.UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				model.UserPass=ds.Tables[0].Rows[0]["UserPass"].ToString();
				if(ds.Tables[0].Rows[0]["RegTime"].ToString()!="")
				{
					model.RegTime=DateTime.Parse(ds.Tables[0].Rows[0]["RegTime"].ToString());
				}
				model.Email=ds.Tables[0].Rows[0]["Email"].ToString();
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
			strSql.Append("select ID,UserName,UserPass,RegTime,Email ");
			strSql.Append(" FROM UserInfo ");
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
			strSql.Append(" ID,UserName,UserPass,RegTime,Email ");
			strSql.Append(" FROM UserInfo ");
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
			parameters[0].Value = "UserInfo";
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
