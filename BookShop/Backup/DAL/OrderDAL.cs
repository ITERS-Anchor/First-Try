using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace BookShop.DAL
{
	/// <summary>
	/// 数据访问类OrderDAL。
	/// </summary>
	public class OrderDAL
	{
		public OrderDAL()
		{}
		#region  成员方法

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(uniqueidentifier ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Order");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.UniqueIdentifier)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(BookShop.Model.Order model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Order(");
			strSql.Append("ID,OrderNum,SubDateTime,CustomerID)");
			strSql.Append(" values (");
			strSql.Append("@ID,@OrderNum,@SubDateTime,@CustomerID)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@OrderNum", SqlDbType.NVarChar,50),
					new SqlParameter("@SubDateTime", SqlDbType.DateTime),
					new SqlParameter("@CustomerID", SqlDbType.Int,4)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.OrderNum;
			parameters[2].Value = model.SubDateTime;
			parameters[3].Value = model.CustomerID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(BookShop.Model.Order model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Order set ");
			strSql.Append("OrderNum=@OrderNum,");
			strSql.Append("SubDateTime=@SubDateTime,");
			strSql.Append("CustomerID=@CustomerID");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@OrderNum", SqlDbType.NVarChar,50),
					new SqlParameter("@SubDateTime", SqlDbType.DateTime),
					new SqlParameter("@CustomerID", SqlDbType.Int,4)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.OrderNum;
			parameters[2].Value = model.SubDateTime;
			parameters[3].Value = model.CustomerID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(uniqueidentifier ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Order ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.UniqueIdentifier)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public BookShop.Model.Order GetModel(uniqueidentifier ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,OrderNum,SubDateTime,CustomerID from Order ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.UniqueIdentifier)};
			parameters[0].Value = ID;

			BookShop.Model.Order model=new BookShop.Model.Order();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				//model.ID=ds.Tables[0].Rows[0]["ID"].ToString();
				model.OrderNum=ds.Tables[0].Rows[0]["OrderNum"].ToString();
				if(ds.Tables[0].Rows[0]["SubDateTime"].ToString()!="")
				{
					model.SubDateTime=DateTime.Parse(ds.Tables[0].Rows[0]["SubDateTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["CustomerID"].ToString()!="")
				{
					model.CustomerID=int.Parse(ds.Tables[0].Rows[0]["CustomerID"].ToString());
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
			strSql.Append("select ID,OrderNum,SubDateTime,CustomerID ");
			strSql.Append(" FROM Order ");
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
			strSql.Append(" ID,OrderNum,SubDateTime,CustomerID ");
			strSql.Append(" FROM Order ");
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
			parameters[0].Value = "Order";
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

