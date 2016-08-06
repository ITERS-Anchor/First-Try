using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace BookShop.DAL
{
	/// <summary>
	/// 数据访问类InstancePromotedPropertiesTableDAL。
	/// </summary>
	public class InstancePromotedPropertiesTableDAL
	{
		public InstancePromotedPropertiesTableDAL()
		{}
		#region  成员方法



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(BookShop.Model.InstancePromotedPropertiesTable model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into InstancePromotedPropertiesTable(");
			strSql.Append("SurrogateInstanceId,PromotionName,Value1,Value2,Value3,Value4,Value5,Value6,Value7,Value8,Value9,Value10,Value11,Value12,Value13,Value14,Value15,Value16,Value17,Value18,Value19,Value20,Value21,Value22,Value23,Value24,Value25,Value26,Value27,Value28,Value29,Value30,Value31,Value32,Value33,Value34,Value35,Value36,Value37,Value38,Value39,Value40,Value41,Value42,Value43,Value44,Value45,Value46,Value47,Value48,Value49,Value50,Value51,Value52,Value53,Value54,Value55,Value56,Value57,Value58,Value59,Value60,Value61,Value62,Value63,Value64)");
			strSql.Append(" values (");
			strSql.Append("@SurrogateInstanceId,@PromotionName,@Value1,@Value2,@Value3,@Value4,@Value5,@Value6,@Value7,@Value8,@Value9,@Value10,@Value11,@Value12,@Value13,@Value14,@Value15,@Value16,@Value17,@Value18,@Value19,@Value20,@Value21,@Value22,@Value23,@Value24,@Value25,@Value26,@Value27,@Value28,@Value29,@Value30,@Value31,@Value32,@Value33,@Value34,@Value35,@Value36,@Value37,@Value38,@Value39,@Value40,@Value41,@Value42,@Value43,@Value44,@Value45,@Value46,@Value47,@Value48,@Value49,@Value50,@Value51,@Value52,@Value53,@Value54,@Value55,@Value56,@Value57,@Value58,@Value59,@Value60,@Value61,@Value62,@Value63,@Value64)");
			SqlParameter[] parameters = {
					new SqlParameter("@SurrogateInstanceId", SqlDbType.BigInt,8),
					new SqlParameter("@PromotionName", SqlDbType.NVarChar,400),
					new SqlParameter("@Value1", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value2", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value3", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value4", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value5", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value6", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value7", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value8", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value9", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value10", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value11", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value12", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value13", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value14", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value15", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value16", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value17", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value18", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value19", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value20", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value21", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value22", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value23", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value24", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value25", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value26", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value27", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value28", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value29", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value30", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value31", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value32", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value33", SqlDbType.VarBinary),
					new SqlParameter("@Value34", SqlDbType.VarBinary),
					new SqlParameter("@Value35", SqlDbType.VarBinary),
					new SqlParameter("@Value36", SqlDbType.VarBinary),
					new SqlParameter("@Value37", SqlDbType.VarBinary),
					new SqlParameter("@Value38", SqlDbType.VarBinary),
					new SqlParameter("@Value39", SqlDbType.VarBinary),
					new SqlParameter("@Value40", SqlDbType.VarBinary),
					new SqlParameter("@Value41", SqlDbType.VarBinary),
					new SqlParameter("@Value42", SqlDbType.VarBinary),
					new SqlParameter("@Value43", SqlDbType.VarBinary),
					new SqlParameter("@Value44", SqlDbType.VarBinary),
					new SqlParameter("@Value45", SqlDbType.VarBinary),
					new SqlParameter("@Value46", SqlDbType.VarBinary),
					new SqlParameter("@Value47", SqlDbType.VarBinary),
					new SqlParameter("@Value48", SqlDbType.VarBinary),
					new SqlParameter("@Value49", SqlDbType.VarBinary),
					new SqlParameter("@Value50", SqlDbType.VarBinary),
					new SqlParameter("@Value51", SqlDbType.VarBinary),
					new SqlParameter("@Value52", SqlDbType.VarBinary),
					new SqlParameter("@Value53", SqlDbType.VarBinary),
					new SqlParameter("@Value54", SqlDbType.VarBinary),
					new SqlParameter("@Value55", SqlDbType.VarBinary),
					new SqlParameter("@Value56", SqlDbType.VarBinary),
					new SqlParameter("@Value57", SqlDbType.VarBinary),
					new SqlParameter("@Value58", SqlDbType.VarBinary),
					new SqlParameter("@Value59", SqlDbType.VarBinary),
					new SqlParameter("@Value60", SqlDbType.VarBinary),
					new SqlParameter("@Value61", SqlDbType.VarBinary),
					new SqlParameter("@Value62", SqlDbType.VarBinary),
					new SqlParameter("@Value63", SqlDbType.VarBinary),
					new SqlParameter("@Value64", SqlDbType.VarBinary)};
			parameters[0].Value = model.SurrogateInstanceId;
			parameters[1].Value = model.PromotionName;
			parameters[2].Value = model.Value1;
			parameters[3].Value = model.Value2;
			parameters[4].Value = model.Value3;
			parameters[5].Value = model.Value4;
			parameters[6].Value = model.Value5;
			parameters[7].Value = model.Value6;
			parameters[8].Value = model.Value7;
			parameters[9].Value = model.Value8;
			parameters[10].Value = model.Value9;
			parameters[11].Value = model.Value10;
			parameters[12].Value = model.Value11;
			parameters[13].Value = model.Value12;
			parameters[14].Value = model.Value13;
			parameters[15].Value = model.Value14;
			parameters[16].Value = model.Value15;
			parameters[17].Value = model.Value16;
			parameters[18].Value = model.Value17;
			parameters[19].Value = model.Value18;
			parameters[20].Value = model.Value19;
			parameters[21].Value = model.Value20;
			parameters[22].Value = model.Value21;
			parameters[23].Value = model.Value22;
			parameters[24].Value = model.Value23;
			parameters[25].Value = model.Value24;
			parameters[26].Value = model.Value25;
			parameters[27].Value = model.Value26;
			parameters[28].Value = model.Value27;
			parameters[29].Value = model.Value28;
			parameters[30].Value = model.Value29;
			parameters[31].Value = model.Value30;
			parameters[32].Value = model.Value31;
			parameters[33].Value = model.Value32;
			parameters[34].Value = model.Value33;
			parameters[35].Value = model.Value34;
			parameters[36].Value = model.Value35;
			parameters[37].Value = model.Value36;
			parameters[38].Value = model.Value37;
			parameters[39].Value = model.Value38;
			parameters[40].Value = model.Value39;
			parameters[41].Value = model.Value40;
			parameters[42].Value = model.Value41;
			parameters[43].Value = model.Value42;
			parameters[44].Value = model.Value43;
			parameters[45].Value = model.Value44;
			parameters[46].Value = model.Value45;
			parameters[47].Value = model.Value46;
			parameters[48].Value = model.Value47;
			parameters[49].Value = model.Value48;
			parameters[50].Value = model.Value49;
			parameters[51].Value = model.Value50;
			parameters[52].Value = model.Value51;
			parameters[53].Value = model.Value52;
			parameters[54].Value = model.Value53;
			parameters[55].Value = model.Value54;
			parameters[56].Value = model.Value55;
			parameters[57].Value = model.Value56;
			parameters[58].Value = model.Value57;
			parameters[59].Value = model.Value58;
			parameters[60].Value = model.Value59;
			parameters[61].Value = model.Value60;
			parameters[62].Value = model.Value61;
			parameters[63].Value = model.Value62;
			parameters[64].Value = model.Value63;
			parameters[65].Value = model.Value64;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(BookShop.Model.InstancePromotedPropertiesTable model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update InstancePromotedPropertiesTable set ");
			strSql.Append("SurrogateInstanceId=@SurrogateInstanceId,");
			strSql.Append("PromotionName=@PromotionName,");
			strSql.Append("Value1=@Value1,");
			strSql.Append("Value2=@Value2,");
			strSql.Append("Value3=@Value3,");
			strSql.Append("Value4=@Value4,");
			strSql.Append("Value5=@Value5,");
			strSql.Append("Value6=@Value6,");
			strSql.Append("Value7=@Value7,");
			strSql.Append("Value8=@Value8,");
			strSql.Append("Value9=@Value9,");
			strSql.Append("Value10=@Value10,");
			strSql.Append("Value11=@Value11,");
			strSql.Append("Value12=@Value12,");
			strSql.Append("Value13=@Value13,");
			strSql.Append("Value14=@Value14,");
			strSql.Append("Value15=@Value15,");
			strSql.Append("Value16=@Value16,");
			strSql.Append("Value17=@Value17,");
			strSql.Append("Value18=@Value18,");
			strSql.Append("Value19=@Value19,");
			strSql.Append("Value20=@Value20,");
			strSql.Append("Value21=@Value21,");
			strSql.Append("Value22=@Value22,");
			strSql.Append("Value23=@Value23,");
			strSql.Append("Value24=@Value24,");
			strSql.Append("Value25=@Value25,");
			strSql.Append("Value26=@Value26,");
			strSql.Append("Value27=@Value27,");
			strSql.Append("Value28=@Value28,");
			strSql.Append("Value29=@Value29,");
			strSql.Append("Value30=@Value30,");
			strSql.Append("Value31=@Value31,");
			strSql.Append("Value32=@Value32,");
			strSql.Append("Value33=@Value33,");
			strSql.Append("Value34=@Value34,");
			strSql.Append("Value35=@Value35,");
			strSql.Append("Value36=@Value36,");
			strSql.Append("Value37=@Value37,");
			strSql.Append("Value38=@Value38,");
			strSql.Append("Value39=@Value39,");
			strSql.Append("Value40=@Value40,");
			strSql.Append("Value41=@Value41,");
			strSql.Append("Value42=@Value42,");
			strSql.Append("Value43=@Value43,");
			strSql.Append("Value44=@Value44,");
			strSql.Append("Value45=@Value45,");
			strSql.Append("Value46=@Value46,");
			strSql.Append("Value47=@Value47,");
			strSql.Append("Value48=@Value48,");
			strSql.Append("Value49=@Value49,");
			strSql.Append("Value50=@Value50,");
			strSql.Append("Value51=@Value51,");
			strSql.Append("Value52=@Value52,");
			strSql.Append("Value53=@Value53,");
			strSql.Append("Value54=@Value54,");
			strSql.Append("Value55=@Value55,");
			strSql.Append("Value56=@Value56,");
			strSql.Append("Value57=@Value57,");
			strSql.Append("Value58=@Value58,");
			strSql.Append("Value59=@Value59,");
			strSql.Append("Value60=@Value60,");
			strSql.Append("Value61=@Value61,");
			strSql.Append("Value62=@Value62,");
			strSql.Append("Value63=@Value63,");
			strSql.Append("Value64=@Value64");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@SurrogateInstanceId", SqlDbType.BigInt,8),
					new SqlParameter("@PromotionName", SqlDbType.NVarChar,400),
					new SqlParameter("@Value1", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value2", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value3", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value4", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value5", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value6", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value7", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value8", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value9", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value10", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value11", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value12", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value13", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value14", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value15", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value16", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value17", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value18", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value19", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value20", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value21", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value22", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value23", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value24", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value25", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value26", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value27", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value28", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value29", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value30", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value31", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value32", SqlDbType.sql_variant,8016),
					new SqlParameter("@Value33", SqlDbType.VarBinary),
					new SqlParameter("@Value34", SqlDbType.VarBinary),
					new SqlParameter("@Value35", SqlDbType.VarBinary),
					new SqlParameter("@Value36", SqlDbType.VarBinary),
					new SqlParameter("@Value37", SqlDbType.VarBinary),
					new SqlParameter("@Value38", SqlDbType.VarBinary),
					new SqlParameter("@Value39", SqlDbType.VarBinary),
					new SqlParameter("@Value40", SqlDbType.VarBinary),
					new SqlParameter("@Value41", SqlDbType.VarBinary),
					new SqlParameter("@Value42", SqlDbType.VarBinary),
					new SqlParameter("@Value43", SqlDbType.VarBinary),
					new SqlParameter("@Value44", SqlDbType.VarBinary),
					new SqlParameter("@Value45", SqlDbType.VarBinary),
					new SqlParameter("@Value46", SqlDbType.VarBinary),
					new SqlParameter("@Value47", SqlDbType.VarBinary),
					new SqlParameter("@Value48", SqlDbType.VarBinary),
					new SqlParameter("@Value49", SqlDbType.VarBinary),
					new SqlParameter("@Value50", SqlDbType.VarBinary),
					new SqlParameter("@Value51", SqlDbType.VarBinary),
					new SqlParameter("@Value52", SqlDbType.VarBinary),
					new SqlParameter("@Value53", SqlDbType.VarBinary),
					new SqlParameter("@Value54", SqlDbType.VarBinary),
					new SqlParameter("@Value55", SqlDbType.VarBinary),
					new SqlParameter("@Value56", SqlDbType.VarBinary),
					new SqlParameter("@Value57", SqlDbType.VarBinary),
					new SqlParameter("@Value58", SqlDbType.VarBinary),
					new SqlParameter("@Value59", SqlDbType.VarBinary),
					new SqlParameter("@Value60", SqlDbType.VarBinary),
					new SqlParameter("@Value61", SqlDbType.VarBinary),
					new SqlParameter("@Value62", SqlDbType.VarBinary),
					new SqlParameter("@Value63", SqlDbType.VarBinary),
					new SqlParameter("@Value64", SqlDbType.VarBinary)};
			parameters[0].Value = model.SurrogateInstanceId;
			parameters[1].Value = model.PromotionName;
			parameters[2].Value = model.Value1;
			parameters[3].Value = model.Value2;
			parameters[4].Value = model.Value3;
			parameters[5].Value = model.Value4;
			parameters[6].Value = model.Value5;
			parameters[7].Value = model.Value6;
			parameters[8].Value = model.Value7;
			parameters[9].Value = model.Value8;
			parameters[10].Value = model.Value9;
			parameters[11].Value = model.Value10;
			parameters[12].Value = model.Value11;
			parameters[13].Value = model.Value12;
			parameters[14].Value = model.Value13;
			parameters[15].Value = model.Value14;
			parameters[16].Value = model.Value15;
			parameters[17].Value = model.Value16;
			parameters[18].Value = model.Value17;
			parameters[19].Value = model.Value18;
			parameters[20].Value = model.Value19;
			parameters[21].Value = model.Value20;
			parameters[22].Value = model.Value21;
			parameters[23].Value = model.Value22;
			parameters[24].Value = model.Value23;
			parameters[25].Value = model.Value24;
			parameters[26].Value = model.Value25;
			parameters[27].Value = model.Value26;
			parameters[28].Value = model.Value27;
			parameters[29].Value = model.Value28;
			parameters[30].Value = model.Value29;
			parameters[31].Value = model.Value30;
			parameters[32].Value = model.Value31;
			parameters[33].Value = model.Value32;
			parameters[34].Value = model.Value33;
			parameters[35].Value = model.Value34;
			parameters[36].Value = model.Value35;
			parameters[37].Value = model.Value36;
			parameters[38].Value = model.Value37;
			parameters[39].Value = model.Value38;
			parameters[40].Value = model.Value39;
			parameters[41].Value = model.Value40;
			parameters[42].Value = model.Value41;
			parameters[43].Value = model.Value42;
			parameters[44].Value = model.Value43;
			parameters[45].Value = model.Value44;
			parameters[46].Value = model.Value45;
			parameters[47].Value = model.Value46;
			parameters[48].Value = model.Value47;
			parameters[49].Value = model.Value48;
			parameters[50].Value = model.Value49;
			parameters[51].Value = model.Value50;
			parameters[52].Value = model.Value51;
			parameters[53].Value = model.Value52;
			parameters[54].Value = model.Value53;
			parameters[55].Value = model.Value54;
			parameters[56].Value = model.Value55;
			parameters[57].Value = model.Value56;
			parameters[58].Value = model.Value57;
			parameters[59].Value = model.Value58;
			parameters[60].Value = model.Value59;
			parameters[61].Value = model.Value60;
			parameters[62].Value = model.Value61;
			parameters[63].Value = model.Value62;
			parameters[64].Value = model.Value63;
			parameters[65].Value = model.Value64;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from InstancePromotedPropertiesTable ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
};

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public BookShop.Model.InstancePromotedPropertiesTable GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 SurrogateInstanceId,PromotionName,Value1,Value2,Value3,Value4,Value5,Value6,Value7,Value8,Value9,Value10,Value11,Value12,Value13,Value14,Value15,Value16,Value17,Value18,Value19,Value20,Value21,Value22,Value23,Value24,Value25,Value26,Value27,Value28,Value29,Value30,Value31,Value32,Value33,Value34,Value35,Value36,Value37,Value38,Value39,Value40,Value41,Value42,Value43,Value44,Value45,Value46,Value47,Value48,Value49,Value50,Value51,Value52,Value53,Value54,Value55,Value56,Value57,Value58,Value59,Value60,Value61,Value62,Value63,Value64 from InstancePromotedPropertiesTable ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
};

			BookShop.Model.InstancePromotedPropertiesTable model=new BookShop.Model.InstancePromotedPropertiesTable();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["SurrogateInstanceId"].ToString()!="")
				{
					model.SurrogateInstanceId=long.Parse(ds.Tables[0].Rows[0]["SurrogateInstanceId"].ToString());
				}
				model.PromotionName=ds.Tables[0].Rows[0]["PromotionName"].ToString();
				//model.Value1=ds.Tables[0].Rows[0]["Value1"].ToString();
				//model.Value2=ds.Tables[0].Rows[0]["Value2"].ToString();
				//model.Value3=ds.Tables[0].Rows[0]["Value3"].ToString();
				//model.Value4=ds.Tables[0].Rows[0]["Value4"].ToString();
				//model.Value5=ds.Tables[0].Rows[0]["Value5"].ToString();
				//model.Value6=ds.Tables[0].Rows[0]["Value6"].ToString();
				//model.Value7=ds.Tables[0].Rows[0]["Value7"].ToString();
				//model.Value8=ds.Tables[0].Rows[0]["Value8"].ToString();
				//model.Value9=ds.Tables[0].Rows[0]["Value9"].ToString();
				//model.Value10=ds.Tables[0].Rows[0]["Value10"].ToString();
				//model.Value11=ds.Tables[0].Rows[0]["Value11"].ToString();
				//model.Value12=ds.Tables[0].Rows[0]["Value12"].ToString();
				//model.Value13=ds.Tables[0].Rows[0]["Value13"].ToString();
				//model.Value14=ds.Tables[0].Rows[0]["Value14"].ToString();
				//model.Value15=ds.Tables[0].Rows[0]["Value15"].ToString();
				//model.Value16=ds.Tables[0].Rows[0]["Value16"].ToString();
				//model.Value17=ds.Tables[0].Rows[0]["Value17"].ToString();
				//model.Value18=ds.Tables[0].Rows[0]["Value18"].ToString();
				//model.Value19=ds.Tables[0].Rows[0]["Value19"].ToString();
				//model.Value20=ds.Tables[0].Rows[0]["Value20"].ToString();
				//model.Value21=ds.Tables[0].Rows[0]["Value21"].ToString();
				//model.Value22=ds.Tables[0].Rows[0]["Value22"].ToString();
				//model.Value23=ds.Tables[0].Rows[0]["Value23"].ToString();
				//model.Value24=ds.Tables[0].Rows[0]["Value24"].ToString();
				//model.Value25=ds.Tables[0].Rows[0]["Value25"].ToString();
				//model.Value26=ds.Tables[0].Rows[0]["Value26"].ToString();
				//model.Value27=ds.Tables[0].Rows[0]["Value27"].ToString();
				//model.Value28=ds.Tables[0].Rows[0]["Value28"].ToString();
				//model.Value29=ds.Tables[0].Rows[0]["Value29"].ToString();
				//model.Value30=ds.Tables[0].Rows[0]["Value30"].ToString();
				//model.Value31=ds.Tables[0].Rows[0]["Value31"].ToString();
				//model.Value32=ds.Tables[0].Rows[0]["Value32"].ToString();
				if(ds.Tables[0].Rows[0]["Value33"].ToString()!="")
				{
					model.Value33=(byte[])ds.Tables[0].Rows[0]["Value33"];
				}
				if(ds.Tables[0].Rows[0]["Value34"].ToString()!="")
				{
					model.Value34=(byte[])ds.Tables[0].Rows[0]["Value34"];
				}
				if(ds.Tables[0].Rows[0]["Value35"].ToString()!="")
				{
					model.Value35=(byte[])ds.Tables[0].Rows[0]["Value35"];
				}
				if(ds.Tables[0].Rows[0]["Value36"].ToString()!="")
				{
					model.Value36=(byte[])ds.Tables[0].Rows[0]["Value36"];
				}
				if(ds.Tables[0].Rows[0]["Value37"].ToString()!="")
				{
					model.Value37=(byte[])ds.Tables[0].Rows[0]["Value37"];
				}
				if(ds.Tables[0].Rows[0]["Value38"].ToString()!="")
				{
					model.Value38=(byte[])ds.Tables[0].Rows[0]["Value38"];
				}
				if(ds.Tables[0].Rows[0]["Value39"].ToString()!="")
				{
					model.Value39=(byte[])ds.Tables[0].Rows[0]["Value39"];
				}
				if(ds.Tables[0].Rows[0]["Value40"].ToString()!="")
				{
					model.Value40=(byte[])ds.Tables[0].Rows[0]["Value40"];
				}
				if(ds.Tables[0].Rows[0]["Value41"].ToString()!="")
				{
					model.Value41=(byte[])ds.Tables[0].Rows[0]["Value41"];
				}
				if(ds.Tables[0].Rows[0]["Value42"].ToString()!="")
				{
					model.Value42=(byte[])ds.Tables[0].Rows[0]["Value42"];
				}
				if(ds.Tables[0].Rows[0]["Value43"].ToString()!="")
				{
					model.Value43=(byte[])ds.Tables[0].Rows[0]["Value43"];
				}
				if(ds.Tables[0].Rows[0]["Value44"].ToString()!="")
				{
					model.Value44=(byte[])ds.Tables[0].Rows[0]["Value44"];
				}
				if(ds.Tables[0].Rows[0]["Value45"].ToString()!="")
				{
					model.Value45=(byte[])ds.Tables[0].Rows[0]["Value45"];
				}
				if(ds.Tables[0].Rows[0]["Value46"].ToString()!="")
				{
					model.Value46=(byte[])ds.Tables[0].Rows[0]["Value46"];
				}
				if(ds.Tables[0].Rows[0]["Value47"].ToString()!="")
				{
					model.Value47=(byte[])ds.Tables[0].Rows[0]["Value47"];
				}
				if(ds.Tables[0].Rows[0]["Value48"].ToString()!="")
				{
					model.Value48=(byte[])ds.Tables[0].Rows[0]["Value48"];
				}
				if(ds.Tables[0].Rows[0]["Value49"].ToString()!="")
				{
					model.Value49=(byte[])ds.Tables[0].Rows[0]["Value49"];
				}
				if(ds.Tables[0].Rows[0]["Value50"].ToString()!="")
				{
					model.Value50=(byte[])ds.Tables[0].Rows[0]["Value50"];
				}
				if(ds.Tables[0].Rows[0]["Value51"].ToString()!="")
				{
					model.Value51=(byte[])ds.Tables[0].Rows[0]["Value51"];
				}
				if(ds.Tables[0].Rows[0]["Value52"].ToString()!="")
				{
					model.Value52=(byte[])ds.Tables[0].Rows[0]["Value52"];
				}
				if(ds.Tables[0].Rows[0]["Value53"].ToString()!="")
				{
					model.Value53=(byte[])ds.Tables[0].Rows[0]["Value53"];
				}
				if(ds.Tables[0].Rows[0]["Value54"].ToString()!="")
				{
					model.Value54=(byte[])ds.Tables[0].Rows[0]["Value54"];
				}
				if(ds.Tables[0].Rows[0]["Value55"].ToString()!="")
				{
					model.Value55=(byte[])ds.Tables[0].Rows[0]["Value55"];
				}
				if(ds.Tables[0].Rows[0]["Value56"].ToString()!="")
				{
					model.Value56=(byte[])ds.Tables[0].Rows[0]["Value56"];
				}
				if(ds.Tables[0].Rows[0]["Value57"].ToString()!="")
				{
					model.Value57=(byte[])ds.Tables[0].Rows[0]["Value57"];
				}
				if(ds.Tables[0].Rows[0]["Value58"].ToString()!="")
				{
					model.Value58=(byte[])ds.Tables[0].Rows[0]["Value58"];
				}
				if(ds.Tables[0].Rows[0]["Value59"].ToString()!="")
				{
					model.Value59=(byte[])ds.Tables[0].Rows[0]["Value59"];
				}
				if(ds.Tables[0].Rows[0]["Value60"].ToString()!="")
				{
					model.Value60=(byte[])ds.Tables[0].Rows[0]["Value60"];
				}
				if(ds.Tables[0].Rows[0]["Value61"].ToString()!="")
				{
					model.Value61=(byte[])ds.Tables[0].Rows[0]["Value61"];
				}
				if(ds.Tables[0].Rows[0]["Value62"].ToString()!="")
				{
					model.Value62=(byte[])ds.Tables[0].Rows[0]["Value62"];
				}
				if(ds.Tables[0].Rows[0]["Value63"].ToString()!="")
				{
					model.Value63=(byte[])ds.Tables[0].Rows[0]["Value63"];
				}
				if(ds.Tables[0].Rows[0]["Value64"].ToString()!="")
				{
					model.Value64=(byte[])ds.Tables[0].Rows[0]["Value64"];
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
			strSql.Append("select SurrogateInstanceId,PromotionName,Value1,Value2,Value3,Value4,Value5,Value6,Value7,Value8,Value9,Value10,Value11,Value12,Value13,Value14,Value15,Value16,Value17,Value18,Value19,Value20,Value21,Value22,Value23,Value24,Value25,Value26,Value27,Value28,Value29,Value30,Value31,Value32,Value33,Value34,Value35,Value36,Value37,Value38,Value39,Value40,Value41,Value42,Value43,Value44,Value45,Value46,Value47,Value48,Value49,Value50,Value51,Value52,Value53,Value54,Value55,Value56,Value57,Value58,Value59,Value60,Value61,Value62,Value63,Value64 ");
			strSql.Append(" FROM InstancePromotedPropertiesTable ");
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
			strSql.Append(" SurrogateInstanceId,PromotionName,Value1,Value2,Value3,Value4,Value5,Value6,Value7,Value8,Value9,Value10,Value11,Value12,Value13,Value14,Value15,Value16,Value17,Value18,Value19,Value20,Value21,Value22,Value23,Value24,Value25,Value26,Value27,Value28,Value29,Value30,Value31,Value32,Value33,Value34,Value35,Value36,Value37,Value38,Value39,Value40,Value41,Value42,Value43,Value44,Value45,Value46,Value47,Value48,Value49,Value50,Value51,Value52,Value53,Value54,Value55,Value56,Value57,Value58,Value59,Value60,Value61,Value62,Value63,Value64 ");
			strSql.Append(" FROM InstancePromotedPropertiesTable ");
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
			parameters[0].Value = "InstancePromotedPropertiesTable";
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

