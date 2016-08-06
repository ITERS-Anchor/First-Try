using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//�����������
namespace BookShop.DAL
{
	/// <summary>
	/// ���ݷ�����RunnableInstancesTableDAL��
	/// </summary>
	public class RunnableInstancesTableDAL
	{
		public RunnableInstancesTableDAL()
		{}
		#region  ��Ա����



		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(BookShop.Model.RunnableInstancesTable model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into RunnableInstancesTable(");
			strSql.Append("SurrogateInstanceId,WorkflowHostType,ServiceDeploymentId,RunnableTime)");
			strSql.Append(" values (");
			strSql.Append("@SurrogateInstanceId,@WorkflowHostType,@ServiceDeploymentId,@RunnableTime)");
			SqlParameter[] parameters = {
					new SqlParameter("@SurrogateInstanceId", SqlDbType.BigInt,8),
					new SqlParameter("@WorkflowHostType", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@ServiceDeploymentId", SqlDbType.BigInt,8),
					new SqlParameter("@RunnableTime", SqlDbType.DateTime)};
			parameters[0].Value = model.SurrogateInstanceId;
			parameters[1].Value = model.WorkflowHostType;
			parameters[2].Value = model.ServiceDeploymentId;
			parameters[3].Value = model.RunnableTime;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(BookShop.Model.RunnableInstancesTable model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update RunnableInstancesTable set ");
			strSql.Append("SurrogateInstanceId=@SurrogateInstanceId,");
			strSql.Append("WorkflowHostType=@WorkflowHostType,");
			strSql.Append("ServiceDeploymentId=@ServiceDeploymentId,");
			strSql.Append("RunnableTime=@RunnableTime");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@SurrogateInstanceId", SqlDbType.BigInt,8),
					new SqlParameter("@WorkflowHostType", SqlDbType.UniqueIdentifier,16),
					new SqlParameter("@ServiceDeploymentId", SqlDbType.BigInt,8),
					new SqlParameter("@RunnableTime", SqlDbType.DateTime)};
			parameters[0].Value = model.SurrogateInstanceId;
			parameters[1].Value = model.WorkflowHostType;
			parameters[2].Value = model.ServiceDeploymentId;
			parameters[3].Value = model.RunnableTime;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from RunnableInstancesTable ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
};

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public BookShop.Model.RunnableInstancesTable GetModel()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 SurrogateInstanceId,WorkflowHostType,ServiceDeploymentId,RunnableTime from RunnableInstancesTable ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
};

			BookShop.Model.RunnableInstancesTable model=new BookShop.Model.RunnableInstancesTable();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["SurrogateInstanceId"].ToString()!="")
				{
					model.SurrogateInstanceId=long.Parse(ds.Tables[0].Rows[0]["SurrogateInstanceId"].ToString());
				}
				//model.WorkflowHostType=ds.Tables[0].Rows[0]["WorkflowHostType"].ToString();
				if(ds.Tables[0].Rows[0]["ServiceDeploymentId"].ToString()!="")
				{
					model.ServiceDeploymentId=long.Parse(ds.Tables[0].Rows[0]["ServiceDeploymentId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["RunnableTime"].ToString()!="")
				{
					model.RunnableTime=DateTime.Parse(ds.Tables[0].Rows[0]["RunnableTime"].ToString());
				}
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select SurrogateInstanceId,WorkflowHostType,ServiceDeploymentId,RunnableTime ");
			strSql.Append(" FROM RunnableInstancesTable ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// ���ǰ��������
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" SurrogateInstanceId,WorkflowHostType,ServiceDeploymentId,RunnableTime ");
			strSql.Append(" FROM RunnableInstancesTable ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// ��ҳ��ȡ�����б�
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
			parameters[0].Value = "RunnableInstancesTable";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  ��Ա����
	}
}

