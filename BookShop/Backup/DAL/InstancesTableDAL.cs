using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace BookShop.DAL
{
	/// <summary>
	/// 数据访问类InstancesTableDAL。
	/// </summary>
	public class InstancesTableDAL
	{
		public InstancesTableDAL()
		{}
		#region  成员方法

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long SurrogateInstanceId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from InstancesTable");
			strSql.Append(" where SurrogateInstanceId=@SurrogateInstanceId ");
			SqlParameter[] parameters = {
					new SqlParameter("@SurrogateInstanceId", SqlDbType.BigInt)};
			parameters[0].Value = SurrogateInstanceId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(BookShop.Model.InstancesTable model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into InstancesTable(");
			strSql.Append("Id,SurrogateLockOwnerId,PrimitiveDataProperties,ComplexDataProperties,WriteOnlyPrimitiveDataProperties,WriteOnlyComplexDataProperties,MetadataProperties,DataEncodingOption,MetadataEncodingOption,Version,PendingTimer,CreationTime,LastUpdated,WorkflowHostType,ServiceDeploymentId,SuspensionExceptionName,SuspensionReason,BlockingBookmarks,LastMachineRunOn,ExecutionStatus,IsInitialized,IsSuspended,IsReadyToRun,IsCompleted)");
			strSql.Append(" values (");
			strSql.Append("@Id,@SurrogateLockOwnerId,@PrimitiveDataProperties,@ComplexDataProperties,@WriteOnlyPrimitiveDataProperties,@WriteOnlyComplexDataProperties,@MetadataProperties,@DataEncodingOption,@MetadataEncodingOption,@Version,@PendingTimer,@CreationTime,@LastUpdated,@WorkflowHostType,@ServiceDeploymentId,@SuspensionExceptionName,@SuspensionReason,@BlockingBookmarks,@LastMachineRunOn,@ExecutionStatus,@IsInitialized,@IsSuspended,@IsReadyToRun,@IsCompleted)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@SurrogateLockOwnerId", SqlDbType.BigInt,8),
					new SqlParameter("@PrimitiveDataProperties", SqlDbType.VarBinary),
					new SqlParameter("@ComplexDataProperties", SqlDbType.VarBinary),
					new SqlParameter("@WriteOnlyPrimitiveDataProperties", SqlDbType.VarBinary),
					new SqlParameter("@WriteOnlyComplexDataProperties", SqlDbType.VarBinary),
					new SqlParameter("@MetadataProperties", SqlDbType.VarBinary),
					new SqlParameter("@DataEncodingOption", SqlDbType.TinyInt,1),
					new SqlParameter("@MetadataEncodingOption", SqlDbType.TinyInt,1),
					new SqlParameter("@Version", SqlDbType.BigInt,8),
					new SqlParameter("@PendingTimer", SqlDbType.DateTime),
					new SqlParameter("@CreationTime", SqlDbType.DateTime),
					new SqlParameter("@LastUpdated", SqlDbType.DateTime),
					new SqlParameter("@WorkflowHostType", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@ServiceDeploymentId", SqlDbType.BigInt,8),
					new SqlParameter("@SuspensionExceptionName", SqlDbType.NVarChar,450),
					new SqlParameter("@SuspensionReason", SqlDbType.NVarChar),
					new SqlParameter("@BlockingBookmarks", SqlDbType.NVarChar),
					new SqlParameter("@LastMachineRunOn", SqlDbType.NVarChar,450),
					new SqlParameter("@ExecutionStatus", SqlDbType.NVarChar,450),
					new SqlParameter("@IsInitialized", SqlDbType.Bit,1),
					new SqlParameter("@IsSuspended", SqlDbType.Bit,1),
					new SqlParameter("@IsReadyToRun", SqlDbType.Bit,1),
					new SqlParameter("@IsCompleted", SqlDbType.Bit,1)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.SurrogateLockOwnerId;
			parameters[2].Value = model.PrimitiveDataProperties;
			parameters[3].Value = model.ComplexDataProperties;
			parameters[4].Value = model.WriteOnlyPrimitiveDataProperties;
			parameters[5].Value = model.WriteOnlyComplexDataProperties;
			parameters[6].Value = model.MetadataProperties;
			parameters[7].Value = model.DataEncodingOption;
			parameters[8].Value = model.MetadataEncodingOption;
			parameters[9].Value = model.Version;
			parameters[10].Value = model.PendingTimer;
			parameters[11].Value = model.CreationTime;
			parameters[12].Value = model.LastUpdated;
			parameters[13].Value = model.WorkflowHostType;
			parameters[14].Value = model.ServiceDeploymentId;
			parameters[15].Value = model.SuspensionExceptionName;
			parameters[16].Value = model.SuspensionReason;
			parameters[17].Value = model.BlockingBookmarks;
			parameters[18].Value = model.LastMachineRunOn;
			parameters[19].Value = model.ExecutionStatus;
			parameters[20].Value = model.IsInitialized;
			parameters[21].Value = model.IsSuspended;
			parameters[22].Value = model.IsReadyToRun;
			parameters[23].Value = model.IsCompleted;

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
		public void Update(BookShop.Model.InstancesTable model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update InstancesTable set ");
			strSql.Append("Id=@Id,");
			strSql.Append("SurrogateLockOwnerId=@SurrogateLockOwnerId,");
			strSql.Append("PrimitiveDataProperties=@PrimitiveDataProperties,");
			strSql.Append("ComplexDataProperties=@ComplexDataProperties,");
			strSql.Append("WriteOnlyPrimitiveDataProperties=@WriteOnlyPrimitiveDataProperties,");
			strSql.Append("WriteOnlyComplexDataProperties=@WriteOnlyComplexDataProperties,");
			strSql.Append("MetadataProperties=@MetadataProperties,");
			strSql.Append("DataEncodingOption=@DataEncodingOption,");
			strSql.Append("MetadataEncodingOption=@MetadataEncodingOption,");
			strSql.Append("Version=@Version,");
			strSql.Append("PendingTimer=@PendingTimer,");
			strSql.Append("CreationTime=@CreationTime,");
			strSql.Append("LastUpdated=@LastUpdated,");
			strSql.Append("WorkflowHostType=@WorkflowHostType,");
			strSql.Append("ServiceDeploymentId=@ServiceDeploymentId,");
			strSql.Append("SuspensionExceptionName=@SuspensionExceptionName,");
			strSql.Append("SuspensionReason=@SuspensionReason,");
			strSql.Append("BlockingBookmarks=@BlockingBookmarks,");
			strSql.Append("LastMachineRunOn=@LastMachineRunOn,");
			strSql.Append("ExecutionStatus=@ExecutionStatus,");
			strSql.Append("IsInitialized=@IsInitialized,");
			strSql.Append("IsSuspended=@IsSuspended,");
			strSql.Append("IsReadyToRun=@IsReadyToRun,");
			strSql.Append("IsCompleted=@IsCompleted");
			strSql.Append(" where SurrogateInstanceId=@SurrogateInstanceId ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@SurrogateInstanceId", SqlDbType.BigInt,8),
					new SqlParameter("@SurrogateLockOwnerId", SqlDbType.BigInt,8),
					new SqlParameter("@PrimitiveDataProperties", SqlDbType.VarBinary),
					new SqlParameter("@ComplexDataProperties", SqlDbType.VarBinary),
					new SqlParameter("@WriteOnlyPrimitiveDataProperties", SqlDbType.VarBinary),
					new SqlParameter("@WriteOnlyComplexDataProperties", SqlDbType.VarBinary),
					new SqlParameter("@MetadataProperties", SqlDbType.VarBinary),
					new SqlParameter("@DataEncodingOption", SqlDbType.TinyInt,1),
					new SqlParameter("@MetadataEncodingOption", SqlDbType.TinyInt,1),
					new SqlParameter("@Version", SqlDbType.BigInt,8),
					new SqlParameter("@PendingTimer", SqlDbType.DateTime),
					new SqlParameter("@CreationTime", SqlDbType.DateTime),
					new SqlParameter("@LastUpdated", SqlDbType.DateTime),
					new SqlParameter("@WorkflowHostType", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@ServiceDeploymentId", SqlDbType.BigInt,8),
					new SqlParameter("@SuspensionExceptionName", SqlDbType.NVarChar,450),
					new SqlParameter("@SuspensionReason", SqlDbType.NVarChar),
					new SqlParameter("@BlockingBookmarks", SqlDbType.NVarChar),
					new SqlParameter("@LastMachineRunOn", SqlDbType.NVarChar,450),
					new SqlParameter("@ExecutionStatus", SqlDbType.NVarChar,450),
					new SqlParameter("@IsInitialized", SqlDbType.Bit,1),
					new SqlParameter("@IsSuspended", SqlDbType.Bit,1),
					new SqlParameter("@IsReadyToRun", SqlDbType.Bit,1),
					new SqlParameter("@IsCompleted", SqlDbType.Bit,1)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.SurrogateInstanceId;
			parameters[2].Value = model.SurrogateLockOwnerId;
			parameters[3].Value = model.PrimitiveDataProperties;
			parameters[4].Value = model.ComplexDataProperties;
			parameters[5].Value = model.WriteOnlyPrimitiveDataProperties;
			parameters[6].Value = model.WriteOnlyComplexDataProperties;
			parameters[7].Value = model.MetadataProperties;
			parameters[8].Value = model.DataEncodingOption;
			parameters[9].Value = model.MetadataEncodingOption;
			parameters[10].Value = model.Version;
			parameters[11].Value = model.PendingTimer;
			parameters[12].Value = model.CreationTime;
			parameters[13].Value = model.LastUpdated;
			parameters[14].Value = model.WorkflowHostType;
			parameters[15].Value = model.ServiceDeploymentId;
			parameters[16].Value = model.SuspensionExceptionName;
			parameters[17].Value = model.SuspensionReason;
			parameters[18].Value = model.BlockingBookmarks;
			parameters[19].Value = model.LastMachineRunOn;
			parameters[20].Value = model.ExecutionStatus;
			parameters[21].Value = model.IsInitialized;
			parameters[22].Value = model.IsSuspended;
			parameters[23].Value = model.IsReadyToRun;
			parameters[24].Value = model.IsCompleted;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(long SurrogateInstanceId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from InstancesTable ");
			strSql.Append(" where SurrogateInstanceId=@SurrogateInstanceId ");
			SqlParameter[] parameters = {
					new SqlParameter("@SurrogateInstanceId", SqlDbType.BigInt)};
			parameters[0].Value = SurrogateInstanceId;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public BookShop.Model.InstancesTable GetModel(long SurrogateInstanceId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,SurrogateInstanceId,SurrogateLockOwnerId,PrimitiveDataProperties,ComplexDataProperties,WriteOnlyPrimitiveDataProperties,WriteOnlyComplexDataProperties,MetadataProperties,DataEncodingOption,MetadataEncodingOption,Version,PendingTimer,CreationTime,LastUpdated,WorkflowHostType,ServiceDeploymentId,SuspensionExceptionName,SuspensionReason,BlockingBookmarks,LastMachineRunOn,ExecutionStatus,IsInitialized,IsSuspended,IsReadyToRun,IsCompleted from InstancesTable ");
			strSql.Append(" where SurrogateInstanceId=@SurrogateInstanceId ");
			SqlParameter[] parameters = {
					new SqlParameter("@SurrogateInstanceId", SqlDbType.BigInt)};
			parameters[0].Value = SurrogateInstanceId;

			BookShop.Model.InstancesTable model=new BookShop.Model.InstancesTable();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				//model.Id=ds.Tables[0].Rows[0]["Id"].ToString();
				if(ds.Tables[0].Rows[0]["SurrogateInstanceId"].ToString()!="")
				{
					model.SurrogateInstanceId=long.Parse(ds.Tables[0].Rows[0]["SurrogateInstanceId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["SurrogateLockOwnerId"].ToString()!="")
				{
					model.SurrogateLockOwnerId=long.Parse(ds.Tables[0].Rows[0]["SurrogateLockOwnerId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["PrimitiveDataProperties"].ToString()!="")
				{
					model.PrimitiveDataProperties=(byte[])ds.Tables[0].Rows[0]["PrimitiveDataProperties"];
				}
				if(ds.Tables[0].Rows[0]["ComplexDataProperties"].ToString()!="")
				{
					model.ComplexDataProperties=(byte[])ds.Tables[0].Rows[0]["ComplexDataProperties"];
				}
				if(ds.Tables[0].Rows[0]["WriteOnlyPrimitiveDataProperties"].ToString()!="")
				{
					model.WriteOnlyPrimitiveDataProperties=(byte[])ds.Tables[0].Rows[0]["WriteOnlyPrimitiveDataProperties"];
				}
				if(ds.Tables[0].Rows[0]["WriteOnlyComplexDataProperties"].ToString()!="")
				{
					model.WriteOnlyComplexDataProperties=(byte[])ds.Tables[0].Rows[0]["WriteOnlyComplexDataProperties"];
				}
				if(ds.Tables[0].Rows[0]["MetadataProperties"].ToString()!="")
				{
					model.MetadataProperties=(byte[])ds.Tables[0].Rows[0]["MetadataProperties"];
				}
				if(ds.Tables[0].Rows[0]["DataEncodingOption"].ToString()!="")
				{
					model.DataEncodingOption=int.Parse(ds.Tables[0].Rows[0]["DataEncodingOption"].ToString());
				}
				if(ds.Tables[0].Rows[0]["MetadataEncodingOption"].ToString()!="")
				{
					model.MetadataEncodingOption=int.Parse(ds.Tables[0].Rows[0]["MetadataEncodingOption"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Version"].ToString()!="")
				{
					model.Version=long.Parse(ds.Tables[0].Rows[0]["Version"].ToString());
				}
				if(ds.Tables[0].Rows[0]["PendingTimer"].ToString()!="")
				{
					model.PendingTimer=DateTime.Parse(ds.Tables[0].Rows[0]["PendingTimer"].ToString());
				}
				if(ds.Tables[0].Rows[0]["CreationTime"].ToString()!="")
				{
					model.CreationTime=DateTime.Parse(ds.Tables[0].Rows[0]["CreationTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["LastUpdated"].ToString()!="")
				{
					model.LastUpdated=DateTime.Parse(ds.Tables[0].Rows[0]["LastUpdated"].ToString());
				}
				//model.WorkflowHostType=ds.Tables[0].Rows[0]["WorkflowHostType"].ToString();
				if(ds.Tables[0].Rows[0]["ServiceDeploymentId"].ToString()!="")
				{
					model.ServiceDeploymentId=long.Parse(ds.Tables[0].Rows[0]["ServiceDeploymentId"].ToString());
				}
				model.SuspensionExceptionName=ds.Tables[0].Rows[0]["SuspensionExceptionName"].ToString();
				model.SuspensionReason=ds.Tables[0].Rows[0]["SuspensionReason"].ToString();
				model.BlockingBookmarks=ds.Tables[0].Rows[0]["BlockingBookmarks"].ToString();
				model.LastMachineRunOn=ds.Tables[0].Rows[0]["LastMachineRunOn"].ToString();
				model.ExecutionStatus=ds.Tables[0].Rows[0]["ExecutionStatus"].ToString();
				if(ds.Tables[0].Rows[0]["IsInitialized"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["IsInitialized"].ToString()=="1")||(ds.Tables[0].Rows[0]["IsInitialized"].ToString().ToLower()=="true"))
					{
						model.IsInitialized=true;
					}
					else
					{
						model.IsInitialized=false;
					}
				}
				if(ds.Tables[0].Rows[0]["IsSuspended"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["IsSuspended"].ToString()=="1")||(ds.Tables[0].Rows[0]["IsSuspended"].ToString().ToLower()=="true"))
					{
						model.IsSuspended=true;
					}
					else
					{
						model.IsSuspended=false;
					}
				}
				if(ds.Tables[0].Rows[0]["IsReadyToRun"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["IsReadyToRun"].ToString()=="1")||(ds.Tables[0].Rows[0]["IsReadyToRun"].ToString().ToLower()=="true"))
					{
						model.IsReadyToRun=true;
					}
					else
					{
						model.IsReadyToRun=false;
					}
				}
				if(ds.Tables[0].Rows[0]["IsCompleted"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["IsCompleted"].ToString()=="1")||(ds.Tables[0].Rows[0]["IsCompleted"].ToString().ToLower()=="true"))
					{
						model.IsCompleted=true;
					}
					else
					{
						model.IsCompleted=false;
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
			strSql.Append("select Id,SurrogateInstanceId,SurrogateLockOwnerId,PrimitiveDataProperties,ComplexDataProperties,WriteOnlyPrimitiveDataProperties,WriteOnlyComplexDataProperties,MetadataProperties,DataEncodingOption,MetadataEncodingOption,Version,PendingTimer,CreationTime,LastUpdated,WorkflowHostType,ServiceDeploymentId,SuspensionExceptionName,SuspensionReason,BlockingBookmarks,LastMachineRunOn,ExecutionStatus,IsInitialized,IsSuspended,IsReadyToRun,IsCompleted ");
			strSql.Append(" FROM InstancesTable ");
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
			strSql.Append(" Id,SurrogateInstanceId,SurrogateLockOwnerId,PrimitiveDataProperties,ComplexDataProperties,WriteOnlyPrimitiveDataProperties,WriteOnlyComplexDataProperties,MetadataProperties,DataEncodingOption,MetadataEncodingOption,Version,PendingTimer,CreationTime,LastUpdated,WorkflowHostType,ServiceDeploymentId,SuspensionExceptionName,SuspensionReason,BlockingBookmarks,LastMachineRunOn,ExecutionStatus,IsInitialized,IsSuspended,IsReadyToRun,IsCompleted ");
			strSql.Append(" FROM InstancesTable ");
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
			parameters[0].Value = "InstancesTable";
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

