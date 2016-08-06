using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace BookShop.DAL
{
	/// <summary>
	/// 数据访问类R_UserInfo_ActionInfoDAL。
	/// </summary>
	public class R_UserInfo_ActionInfoDAL
	{
		public R_UserInfo_ActionInfoDAL()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "R_UserInfo_ActionInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from R_UserInfo_ActionInfo");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(BookShop.Model.R_UserInfo_ActionInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into R_UserInfo_ActionInfo(");
			strSql.Append("IsPass,ActionInfoID,UserInfoID,ActionInfo_ID)");
			strSql.Append(" values (");
			strSql.Append("@IsPass,@ActionInfoID,@UserInfoID,@ActionInfo_ID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@IsPass", SqlDbType.SmallInt,2),
					new SqlParameter("@ActionInfoID", SqlDbType.Int,4),
					new SqlParameter("@UserInfoID", SqlDbType.Int,4),
					new SqlParameter("@ActionInfo_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.IsPass;
			parameters[1].Value = model.ActionInfoID;
			parameters[2].Value = model.UserInfoID;
			parameters[3].Value = model.ActionInfo_ID;

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
		public void Update(BookShop.Model.R_UserInfo_ActionInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update R_UserInfo_ActionInfo set ");
			strSql.Append("IsPass=@IsPass,");
			strSql.Append("ActionInfoID=@ActionInfoID,");
			strSql.Append("UserInfoID=@UserInfoID,");
			strSql.Append("ActionInfo_ID=@ActionInfo_ID");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@IsPass", SqlDbType.SmallInt,2),
					new SqlParameter("@ActionInfoID", SqlDbType.Int,4),
					new SqlParameter("@UserInfoID", SqlDbType.Int,4),
					new SqlParameter("@ActionInfo_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.IsPass;
			parameters[2].Value = model.ActionInfoID;
			parameters[3].Value = model.UserInfoID;
			parameters[4].Value = model.ActionInfo_ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from R_UserInfo_ActionInfo ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public BookShop.Model.R_UserInfo_ActionInfo GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,IsPass,ActionInfoID,UserInfoID,ActionInfo_ID from R_UserInfo_ActionInfo ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			BookShop.Model.R_UserInfo_ActionInfo model=new BookShop.Model.R_UserInfo_ActionInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["IsPass"].ToString()!="")
				{
					model.IsPass=int.Parse(ds.Tables[0].Rows[0]["IsPass"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ActionInfoID"].ToString()!="")
				{
					model.ActionInfoID=int.Parse(ds.Tables[0].Rows[0]["ActionInfoID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["UserInfoID"].ToString()!="")
				{
					model.UserInfoID=int.Parse(ds.Tables[0].Rows[0]["UserInfoID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ActionInfo_ID"].ToString()!="")
				{
					model.ActionInfo_ID=int.Parse(ds.Tables[0].Rows[0]["ActionInfo_ID"].ToString());
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
			strSql.Append("select ID,IsPass,ActionInfoID,UserInfoID,ActionInfo_ID ");
			strSql.Append(" FROM R_UserInfo_ActionInfo ");
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
			strSql.Append(" ID,IsPass,ActionInfoID,UserInfoID,ActionInfo_ID ");
			strSql.Append(" FROM R_UserInfo_ActionInfo ");
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
			parameters[0].Value = "R_UserInfo_ActionInfo";
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

