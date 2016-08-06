using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace BookShop.DAL
{
	/// <summary>
	/// 数据访问类InstanceMetadataChangesTableDAL。
	/// </summary>
	public class InstanceMetadataChangesTableDAL
	{
		public InstanceMetadataChangesTableDAL()
		{}
		#region  成员方法

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long ChangeTime)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from InstanceMetadataChangesTable");
			strSql.Append(" where ChangeTime=@ChangeTime ");
			SqlParameter[] parameters = {
					new SqlParameter("@ChangeTime", SqlDbType.BigInt)};
			parameters[0].Value = ChangeTime;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(BookShop.Model.InstanceMetadataChangesTable model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into InstanceMetadataChangesTable(");
			strSql.Append("SurrogateInstanceId,EncodingOption,Change)");
			strSql.Append(" values (");
			strSql.Append("@SurrogateInstanceId,@EncodingOption,@Change)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@SurrogateInstanceId", SqlDbType.BigInt,8),
					new SqlParameter("@EncodingOption", SqlDbType.TinyInt,1),
					new SqlParameter("@Change", SqlDbType.VarBinary)};
			parameters[0].Value = model.SurrogateInstanceId;
			parameters[1].Value = model.EncodingOption;
			parameters[2].Value = model.Change;

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
		public void Update(BookShop.Model.InstanceMetadataChangesTable model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update InstanceMetadataChangesTable set ");
			strSql.Append("SurrogateInstanceId=@SurrogateInstanceId,");
			strSql.Append("EncodingOption=@EncodingOption,");
			strSql.Append("Change=@Change");
			strSql.Append(" where ChangeTime=@ChangeTime ");
			SqlParameter[] parameters = {
					new SqlParameter("@SurrogateInstanceId", SqlDbType.BigInt,8),
					new SqlParameter("@ChangeTime", SqlDbType.BigInt,8),
					new SqlParameter("@EncodingOption", SqlDbType.TinyInt,1),
					new SqlParameter("@Change", SqlDbType.VarBinary)};
			parameters[0].Value = model.SurrogateInstanceId;
			parameters[1].Value = model.ChangeTime;
			parameters[2].Value = model.EncodingOption;
			parameters[3].Value = model.Change;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(long ChangeTime)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from InstanceMetadataChangesTable ");
			strSql.Append(" where ChangeTime=@ChangeTime ");
			SqlParameter[] parameters = {
					new SqlParameter("@ChangeTime", SqlDbType.BigInt)};
			parameters[0].Value = ChangeTime;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public BookShop.Model.InstanceMetadataChangesTable GetModel(long ChangeTime)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 SurrogateInstanceId,ChangeTime,EncodingOption,Change from InstanceMetadataChangesTable ");
			strSql.Append(" where ChangeTime=@ChangeTime ");
			SqlParameter[] parameters = {
					new SqlParameter("@ChangeTime", SqlDbType.BigInt)};
			parameters[0].Value = ChangeTime;

			BookShop.Model.InstanceMetadataChangesTable model=new BookShop.Model.InstanceMetadataChangesTable();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["SurrogateInstanceId"].ToString()!="")
				{
					model.SurrogateInstanceId=long.Parse(ds.Tables[0].Rows[0]["SurrogateInstanceId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ChangeTime"].ToString()!="")
				{
					model.ChangeTime=long.Parse(ds.Tables[0].Rows[0]["ChangeTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["EncodingOption"].ToString()!="")
				{
					model.EncodingOption=int.Parse(ds.Tables[0].Rows[0]["EncodingOption"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Change"].ToString()!="")
				{
					model.Change=(byte[])ds.Tables[0].Rows[0]["Change"];
				}
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
			strSql.Append("select SurrogateInstanceId,ChangeTime,EncodingOption,Change ");
			strSql.Append(" FROM InstanceMetadataChangesTable ");
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
			strSql.Append(" SurrogateInstanceId,ChangeTime,EncodingOption,Change ");
			strSql.Append(" FROM InstanceMetadataChangesTable ");
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
			parameters[0].Value = "InstanceMetadataChangesTable";
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

