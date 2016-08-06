using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//�����������
namespace BookShop.DAL
{
	/// <summary>
	/// ���ݷ�����ActionGroupDAL��
	/// </summary>
	public class ActionGroupDAL
	{
		public ActionGroupDAL()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "ActionGroup"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ActionGroup");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(BookShop.Model.ActionGroup model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ActionGroup(");
			strSql.Append("GroupName,GroupType,DelFlag,Sort)");
			strSql.Append(" values (");
			strSql.Append("@GroupName,@GroupType,@DelFlag,@Sort)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@GroupName", SqlDbType.NVarChar,32),
					new SqlParameter("@GroupType", SqlDbType.SmallInt,2),
					new SqlParameter("@DelFlag", SqlDbType.NVarChar),
					new SqlParameter("@Sort", SqlDbType.Int,4)};
			parameters[0].Value = model.GroupName;
			parameters[1].Value = model.GroupType;
			parameters[2].Value = model.DelFlag;
			parameters[3].Value = model.Sort;

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
		public void Update(BookShop.Model.ActionGroup model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ActionGroup set ");
			strSql.Append("GroupName=@GroupName,");
			strSql.Append("GroupType=@GroupType,");
			strSql.Append("DelFlag=@DelFlag,");
			strSql.Append("Sort=@Sort");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@GroupName", SqlDbType.NVarChar,32),
					new SqlParameter("@GroupType", SqlDbType.SmallInt,2),
					new SqlParameter("@DelFlag", SqlDbType.NVarChar),
					new SqlParameter("@Sort", SqlDbType.Int,4)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.GroupName;
			parameters[2].Value = model.GroupType;
			parameters[3].Value = model.DelFlag;
			parameters[4].Value = model.Sort;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ActionGroup ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public BookShop.Model.ActionGroup GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,GroupName,GroupType,DelFlag,Sort from ActionGroup ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			BookShop.Model.ActionGroup model=new BookShop.Model.ActionGroup();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				model.GroupName=ds.Tables[0].Rows[0]["GroupName"].ToString();
				if(ds.Tables[0].Rows[0]["GroupType"].ToString()!="")
				{
					model.GroupType=int.Parse(ds.Tables[0].Rows[0]["GroupType"].ToString());
				}
				model.DelFlag=ds.Tables[0].Rows[0]["DelFlag"].ToString();
				if(ds.Tables[0].Rows[0]["Sort"].ToString()!="")
				{
					model.Sort=int.Parse(ds.Tables[0].Rows[0]["Sort"].ToString());
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
			strSql.Append("select ID,GroupName,GroupType,DelFlag,Sort ");
			strSql.Append(" FROM ActionGroup ");
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
			strSql.Append(" ID,GroupName,GroupType,DelFlag,Sort ");
			strSql.Append(" FROM ActionGroup ");
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
			parameters[0].Value = "ActionGroup";
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

