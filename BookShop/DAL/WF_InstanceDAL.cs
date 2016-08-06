using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace BookShop.DAL
{
	/// <summary>
	/// 数据访问类WF_InstanceDAL。
	/// </summary>
	public class WF_InstanceDAL
	{
		public WF_InstanceDAL()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "WF_Instance"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from WF_Instance");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(BookShop.Model.WF_Instance model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into WF_Instance(");
			strSql.Append("Title,SubBy,SubTime,OutTime,state,Result,Content,Level,WF_TempID,InstanceId)");
			strSql.Append(" values (");
			strSql.Append("@Title,@SubBy,@SubTime,@OutTime,@state,@Result,@Content,@Level,@WF_TempID,@InstanceId)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Title", SqlDbType.NVarChar,50),
					new SqlParameter("@SubBy", SqlDbType.Int,4),
					new SqlParameter("@SubTime", SqlDbType.DateTime),
					new SqlParameter("@OutTime", SqlDbType.DateTime),
					new SqlParameter("@state", SqlDbType.Int,4),
					new SqlParameter("@Result", SqlDbType.Int,4),
					new SqlParameter("@Content", SqlDbType.NVarChar,100),
					new SqlParameter("@Level", SqlDbType.Int,4),
					new SqlParameter("@WF_TempID", SqlDbType.Int,4),
					new SqlParameter("@InstanceId", SqlDbType.UniqueIdentifier,16)};
			parameters[0].Value = model.Title;
			parameters[1].Value = model.SubBy;
			parameters[2].Value = model.SubTime;
			parameters[3].Value = model.OutTime;
			parameters[4].Value = model.state;
			parameters[5].Value = model.Result;
			parameters[6].Value = model.Content;
			parameters[7].Value = model.Level;
			parameters[8].Value = model.WF_TempID;
			parameters[9].Value = model.InstanceId;

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
		public void Update(BookShop.Model.WF_Instance model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update WF_Instance set ");
			strSql.Append("Title=@Title,");
			strSql.Append("SubBy=@SubBy,");
			strSql.Append("SubTime=@SubTime,");
			strSql.Append("OutTime=@OutTime,");
			strSql.Append("state=@state,");
			strSql.Append("Result=@Result,");
			strSql.Append("Content=@Content,");
			strSql.Append("Level=@Level,");
			strSql.Append("WF_TempID=@WF_TempID,");
			strSql.Append("InstanceId=@InstanceId");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@Title", SqlDbType.NVarChar,50),
					new SqlParameter("@SubBy", SqlDbType.Int,4),
					new SqlParameter("@SubTime", SqlDbType.DateTime),
					new SqlParameter("@OutTime", SqlDbType.DateTime),
					new SqlParameter("@state", SqlDbType.Int,4),
					new SqlParameter("@Result", SqlDbType.Int,4),
					new SqlParameter("@Content", SqlDbType.NVarChar,100),
					new SqlParameter("@Level", SqlDbType.Int,4),
					new SqlParameter("@WF_TempID", SqlDbType.Int,4),
					new SqlParameter("@InstanceId", SqlDbType.UniqueIdentifier,16)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.Title;
			parameters[2].Value = model.SubBy;
			parameters[3].Value = model.SubTime;
			parameters[4].Value = model.OutTime;
			parameters[5].Value = model.state;
			parameters[6].Value = model.Result;
			parameters[7].Value = model.Content;
			parameters[8].Value = model.Level;
			parameters[9].Value = model.WF_TempID;
			parameters[10].Value = model.InstanceId;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from WF_Instance ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public BookShop.Model.WF_Instance GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Title,SubBy,SubTime,OutTime,state,Result,Content,Level,WF_TempID,InstanceId from WF_Instance ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			BookShop.Model.WF_Instance model=new BookShop.Model.WF_Instance();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				model.Title=ds.Tables[0].Rows[0]["Title"].ToString();
				if(ds.Tables[0].Rows[0]["SubBy"].ToString()!="")
				{
					model.SubBy=int.Parse(ds.Tables[0].Rows[0]["SubBy"].ToString());
				}
				if(ds.Tables[0].Rows[0]["SubTime"].ToString()!="")
				{
					model.SubTime=DateTime.Parse(ds.Tables[0].Rows[0]["SubTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["OutTime"].ToString()!="")
				{
					model.OutTime=DateTime.Parse(ds.Tables[0].Rows[0]["OutTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["state"].ToString()!="")
				{
					model.state=int.Parse(ds.Tables[0].Rows[0]["state"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Result"].ToString()!="")
				{
					model.Result=int.Parse(ds.Tables[0].Rows[0]["Result"].ToString());
				}
				model.Content=ds.Tables[0].Rows[0]["Content"].ToString();
				if(ds.Tables[0].Rows[0]["Level"].ToString()!="")
				{
					model.Level=int.Parse(ds.Tables[0].Rows[0]["Level"].ToString());
				}
				if(ds.Tables[0].Rows[0]["WF_TempID"].ToString()!="")
				{
					model.WF_TempID=int.Parse(ds.Tables[0].Rows[0]["WF_TempID"].ToString());
				}
				//model.InstanceId=ds.Tables[0].Rows[0]["InstanceId"].ToString();
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
			strSql.Append("select ID,Title,SubBy,SubTime,OutTime,state,Result,Content,Level,WF_TempID,InstanceId ");
			strSql.Append(" FROM WF_Instance ");
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
			strSql.Append(" ID,Title,SubBy,SubTime,OutTime,state,Result,Content,Level,WF_TempID,InstanceId ");
			strSql.Append(" FROM WF_Instance ");
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
			parameters[0].Value = "WF_Instance";
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

