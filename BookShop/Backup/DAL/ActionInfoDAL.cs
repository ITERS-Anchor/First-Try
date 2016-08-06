using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace BookShop.DAL
{
	/// <summary>
	/// 数据访问类ActionInfoDAL。
	/// </summary>
	public class ActionInfoDAL
	{
		public ActionInfoDAL()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "ActionInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ActionInfo");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(BookShop.Model.ActionInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ActionInfo(");
			strSql.Append("ActionInfoName,Url,HttpMethod,Remark,DelFalg,SubTime,IsMenu,R_UserInfo_ActionInfoID)");
			strSql.Append(" values (");
			strSql.Append("@ActionInfoName,@Url,@HttpMethod,@Remark,@DelFalg,@SubTime,@IsMenu,@R_UserInfo_ActionInfoID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ActionInfoName", SqlDbType.NVarChar,32),
					new SqlParameter("@Url", SqlDbType.VarChar,256),
					new SqlParameter("@HttpMethod", SqlDbType.SmallInt,2),
					new SqlParameter("@Remark", SqlDbType.NVarChar,256),
					new SqlParameter("@DelFalg", SqlDbType.SmallInt,2),
					new SqlParameter("@SubTime", SqlDbType.DateTime),
					new SqlParameter("@IsMenu", SqlDbType.Bit,1),
					new SqlParameter("@R_UserInfo_ActionInfoID", SqlDbType.Int,4)};
			parameters[0].Value = model.ActionInfoName;
			parameters[1].Value = model.Url;
			parameters[2].Value = model.HttpMethod;
			parameters[3].Value = model.Remark;
			parameters[4].Value = model.DelFalg;
			parameters[5].Value = model.SubTime;
			parameters[6].Value = model.IsMenu;
			parameters[7].Value = model.R_UserInfo_ActionInfoID;

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
		public void Update(BookShop.Model.ActionInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ActionInfo set ");
			strSql.Append("ActionInfoName=@ActionInfoName,");
			strSql.Append("Url=@Url,");
			strSql.Append("HttpMethod=@HttpMethod,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("DelFalg=@DelFalg,");
			strSql.Append("SubTime=@SubTime,");
			strSql.Append("IsMenu=@IsMenu,");
			strSql.Append("R_UserInfo_ActionInfoID=@R_UserInfo_ActionInfoID");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@ActionInfoName", SqlDbType.NVarChar,32),
					new SqlParameter("@Url", SqlDbType.VarChar,256),
					new SqlParameter("@HttpMethod", SqlDbType.SmallInt,2),
					new SqlParameter("@Remark", SqlDbType.NVarChar,256),
					new SqlParameter("@DelFalg", SqlDbType.SmallInt,2),
					new SqlParameter("@SubTime", SqlDbType.DateTime),
					new SqlParameter("@IsMenu", SqlDbType.Bit,1),
					new SqlParameter("@R_UserInfo_ActionInfoID", SqlDbType.Int,4)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.ActionInfoName;
			parameters[2].Value = model.Url;
			parameters[3].Value = model.HttpMethod;
			parameters[4].Value = model.Remark;
			parameters[5].Value = model.DelFalg;
			parameters[6].Value = model.SubTime;
			parameters[7].Value = model.IsMenu;
			parameters[8].Value = model.R_UserInfo_ActionInfoID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ActionInfo ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public BookShop.Model.ActionInfo GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,ActionInfoName,Url,HttpMethod,Remark,DelFalg,SubTime,IsMenu,R_UserInfo_ActionInfoID from ActionInfo ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			BookShop.Model.ActionInfo model=new BookShop.Model.ActionInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				model.ActionInfoName=ds.Tables[0].Rows[0]["ActionInfoName"].ToString();
				model.Url=ds.Tables[0].Rows[0]["Url"].ToString();
				if(ds.Tables[0].Rows[0]["HttpMethod"].ToString()!="")
				{
					model.HttpMethod=int.Parse(ds.Tables[0].Rows[0]["HttpMethod"].ToString());
				}
				model.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
				if(ds.Tables[0].Rows[0]["DelFalg"].ToString()!="")
				{
					model.DelFalg=int.Parse(ds.Tables[0].Rows[0]["DelFalg"].ToString());
				}
				if(ds.Tables[0].Rows[0]["SubTime"].ToString()!="")
				{
					model.SubTime=DateTime.Parse(ds.Tables[0].Rows[0]["SubTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["IsMenu"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["IsMenu"].ToString()=="1")||(ds.Tables[0].Rows[0]["IsMenu"].ToString().ToLower()=="true"))
					{
						model.IsMenu=true;
					}
					else
					{
						model.IsMenu=false;
					}
				}
				if(ds.Tables[0].Rows[0]["R_UserInfo_ActionInfoID"].ToString()!="")
				{
					model.R_UserInfo_ActionInfoID=int.Parse(ds.Tables[0].Rows[0]["R_UserInfo_ActionInfoID"].ToString());
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
			strSql.Append("select ID,ActionInfoName,Url,HttpMethod,Remark,DelFalg,SubTime,IsMenu,R_UserInfo_ActionInfoID ");
			strSql.Append(" FROM ActionInfo ");
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
			strSql.Append(" ID,ActionInfoName,Url,HttpMethod,Remark,DelFalg,SubTime,IsMenu,R_UserInfo_ActionInfoID ");
			strSql.Append(" FROM ActionInfo ");
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
			parameters[0].Value = "ActionInfo";
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

