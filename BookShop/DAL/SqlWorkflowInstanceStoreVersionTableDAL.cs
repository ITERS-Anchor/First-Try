using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//�����������
namespace BookShop.DAL
{
	/// <summary>
	/// ���ݷ�����SqlWorkflowInstanceStoreVersionTableDAL��
	/// </summary>
	public class SqlWorkflowInstanceStoreVersionTableDAL
	{
		public SqlWorkflowInstanceStoreVersionTableDAL()
		{}
		#region  ��Ա����



		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(BookShop.Model.SqlWorkflowInstanceStoreVersionTable model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SqlWorkflowInstanceStoreVersionTable(");
			strSql.Append("Major,Minor,Build,Revision,LastUpdated)");
			strSql.Append(" values (");
			strSql.Append("@Major,@Minor,@Build,@Revision,@LastUpdated)");
			SqlParameter[] parameters = {
					new SqlParameter("@Major", SqlDbType.BigInt,8),
					new SqlParameter("@Minor", SqlDbType.BigInt,8),
					new SqlParameter("@Build", SqlDbType.BigInt,8),
					new SqlParameter("@Revision", SqlDbType.BigInt,8),
					new SqlParameter("@LastUpdated", SqlDbType.DateTime)};
			parameters[0].Value = model.Major;
			parameters[1].Value = model.Minor;
			parameters[2].Value = model.Build;
			parameters[3].Value = model.Revision;
			parameters[4].Value = model.LastUpdated;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(BookShop.Model.SqlWorkflowInstanceStoreVersionTable model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SqlWorkflowInstanceStoreVersionTable set ");
			strSql.Append("Major=@Major,");
			strSql.Append("Minor=@Minor,");
			strSql.Append("Build=@Build,");
			strSql.Append("Revision=@Revision,");
			strSql.Append("LastUpdated=@LastUpdated");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@Major", SqlDbType.BigInt,8),
					new SqlParameter("@Minor", SqlDbType.BigInt,8),
					new SqlParameter("@Build", SqlDbType.BigInt,8),
					new SqlParameter("@Revision", SqlDbType.BigInt,8),
					new SqlParameter("@LastUpdated", SqlDbType.DateTime)};
			parameters[0].Value = model.Major;
			parameters[1].Value = model.Minor;
			parameters[2].Value = model.Build;
			parameters[3].Value = model.Revision;
			parameters[4].Value = model.LastUpdated;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SqlWorkflowInstanceStoreVersionTable ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
};

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public BookShop.Model.SqlWorkflowInstanceStoreVersionTable GetModel()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Major,Minor,Build,Revision,LastUpdated from SqlWorkflowInstanceStoreVersionTable ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
};

			BookShop.Model.SqlWorkflowInstanceStoreVersionTable model=new BookShop.Model.SqlWorkflowInstanceStoreVersionTable();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["Major"].ToString()!="")
				{
					model.Major=long.Parse(ds.Tables[0].Rows[0]["Major"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Minor"].ToString()!="")
				{
					model.Minor=long.Parse(ds.Tables[0].Rows[0]["Minor"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Build"].ToString()!="")
				{
					model.Build=long.Parse(ds.Tables[0].Rows[0]["Build"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Revision"].ToString()!="")
				{
					model.Revision=long.Parse(ds.Tables[0].Rows[0]["Revision"].ToString());
				}
				if(ds.Tables[0].Rows[0]["LastUpdated"].ToString()!="")
				{
					model.LastUpdated=DateTime.Parse(ds.Tables[0].Rows[0]["LastUpdated"].ToString());
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
			strSql.Append("select Major,Minor,Build,Revision,LastUpdated ");
			strSql.Append(" FROM SqlWorkflowInstanceStoreVersionTable ");
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
			strSql.Append(" Major,Minor,Build,Revision,LastUpdated ");
			strSql.Append(" FROM SqlWorkflowInstanceStoreVersionTable ");
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
			parameters[0].Value = "SqlWorkflowInstanceStoreVersionTable";
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

