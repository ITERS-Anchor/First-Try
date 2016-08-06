using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace BookShop.DAL
{
	/// <summary>
	/// 数据访问类FileInfoDAL。
	/// </summary>
	public class FileInfoDAL
	{
		public FileInfoDAL()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "FileInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from FileInfo");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(BookShop.Model.FileInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into FileInfo(");
			strSql.Append("Alt,Url,size,FileType,FileName,Ext,WF_InstanceID)");
			strSql.Append(" values (");
			strSql.Append("@Alt,@Url,@size,@FileType,@FileName,@Ext,@WF_InstanceID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Alt", SqlDbType.NVarChar,512),
					new SqlParameter("@Url", SqlDbType.NVarChar,32),
					new SqlParameter("@size", SqlDbType.Int,4),
					new SqlParameter("@FileType", SqlDbType.NVarChar,32),
					new SqlParameter("@FileName", SqlDbType.NVarChar,32),
					new SqlParameter("@Ext", SqlDbType.NVarChar,32),
					new SqlParameter("@WF_InstanceID", SqlDbType.Int,4)};
			parameters[0].Value = model.Alt;
			parameters[1].Value = model.Url;
			parameters[2].Value = model.size;
			parameters[3].Value = model.FileType;
			parameters[4].Value = model.FileName;
			parameters[5].Value = model.Ext;
			parameters[6].Value = model.WF_InstanceID;

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
		public void Update(BookShop.Model.FileInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update FileInfo set ");
			strSql.Append("Alt=@Alt,");
			strSql.Append("Url=@Url,");
			strSql.Append("size=@size,");
			strSql.Append("FileType=@FileType,");
			strSql.Append("FileName=@FileName,");
			strSql.Append("Ext=@Ext,");
			strSql.Append("WF_InstanceID=@WF_InstanceID");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@Alt", SqlDbType.NVarChar,512),
					new SqlParameter("@Url", SqlDbType.NVarChar,32),
					new SqlParameter("@size", SqlDbType.Int,4),
					new SqlParameter("@FileType", SqlDbType.NVarChar,32),
					new SqlParameter("@FileName", SqlDbType.NVarChar,32),
					new SqlParameter("@Ext", SqlDbType.NVarChar,32),
					new SqlParameter("@WF_InstanceID", SqlDbType.Int,4)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.Alt;
			parameters[2].Value = model.Url;
			parameters[3].Value = model.size;
			parameters[4].Value = model.FileType;
			parameters[5].Value = model.FileName;
			parameters[6].Value = model.Ext;
			parameters[7].Value = model.WF_InstanceID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from FileInfo ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public BookShop.Model.FileInfo GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Alt,Url,size,FileType,FileName,Ext,WF_InstanceID from FileInfo ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			BookShop.Model.FileInfo model=new BookShop.Model.FileInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				model.Alt=ds.Tables[0].Rows[0]["Alt"].ToString();
				model.Url=ds.Tables[0].Rows[0]["Url"].ToString();
				if(ds.Tables[0].Rows[0]["size"].ToString()!="")
				{
					model.size=int.Parse(ds.Tables[0].Rows[0]["size"].ToString());
				}
				model.FileType=ds.Tables[0].Rows[0]["FileType"].ToString();
				model.FileName=ds.Tables[0].Rows[0]["FileName"].ToString();
				model.Ext=ds.Tables[0].Rows[0]["Ext"].ToString();
				if(ds.Tables[0].Rows[0]["WF_InstanceID"].ToString()!="")
				{
					model.WF_InstanceID=int.Parse(ds.Tables[0].Rows[0]["WF_InstanceID"].ToString());
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
			strSql.Append("select ID,Alt,Url,size,FileType,FileName,Ext,WF_InstanceID ");
			strSql.Append(" FROM FileInfo ");
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
			strSql.Append(" ID,Alt,Url,size,FileType,FileName,Ext,WF_InstanceID ");
			strSql.Append(" FROM FileInfo ");
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
			parameters[0].Value = "FileInfo";
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

