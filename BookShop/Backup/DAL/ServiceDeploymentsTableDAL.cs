using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace BookShop.DAL
{
	/// <summary>
	/// 数据访问类ServiceDeploymentsTableDAL。
	/// </summary>
	public class ServiceDeploymentsTableDAL
	{
		public ServiceDeploymentsTableDAL()
		{}
		#region  成员方法

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ServiceDeploymentsTable");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.BigInt)};
			parameters[0].Value = Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(BookShop.Model.ServiceDeploymentsTable model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ServiceDeploymentsTable(");
			strSql.Append("ServiceDeploymentHash,SiteName,RelativeServicePath,RelativeApplicationPath,ServiceName,ServiceNamespace)");
			strSql.Append(" values (");
			strSql.Append("@ServiceDeploymentHash,@SiteName,@RelativeServicePath,@RelativeApplicationPath,@ServiceName,@ServiceNamespace)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ServiceDeploymentHash", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@SiteName", SqlDbType.NVarChar),
					new SqlParameter("@RelativeServicePath", SqlDbType.NVarChar),
					new SqlParameter("@RelativeApplicationPath", SqlDbType.NVarChar),
					new SqlParameter("@ServiceName", SqlDbType.NVarChar),
					new SqlParameter("@ServiceNamespace", SqlDbType.NVarChar)};
			parameters[0].Value = model.ServiceDeploymentHash;
			parameters[1].Value = model.SiteName;
			parameters[2].Value = model.RelativeServicePath;
			parameters[3].Value = model.RelativeApplicationPath;
			parameters[4].Value = model.ServiceName;
			parameters[5].Value = model.ServiceNamespace;

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
		/// 更新一条数据
		/// </summary>
		public void Update(BookShop.Model.ServiceDeploymentsTable model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ServiceDeploymentsTable set ");
			strSql.Append("ServiceDeploymentHash=@ServiceDeploymentHash,");
			strSql.Append("SiteName=@SiteName,");
			strSql.Append("RelativeServicePath=@RelativeServicePath,");
			strSql.Append("RelativeApplicationPath=@RelativeApplicationPath,");
			strSql.Append("ServiceName=@ServiceName,");
			strSql.Append("ServiceNamespace=@ServiceNamespace");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.BigInt,8),
					new SqlParameter("@ServiceDeploymentHash", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@SiteName", SqlDbType.NVarChar),
					new SqlParameter("@RelativeServicePath", SqlDbType.NVarChar),
					new SqlParameter("@RelativeApplicationPath", SqlDbType.NVarChar),
					new SqlParameter("@ServiceName", SqlDbType.NVarChar),
					new SqlParameter("@ServiceNamespace", SqlDbType.NVarChar)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.ServiceDeploymentHash;
			parameters[2].Value = model.SiteName;
			parameters[3].Value = model.RelativeServicePath;
			parameters[4].Value = model.RelativeApplicationPath;
			parameters[5].Value = model.ServiceName;
			parameters[6].Value = model.ServiceNamespace;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(long Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ServiceDeploymentsTable ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.BigInt)};
			parameters[0].Value = Id;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public BookShop.Model.ServiceDeploymentsTable GetModel(long Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,ServiceDeploymentHash,SiteName,RelativeServicePath,RelativeApplicationPath,ServiceName,ServiceNamespace from ServiceDeploymentsTable ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.BigInt)};
			parameters[0].Value = Id;

			BookShop.Model.ServiceDeploymentsTable model=new BookShop.Model.ServiceDeploymentsTable();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["Id"].ToString()!="")
				{
					model.Id=long.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
				}
				//model.ServiceDeploymentHash=ds.Tables[0].Rows[0]["ServiceDeploymentHash"].ToString();
				model.SiteName=ds.Tables[0].Rows[0]["SiteName"].ToString();
				model.RelativeServicePath=ds.Tables[0].Rows[0]["RelativeServicePath"].ToString();
				model.RelativeApplicationPath=ds.Tables[0].Rows[0]["RelativeApplicationPath"].ToString();
				model.ServiceName=ds.Tables[0].Rows[0]["ServiceName"].ToString();
				model.ServiceNamespace=ds.Tables[0].Rows[0]["ServiceNamespace"].ToString();
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,ServiceDeploymentHash,SiteName,RelativeServicePath,RelativeApplicationPath,ServiceName,ServiceNamespace ");
			strSql.Append(" FROM ServiceDeploymentsTable ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" Id,ServiceDeploymentHash,SiteName,RelativeServicePath,RelativeApplicationPath,ServiceName,ServiceNamespace ");
			strSql.Append(" FROM ServiceDeploymentsTable ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
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
			parameters[0].Value = "ServiceDeploymentsTable";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  成员方法
	}
}

