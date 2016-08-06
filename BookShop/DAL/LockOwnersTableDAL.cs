using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace BookShop.DAL
{
	/// <summary>
	/// 数据访问类LockOwnersTableDAL。
	/// </summary>
	public class LockOwnersTableDAL
	{
		public LockOwnersTableDAL()
		{}
		#region  成员方法

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long SurrogateLockOwnerId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from LockOwnersTable");
			strSql.Append(" where SurrogateLockOwnerId=@SurrogateLockOwnerId ");
			SqlParameter[] parameters = {
					new SqlParameter("@SurrogateLockOwnerId", SqlDbType.BigInt)};
			parameters[0].Value = SurrogateLockOwnerId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(BookShop.Model.LockOwnersTable model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into LockOwnersTable(");
			strSql.Append("Id,LockExpiration,WorkflowHostType,MachineName,EnqueueCommand,DeletesInstanceOnCompletion,PrimitiveLockOwnerData,ComplexLockOwnerData,WriteOnlyPrimitiveLockOwnerData,WriteOnlyComplexLockOwnerData,EncodingOption)");
			strSql.Append(" values (");
			strSql.Append("@Id,@LockExpiration,@WorkflowHostType,@MachineName,@EnqueueCommand,@DeletesInstanceOnCompletion,@PrimitiveLockOwnerData,@ComplexLockOwnerData,@WriteOnlyPrimitiveLockOwnerData,@WriteOnlyComplexLockOwnerData,@EncodingOption)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@LockExpiration", SqlDbType.DateTime),
					new SqlParameter("@WorkflowHostType", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@MachineName", SqlDbType.NVarChar,128),
					new SqlParameter("@EnqueueCommand", SqlDbType.Bit,1),
					new SqlParameter("@DeletesInstanceOnCompletion", SqlDbType.Bit,1),
					new SqlParameter("@PrimitiveLockOwnerData", SqlDbType.VarBinary),
					new SqlParameter("@ComplexLockOwnerData", SqlDbType.VarBinary),
					new SqlParameter("@WriteOnlyPrimitiveLockOwnerData", SqlDbType.VarBinary),
					new SqlParameter("@WriteOnlyComplexLockOwnerData", SqlDbType.VarBinary),
					new SqlParameter("@EncodingOption", SqlDbType.TinyInt,1)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.LockExpiration;
			parameters[2].Value = model.WorkflowHostType;
			parameters[3].Value = model.MachineName;
			parameters[4].Value = model.EnqueueCommand;
			parameters[5].Value = model.DeletesInstanceOnCompletion;
			parameters[6].Value = model.PrimitiveLockOwnerData;
			parameters[7].Value = model.ComplexLockOwnerData;
			parameters[8].Value = model.WriteOnlyPrimitiveLockOwnerData;
			parameters[9].Value = model.WriteOnlyComplexLockOwnerData;
			parameters[10].Value = model.EncodingOption;

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
		public void Update(BookShop.Model.LockOwnersTable model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update LockOwnersTable set ");
			strSql.Append("Id=@Id,");
			strSql.Append("LockExpiration=@LockExpiration,");
			strSql.Append("WorkflowHostType=@WorkflowHostType,");
			strSql.Append("MachineName=@MachineName,");
			strSql.Append("EnqueueCommand=@EnqueueCommand,");
			strSql.Append("DeletesInstanceOnCompletion=@DeletesInstanceOnCompletion,");
			strSql.Append("PrimitiveLockOwnerData=@PrimitiveLockOwnerData,");
			strSql.Append("ComplexLockOwnerData=@ComplexLockOwnerData,");
			strSql.Append("WriteOnlyPrimitiveLockOwnerData=@WriteOnlyPrimitiveLockOwnerData,");
			strSql.Append("WriteOnlyComplexLockOwnerData=@WriteOnlyComplexLockOwnerData,");
			strSql.Append("EncodingOption=@EncodingOption");
			strSql.Append(" where SurrogateLockOwnerId=@SurrogateLockOwnerId ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@SurrogateLockOwnerId", SqlDbType.BigInt,8),
					new SqlParameter("@LockExpiration", SqlDbType.DateTime),
					new SqlParameter("@WorkflowHostType", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@MachineName", SqlDbType.NVarChar,128),
					new SqlParameter("@EnqueueCommand", SqlDbType.Bit,1),
					new SqlParameter("@DeletesInstanceOnCompletion", SqlDbType.Bit,1),
					new SqlParameter("@PrimitiveLockOwnerData", SqlDbType.VarBinary),
					new SqlParameter("@ComplexLockOwnerData", SqlDbType.VarBinary),
					new SqlParameter("@WriteOnlyPrimitiveLockOwnerData", SqlDbType.VarBinary),
					new SqlParameter("@WriteOnlyComplexLockOwnerData", SqlDbType.VarBinary),
					new SqlParameter("@EncodingOption", SqlDbType.TinyInt,1)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.SurrogateLockOwnerId;
			parameters[2].Value = model.LockExpiration;
			parameters[3].Value = model.WorkflowHostType;
			parameters[4].Value = model.MachineName;
			parameters[5].Value = model.EnqueueCommand;
			parameters[6].Value = model.DeletesInstanceOnCompletion;
			parameters[7].Value = model.PrimitiveLockOwnerData;
			parameters[8].Value = model.ComplexLockOwnerData;
			parameters[9].Value = model.WriteOnlyPrimitiveLockOwnerData;
			parameters[10].Value = model.WriteOnlyComplexLockOwnerData;
			parameters[11].Value = model.EncodingOption;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(long SurrogateLockOwnerId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from LockOwnersTable ");
			strSql.Append(" where SurrogateLockOwnerId=@SurrogateLockOwnerId ");
			SqlParameter[] parameters = {
					new SqlParameter("@SurrogateLockOwnerId", SqlDbType.BigInt)};
			parameters[0].Value = SurrogateLockOwnerId;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public BookShop.Model.LockOwnersTable GetModel(long SurrogateLockOwnerId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,SurrogateLockOwnerId,LockExpiration,WorkflowHostType,MachineName,EnqueueCommand,DeletesInstanceOnCompletion,PrimitiveLockOwnerData,ComplexLockOwnerData,WriteOnlyPrimitiveLockOwnerData,WriteOnlyComplexLockOwnerData,EncodingOption from LockOwnersTable ");
			strSql.Append(" where SurrogateLockOwnerId=@SurrogateLockOwnerId ");
			SqlParameter[] parameters = {
					new SqlParameter("@SurrogateLockOwnerId", SqlDbType.BigInt)};
			parameters[0].Value = SurrogateLockOwnerId;

			BookShop.Model.LockOwnersTable model=new BookShop.Model.LockOwnersTable();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				//model.Id=ds.Tables[0].Rows[0]["Id"].ToString();
				if(ds.Tables[0].Rows[0]["SurrogateLockOwnerId"].ToString()!="")
				{
					model.SurrogateLockOwnerId=long.Parse(ds.Tables[0].Rows[0]["SurrogateLockOwnerId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["LockExpiration"].ToString()!="")
				{
					model.LockExpiration=DateTime.Parse(ds.Tables[0].Rows[0]["LockExpiration"].ToString());
				}
				//model.WorkflowHostType=ds.Tables[0].Rows[0]["WorkflowHostType"].ToString();
				model.MachineName=ds.Tables[0].Rows[0]["MachineName"].ToString();
				if(ds.Tables[0].Rows[0]["EnqueueCommand"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["EnqueueCommand"].ToString()=="1")||(ds.Tables[0].Rows[0]["EnqueueCommand"].ToString().ToLower()=="true"))
					{
						model.EnqueueCommand=true;
					}
					else
					{
						model.EnqueueCommand=false;
					}
				}
				if(ds.Tables[0].Rows[0]["DeletesInstanceOnCompletion"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["DeletesInstanceOnCompletion"].ToString()=="1")||(ds.Tables[0].Rows[0]["DeletesInstanceOnCompletion"].ToString().ToLower()=="true"))
					{
						model.DeletesInstanceOnCompletion=true;
					}
					else
					{
						model.DeletesInstanceOnCompletion=false;
					}
				}
				if(ds.Tables[0].Rows[0]["PrimitiveLockOwnerData"].ToString()!="")
				{
					model.PrimitiveLockOwnerData=(byte[])ds.Tables[0].Rows[0]["PrimitiveLockOwnerData"];
				}
				if(ds.Tables[0].Rows[0]["ComplexLockOwnerData"].ToString()!="")
				{
					model.ComplexLockOwnerData=(byte[])ds.Tables[0].Rows[0]["ComplexLockOwnerData"];
				}
				if(ds.Tables[0].Rows[0]["WriteOnlyPrimitiveLockOwnerData"].ToString()!="")
				{
					model.WriteOnlyPrimitiveLockOwnerData=(byte[])ds.Tables[0].Rows[0]["WriteOnlyPrimitiveLockOwnerData"];
				}
				if(ds.Tables[0].Rows[0]["WriteOnlyComplexLockOwnerData"].ToString()!="")
				{
					model.WriteOnlyComplexLockOwnerData=(byte[])ds.Tables[0].Rows[0]["WriteOnlyComplexLockOwnerData"];
				}
				if(ds.Tables[0].Rows[0]["EncodingOption"].ToString()!="")
				{
					model.EncodingOption=int.Parse(ds.Tables[0].Rows[0]["EncodingOption"].ToString());
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
			strSql.Append("select Id,SurrogateLockOwnerId,LockExpiration,WorkflowHostType,MachineName,EnqueueCommand,DeletesInstanceOnCompletion,PrimitiveLockOwnerData,ComplexLockOwnerData,WriteOnlyPrimitiveLockOwnerData,WriteOnlyComplexLockOwnerData,EncodingOption ");
			strSql.Append(" FROM LockOwnersTable ");
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
			strSql.Append(" Id,SurrogateLockOwnerId,LockExpiration,WorkflowHostType,MachineName,EnqueueCommand,DeletesInstanceOnCompletion,PrimitiveLockOwnerData,ComplexLockOwnerData,WriteOnlyPrimitiveLockOwnerData,WriteOnlyComplexLockOwnerData,EncodingOption ");
			strSql.Append(" FROM LockOwnersTable ");
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
			parameters[0].Value = "LockOwnersTable";
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

