using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace BookShop.DAL
{
	/// <summary>
	/// 数据访问类WF_StepDAL。
	/// </summary>
	public class WF_StepDAL
	{
		public WF_StepDAL()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "WF_Step"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from WF_Step");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(BookShop.Model.WF_Step model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into WF_Step(");
			strSql.Append("subTime,ProcessTime,ProcessBy,StepName,Comment,FlowTo,IsStart,IsEnd,State,ParentStepId,Sort,WF_InstanceID,InstanceId,IsProcessed)");
			strSql.Append(" values (");
			strSql.Append("@subTime,@ProcessTime,@ProcessBy,@StepName,@Comment,@FlowTo,@IsStart,@IsEnd,@State,@ParentStepId,@Sort,@WF_InstanceID,@InstanceId,@IsProcessed)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@subTime", SqlDbType.DateTime),
					new SqlParameter("@ProcessTime", SqlDbType.DateTime),
					new SqlParameter("@ProcessBy", SqlDbType.Int,4),
					new SqlParameter("@StepName", SqlDbType.NVarChar,32),
					new SqlParameter("@Comment", SqlDbType.NVarChar,100),
					new SqlParameter("@FlowTo", SqlDbType.Int,4),
					new SqlParameter("@IsStart", SqlDbType.Bit,1),
					new SqlParameter("@IsEnd", SqlDbType.Bit,1),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@ParentStepId", SqlDbType.Int,4),
					new SqlParameter("@Sort", SqlDbType.Int,4),
					new SqlParameter("@WF_InstanceID", SqlDbType.Int,4),
					new SqlParameter("@InstanceId", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@IsProcessed", SqlDbType.Bit,1)};
			parameters[0].Value = model.subTime;
			parameters[1].Value = model.ProcessTime;
			parameters[2].Value = model.ProcessBy;
			parameters[3].Value = model.StepName;
			parameters[4].Value = model.Comment;
			parameters[5].Value = model.FlowTo;
			parameters[6].Value = model.IsStart;
			parameters[7].Value = model.IsEnd;
			parameters[8].Value = model.State;
			parameters[9].Value = model.ParentStepId;
			parameters[10].Value = model.Sort;
			parameters[11].Value = model.WF_InstanceID;
			parameters[12].Value = model.InstanceId;
			parameters[13].Value = model.IsProcessed;

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
		public void Update(BookShop.Model.WF_Step model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update WF_Step set ");
			strSql.Append("subTime=@subTime,");
			strSql.Append("ProcessTime=@ProcessTime,");
			strSql.Append("ProcessBy=@ProcessBy,");
			strSql.Append("StepName=@StepName,");
			strSql.Append("Comment=@Comment,");
			strSql.Append("FlowTo=@FlowTo,");
			strSql.Append("IsStart=@IsStart,");
			strSql.Append("IsEnd=@IsEnd,");
			strSql.Append("State=@State,");
			strSql.Append("ParentStepId=@ParentStepId,");
			strSql.Append("Sort=@Sort,");
			strSql.Append("WF_InstanceID=@WF_InstanceID,");
			strSql.Append("InstanceId=@InstanceId,");
			strSql.Append("IsProcessed=@IsProcessed");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@subTime", SqlDbType.DateTime),
					new SqlParameter("@ProcessTime", SqlDbType.DateTime),
					new SqlParameter("@ProcessBy", SqlDbType.Int,4),
					new SqlParameter("@StepName", SqlDbType.NVarChar,32),
					new SqlParameter("@Comment", SqlDbType.NVarChar,100),
					new SqlParameter("@FlowTo", SqlDbType.Int,4),
					new SqlParameter("@IsStart", SqlDbType.Bit,1),
					new SqlParameter("@IsEnd", SqlDbType.Bit,1),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@ParentStepId", SqlDbType.Int,4),
					new SqlParameter("@Sort", SqlDbType.Int,4),
					new SqlParameter("@WF_InstanceID", SqlDbType.Int,4),
					new SqlParameter("@InstanceId", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@IsProcessed", SqlDbType.Bit,1)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.subTime;
			parameters[2].Value = model.ProcessTime;
			parameters[3].Value = model.ProcessBy;
			parameters[4].Value = model.StepName;
			parameters[5].Value = model.Comment;
			parameters[6].Value = model.FlowTo;
			parameters[7].Value = model.IsStart;
			parameters[8].Value = model.IsEnd;
			parameters[9].Value = model.State;
			parameters[10].Value = model.ParentStepId;
			parameters[11].Value = model.Sort;
			parameters[12].Value = model.WF_InstanceID;
			parameters[13].Value = model.InstanceId;
			parameters[14].Value = model.IsProcessed;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from WF_Step ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public BookShop.Model.WF_Step GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,subTime,ProcessTime,ProcessBy,StepName,Comment,FlowTo,IsStart,IsEnd,State,ParentStepId,Sort,WF_InstanceID,InstanceId,IsProcessed from WF_Step ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			BookShop.Model.WF_Step model=new BookShop.Model.WF_Step();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["subTime"].ToString()!="")
				{
					model.subTime=DateTime.Parse(ds.Tables[0].Rows[0]["subTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ProcessTime"].ToString()!="")
				{
					model.ProcessTime=DateTime.Parse(ds.Tables[0].Rows[0]["ProcessTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ProcessBy"].ToString()!="")
				{
					model.ProcessBy=int.Parse(ds.Tables[0].Rows[0]["ProcessBy"].ToString());
				}
				model.StepName=ds.Tables[0].Rows[0]["StepName"].ToString();
				model.Comment=ds.Tables[0].Rows[0]["Comment"].ToString();
				if(ds.Tables[0].Rows[0]["FlowTo"].ToString()!="")
				{
					model.FlowTo=int.Parse(ds.Tables[0].Rows[0]["FlowTo"].ToString());
				}
				if(ds.Tables[0].Rows[0]["IsStart"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["IsStart"].ToString()=="1")||(ds.Tables[0].Rows[0]["IsStart"].ToString().ToLower()=="true"))
					{
						model.IsStart=true;
					}
					else
					{
						model.IsStart=false;
					}
				}
				if(ds.Tables[0].Rows[0]["IsEnd"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["IsEnd"].ToString()=="1")||(ds.Tables[0].Rows[0]["IsEnd"].ToString().ToLower()=="true"))
					{
						model.IsEnd=true;
					}
					else
					{
						model.IsEnd=false;
					}
				}
				if(ds.Tables[0].Rows[0]["State"].ToString()!="")
				{
					model.State=int.Parse(ds.Tables[0].Rows[0]["State"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ParentStepId"].ToString()!="")
				{
					model.ParentStepId=int.Parse(ds.Tables[0].Rows[0]["ParentStepId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Sort"].ToString()!="")
				{
					model.Sort=int.Parse(ds.Tables[0].Rows[0]["Sort"].ToString());
				}
				if(ds.Tables[0].Rows[0]["WF_InstanceID"].ToString()!="")
				{
					model.WF_InstanceID=int.Parse(ds.Tables[0].Rows[0]["WF_InstanceID"].ToString());
				}
				//model.InstanceId=ds.Tables[0].Rows[0]["InstanceId"].ToString();
				if(ds.Tables[0].Rows[0]["IsProcessed"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["IsProcessed"].ToString()=="1")||(ds.Tables[0].Rows[0]["IsProcessed"].ToString().ToLower()=="true"))
					{
						model.IsProcessed=true;
					}
					else
					{
						model.IsProcessed=false;
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
			strSql.Append("select ID,subTime,ProcessTime,ProcessBy,StepName,Comment,FlowTo,IsStart,IsEnd,State,ParentStepId,Sort,WF_InstanceID,InstanceId,IsProcessed ");
			strSql.Append(" FROM WF_Step ");
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
			strSql.Append(" ID,subTime,ProcessTime,ProcessBy,StepName,Comment,FlowTo,IsStart,IsEnd,State,ParentStepId,Sort,WF_InstanceID,InstanceId,IsProcessed ");
			strSql.Append(" FROM WF_Step ");
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
			parameters[0].Value = "WF_Step";
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

