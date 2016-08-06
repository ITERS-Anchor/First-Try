using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace BookShop.DAL
{
	/// <summary>
	/// 数据访问类KeysTableDAL。
	/// </summary>
	public class KeysTableDAL
	{
		public KeysTableDAL()
		{}
		#region  成员方法

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long SurrogateKeyId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from KeysTable");
			strSql.Append(" where SurrogateKeyId=@SurrogateKeyId ");
			SqlParameter[] parameters = {
					new SqlParameter("@SurrogateKeyId", SqlDbType.BigInt)};
			parameters[0].Value = SurrogateKeyId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(BookShop.Model.KeysTable model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into KeysTable(");
			strSql.Append("Id,SurrogateInstanceId,EncodingOption,Properties,IsAssociated)");
			strSql.Append(" values (");
			strSql.Append("@Id,@SurrogateInstanceId,@EncodingOption,@Properties,@IsAssociated)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@SurrogateInstanceId", SqlDbType.BigInt,8),
					new SqlParameter("@EncodingOption", SqlDbType.TinyInt,1),
					new SqlParameter("@Properties", SqlDbType.VarBinary),
					new SqlParameter("@IsAssociated", SqlDbType.Bit,1)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.SurrogateInstanceId;
			parameters[2].Value = model.EncodingOption;
			parameters[3].Value = model.Properties;
			parameters[4].Value = model.IsAssociated;

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
		public void Update(BookShop.Model.KeysTable model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update KeysTable set ");
			strSql.Append("Id=@Id,");
			strSql.Append("SurrogateInstanceId=@SurrogateInstanceId,");
			strSql.Append("EncodingOption=@EncodingOption,");
			strSql.Append("Properties=@Properties,");
			strSql.Append("IsAssociated=@IsAssociated");
			strSql.Append(" where SurrogateKeyId=@SurrogateKeyId ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@SurrogateKeyId", SqlDbType.BigInt,8),
					new SqlParameter("@SurrogateInstanceId", SqlDbType.BigInt,8),
					new SqlParameter("@EncodingOption", SqlDbType.TinyInt,1),
					new SqlParameter("@Properties", SqlDbType.VarBinary),
					new SqlParameter("@IsAssociated", SqlDbType.Bit,1)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.SurrogateKeyId;
			parameters[2].Value = model.SurrogateInstanceId;
			parameters[3].Value = model.EncodingOption;
			parameters[4].Value = model.Properties;
			parameters[5].Value = model.IsAssociated;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(long SurrogateKeyId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from KeysTable ");
			strSql.Append(" where SurrogateKeyId=@SurrogateKeyId ");
			SqlParameter[] parameters = {
					new SqlParameter("@SurrogateKeyId", SqlDbType.BigInt)};
			parameters[0].Value = SurrogateKeyId;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public BookShop.Model.KeysTable GetModel(long SurrogateKeyId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,SurrogateKeyId,SurrogateInstanceId,EncodingOption,Properties,IsAssociated from KeysTable ");
			strSql.Append(" where SurrogateKeyId=@SurrogateKeyId ");
			SqlParameter[] parameters = {
					new SqlParameter("@SurrogateKeyId", SqlDbType.BigInt)};
			parameters[0].Value = SurrogateKeyId;

			BookShop.Model.KeysTable model=new BookShop.Model.KeysTable();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				//model.Id=ds.Tables[0].Rows[0]["Id"].ToString();
				if(ds.Tables[0].Rows[0]["SurrogateKeyId"].ToString()!="")
				{
					model.SurrogateKeyId=long.Parse(ds.Tables[0].Rows[0]["SurrogateKeyId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["SurrogateInstanceId"].ToString()!="")
				{
					model.SurrogateInstanceId=long.Parse(ds.Tables[0].Rows[0]["SurrogateInstanceId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["EncodingOption"].ToString()!="")
				{
					model.EncodingOption=int.Parse(ds.Tables[0].Rows[0]["EncodingOption"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Properties"].ToString()!="")
				{
					model.Properties=(byte[])ds.Tables[0].Rows[0]["Properties"];
				}
				if(ds.Tables[0].Rows[0]["IsAssociated"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["IsAssociated"].ToString()=="1")||(ds.Tables[0].Rows[0]["IsAssociated"].ToString().ToLower()=="true"))
					{
						model.IsAssociated=true;
					}
					else
					{
						model.IsAssociated=false;
					}
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
			strSql.Append("select Id,SurrogateKeyId,SurrogateInstanceId,EncodingOption,Properties,IsAssociated ");
			strSql.Append(" FROM KeysTable ");
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
			strSql.Append(" Id,SurrogateKeyId,SurrogateInstanceId,EncodingOption,Properties,IsAssociated ");
			strSql.Append(" FROM KeysTable ");
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
			parameters[0].Value = "KeysTable";
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

