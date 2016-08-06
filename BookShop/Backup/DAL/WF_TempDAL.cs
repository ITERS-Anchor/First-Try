using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace BookShop.DAL
{
	/// <summary>
	/// 数据访问类WF_TempDAL。
	/// </summary>
	public class WF_TempDAL
	{
		public WF_TempDAL()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "WF_Temp"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from WF_Temp");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(BookShop.Model.WF_Temp model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into WF_Temp(");
			strSql.Append("TempName,SubTime,ActiveType,Description,FormTemp,state)");
			strSql.Append(" values (");
			strSql.Append("@TempName,@SubTime,@ActiveType,@Description,@FormTemp,@state)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@TempName", SqlDbType.NVarChar,50),
					new SqlParameter("@SubTime", SqlDbType.DateTime),
					new SqlParameter("@ActiveType", SqlDbType.NVarChar,512),
					new SqlParameter("@Description", SqlDbType.NVarChar,50),
					new SqlParameter("@FormTemp", SqlDbType.NVarChar,100),
					new SqlParameter("@state", SqlDbType.Int,4)};
			parameters[0].Value = model.TempName;
			parameters[1].Value = model.SubTime;
			parameters[2].Value = model.ActiveType;
			parameters[3].Value = model.Description;
			parameters[4].Value = model.FormTemp;
			parameters[5].Value = model.state;

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
		public void Update(BookShop.Model.WF_Temp model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update WF_Temp set ");
			strSql.Append("TempName=@TempName,");
			strSql.Append("SubTime=@SubTime,");
			strSql.Append("ActiveType=@ActiveType,");
			strSql.Append("Description=@Description,");
			strSql.Append("FormTemp=@FormTemp,");
			strSql.Append("state=@state");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@TempName", SqlDbType.NVarChar,50),
					new SqlParameter("@SubTime", SqlDbType.DateTime),
					new SqlParameter("@ActiveType", SqlDbType.NVarChar,512),
					new SqlParameter("@Description", SqlDbType.NVarChar,50),
					new SqlParameter("@FormTemp", SqlDbType.NVarChar,100),
					new SqlParameter("@state", SqlDbType.Int,4)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.TempName;
			parameters[2].Value = model.SubTime;
			parameters[3].Value = model.ActiveType;
			parameters[4].Value = model.Description;
			parameters[5].Value = model.FormTemp;
			parameters[6].Value = model.state;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from WF_Temp ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public BookShop.Model.WF_Temp GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,TempName,SubTime,ActiveType,Description,FormTemp,state from WF_Temp ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			BookShop.Model.WF_Temp model=new BookShop.Model.WF_Temp();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				model.TempName=ds.Tables[0].Rows[0]["TempName"].ToString();
				if(ds.Tables[0].Rows[0]["SubTime"].ToString()!="")
				{
					model.SubTime=DateTime.Parse(ds.Tables[0].Rows[0]["SubTime"].ToString());
				}
				model.ActiveType=ds.Tables[0].Rows[0]["ActiveType"].ToString();
				model.Description=ds.Tables[0].Rows[0]["Description"].ToString();
				model.FormTemp=ds.Tables[0].Rows[0]["FormTemp"].ToString();
				if(ds.Tables[0].Rows[0]["state"].ToString()!="")
				{
					model.state=int.Parse(ds.Tables[0].Rows[0]["state"].ToString());
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
			strSql.Append("select ID,TempName,SubTime,ActiveType,Description,FormTemp,state ");
			strSql.Append(" FROM WF_Temp ");
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
			strSql.Append(" ID,TempName,SubTime,ActiveType,Description,FormTemp,state ");
			strSql.Append(" FROM WF_Temp ");
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
			parameters[0].Value = "WF_Temp";
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

