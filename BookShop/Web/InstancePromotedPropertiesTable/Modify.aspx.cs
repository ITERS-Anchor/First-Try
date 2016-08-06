using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using LTP.Common;
namespace BookShop.Web.InstancePromotedPropertiesTable
{
    public partial class Modify : System.Web.UI.Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string id = Request.Params["id"];
					ShowInfo();
				}
			}
		}
			
	private void ShowInfo()
	{
		BookShop.BLL.InstancePromotedPropertiesTableService bll=new BookShop.BLL.InstancePromotedPropertiesTableService();
		BookShop.Model.InstancePromotedPropertiesTable model=bll.GetModel();
		this.txtSurrogateInstanceId.Text=model.SurrogateInstanceId;
		this.txtPromotionName.Text=model.PromotionName;
		this.txtValue1.Text=model.Value1;
		this.txtValue2.Text=model.Value2;
		this.txtValue3.Text=model.Value3;
		this.txtValue4.Text=model.Value4;
		this.txtValue5.Text=model.Value5;
		this.txtValue6.Text=model.Value6;
		this.txtValue7.Text=model.Value7;
		this.txtValue8.Text=model.Value8;
		this.txtValue9.Text=model.Value9;
		this.txtValue10.Text=model.Value10;
		this.txtValue11.Text=model.Value11;
		this.txtValue12.Text=model.Value12;
		this.txtValue13.Text=model.Value13;
		this.txtValue14.Text=model.Value14;
		this.txtValue15.Text=model.Value15;
		this.txtValue16.Text=model.Value16;
		this.txtValue17.Text=model.Value17;
		this.txtValue18.Text=model.Value18;
		this.txtValue19.Text=model.Value19;
		this.txtValue20.Text=model.Value20;
		this.txtValue21.Text=model.Value21;
		this.txtValue22.Text=model.Value22;
		this.txtValue23.Text=model.Value23;
		this.txtValue24.Text=model.Value24;
		this.txtValue25.Text=model.Value25;
		this.txtValue26.Text=model.Value26;
		this.txtValue27.Text=model.Value27;
		this.txtValue28.Text=model.Value28;
		this.txtValue29.Text=model.Value29;
		this.txtValue30.Text=model.Value30;
		this.txtValue31.Text=model.Value31;
		this.txtValue32.Text=model.Value32;
		this.txtValue33.Text=model.Value33.ToString();
		this.txtValue34.Text=model.Value34.ToString();
		this.txtValue35.Text=model.Value35.ToString();
		this.txtValue36.Text=model.Value36.ToString();
		this.txtValue37.Text=model.Value37.ToString();
		this.txtValue38.Text=model.Value38.ToString();
		this.txtValue39.Text=model.Value39.ToString();
		this.txtValue40.Text=model.Value40.ToString();
		this.txtValue41.Text=model.Value41.ToString();
		this.txtValue42.Text=model.Value42.ToString();
		this.txtValue43.Text=model.Value43.ToString();
		this.txtValue44.Text=model.Value44.ToString();
		this.txtValue45.Text=model.Value45.ToString();
		this.txtValue46.Text=model.Value46.ToString();
		this.txtValue47.Text=model.Value47.ToString();
		this.txtValue48.Text=model.Value48.ToString();
		this.txtValue49.Text=model.Value49.ToString();
		this.txtValue50.Text=model.Value50.ToString();
		this.txtValue51.Text=model.Value51.ToString();
		this.txtValue52.Text=model.Value52.ToString();
		this.txtValue53.Text=model.Value53.ToString();
		this.txtValue54.Text=model.Value54.ToString();
		this.txtValue55.Text=model.Value55.ToString();
		this.txtValue56.Text=model.Value56.ToString();
		this.txtValue57.Text=model.Value57.ToString();
		this.txtValue58.Text=model.Value58.ToString();
		this.txtValue59.Text=model.Value59.ToString();
		this.txtValue60.Text=model.Value60.ToString();
		this.txtValue61.Text=model.Value61.ToString();
		this.txtValue62.Text=model.Value62.ToString();
		this.txtValue63.Text=model.Value63.ToString();
		this.txtValue64.Text=model.Value64.ToString();

	}

		public void btnUpdate_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtSurrogateInstanceId.Text =="")
			{
				strErr+="SurrogateInstanceId不能为空！\\n";	
			}
			if(this.txtPromotionName.Text =="")
			{
				strErr+="PromotionName不能为空！\\n";	
			}
			if(this.txtValue1.Text =="")
			{
				strErr+="Value1不能为空！\\n";	
			}
			if(this.txtValue2.Text =="")
			{
				strErr+="Value2不能为空！\\n";	
			}
			if(this.txtValue3.Text =="")
			{
				strErr+="Value3不能为空！\\n";	
			}
			if(this.txtValue4.Text =="")
			{
				strErr+="Value4不能为空！\\n";	
			}
			if(this.txtValue5.Text =="")
			{
				strErr+="Value5不能为空！\\n";	
			}
			if(this.txtValue6.Text =="")
			{
				strErr+="Value6不能为空！\\n";	
			}
			if(this.txtValue7.Text =="")
			{
				strErr+="Value7不能为空！\\n";	
			}
			if(this.txtValue8.Text =="")
			{
				strErr+="Value8不能为空！\\n";	
			}
			if(this.txtValue9.Text =="")
			{
				strErr+="Value9不能为空！\\n";	
			}
			if(this.txtValue10.Text =="")
			{
				strErr+="Value10不能为空！\\n";	
			}
			if(this.txtValue11.Text =="")
			{
				strErr+="Value11不能为空！\\n";	
			}
			if(this.txtValue12.Text =="")
			{
				strErr+="Value12不能为空！\\n";	
			}
			if(this.txtValue13.Text =="")
			{
				strErr+="Value13不能为空！\\n";	
			}
			if(this.txtValue14.Text =="")
			{
				strErr+="Value14不能为空！\\n";	
			}
			if(this.txtValue15.Text =="")
			{
				strErr+="Value15不能为空！\\n";	
			}
			if(this.txtValue16.Text =="")
			{
				strErr+="Value16不能为空！\\n";	
			}
			if(this.txtValue17.Text =="")
			{
				strErr+="Value17不能为空！\\n";	
			}
			if(this.txtValue18.Text =="")
			{
				strErr+="Value18不能为空！\\n";	
			}
			if(this.txtValue19.Text =="")
			{
				strErr+="Value19不能为空！\\n";	
			}
			if(this.txtValue20.Text =="")
			{
				strErr+="Value20不能为空！\\n";	
			}
			if(this.txtValue21.Text =="")
			{
				strErr+="Value21不能为空！\\n";	
			}
			if(this.txtValue22.Text =="")
			{
				strErr+="Value22不能为空！\\n";	
			}
			if(this.txtValue23.Text =="")
			{
				strErr+="Value23不能为空！\\n";	
			}
			if(this.txtValue24.Text =="")
			{
				strErr+="Value24不能为空！\\n";	
			}
			if(this.txtValue25.Text =="")
			{
				strErr+="Value25不能为空！\\n";	
			}
			if(this.txtValue26.Text =="")
			{
				strErr+="Value26不能为空！\\n";	
			}
			if(this.txtValue27.Text =="")
			{
				strErr+="Value27不能为空！\\n";	
			}
			if(this.txtValue28.Text =="")
			{
				strErr+="Value28不能为空！\\n";	
			}
			if(this.txtValue29.Text =="")
			{
				strErr+="Value29不能为空！\\n";	
			}
			if(this.txtValue30.Text =="")
			{
				strErr+="Value30不能为空！\\n";	
			}
			if(this.txtValue31.Text =="")
			{
				strErr+="Value31不能为空！\\n";	
			}
			if(this.txtValue32.Text =="")
			{
				strErr+="Value32不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string SurrogateInstanceId=this.txtSurrogateInstanceId.Text;
			string PromotionName=this.txtPromotionName.Text;
			string Value1=this.txtValue1.Text;
			string Value2=this.txtValue2.Text;
			string Value3=this.txtValue3.Text;
			string Value4=this.txtValue4.Text;
			string Value5=this.txtValue5.Text;
			string Value6=this.txtValue6.Text;
			string Value7=this.txtValue7.Text;
			string Value8=this.txtValue8.Text;
			string Value9=this.txtValue9.Text;
			string Value10=this.txtValue10.Text;
			string Value11=this.txtValue11.Text;
			string Value12=this.txtValue12.Text;
			string Value13=this.txtValue13.Text;
			string Value14=this.txtValue14.Text;
			string Value15=this.txtValue15.Text;
			string Value16=this.txtValue16.Text;
			string Value17=this.txtValue17.Text;
			string Value18=this.txtValue18.Text;
			string Value19=this.txtValue19.Text;
			string Value20=this.txtValue20.Text;
			string Value21=this.txtValue21.Text;
			string Value22=this.txtValue22.Text;
			string Value23=this.txtValue23.Text;
			string Value24=this.txtValue24.Text;
			string Value25=this.txtValue25.Text;
			string Value26=this.txtValue26.Text;
			string Value27=this.txtValue27.Text;
			string Value28=this.txtValue28.Text;
			string Value29=this.txtValue29.Text;
			string Value30=this.txtValue30.Text;
			string Value31=this.txtValue31.Text;
			string Value32=this.txtValue32.Text;
			byte[] Value33= new UnicodeEncoding().GetBytes(this.txtValue33.Text);
			byte[] Value34= new UnicodeEncoding().GetBytes(this.txtValue34.Text);
			byte[] Value35= new UnicodeEncoding().GetBytes(this.txtValue35.Text);
			byte[] Value36= new UnicodeEncoding().GetBytes(this.txtValue36.Text);
			byte[] Value37= new UnicodeEncoding().GetBytes(this.txtValue37.Text);
			byte[] Value38= new UnicodeEncoding().GetBytes(this.txtValue38.Text);
			byte[] Value39= new UnicodeEncoding().GetBytes(this.txtValue39.Text);
			byte[] Value40= new UnicodeEncoding().GetBytes(this.txtValue40.Text);
			byte[] Value41= new UnicodeEncoding().GetBytes(this.txtValue41.Text);
			byte[] Value42= new UnicodeEncoding().GetBytes(this.txtValue42.Text);
			byte[] Value43= new UnicodeEncoding().GetBytes(this.txtValue43.Text);
			byte[] Value44= new UnicodeEncoding().GetBytes(this.txtValue44.Text);
			byte[] Value45= new UnicodeEncoding().GetBytes(this.txtValue45.Text);
			byte[] Value46= new UnicodeEncoding().GetBytes(this.txtValue46.Text);
			byte[] Value47= new UnicodeEncoding().GetBytes(this.txtValue47.Text);
			byte[] Value48= new UnicodeEncoding().GetBytes(this.txtValue48.Text);
			byte[] Value49= new UnicodeEncoding().GetBytes(this.txtValue49.Text);
			byte[] Value50= new UnicodeEncoding().GetBytes(this.txtValue50.Text);
			byte[] Value51= new UnicodeEncoding().GetBytes(this.txtValue51.Text);
			byte[] Value52= new UnicodeEncoding().GetBytes(this.txtValue52.Text);
			byte[] Value53= new UnicodeEncoding().GetBytes(this.txtValue53.Text);
			byte[] Value54= new UnicodeEncoding().GetBytes(this.txtValue54.Text);
			byte[] Value55= new UnicodeEncoding().GetBytes(this.txtValue55.Text);
			byte[] Value56= new UnicodeEncoding().GetBytes(this.txtValue56.Text);
			byte[] Value57= new UnicodeEncoding().GetBytes(this.txtValue57.Text);
			byte[] Value58= new UnicodeEncoding().GetBytes(this.txtValue58.Text);
			byte[] Value59= new UnicodeEncoding().GetBytes(this.txtValue59.Text);
			byte[] Value60= new UnicodeEncoding().GetBytes(this.txtValue60.Text);
			byte[] Value61= new UnicodeEncoding().GetBytes(this.txtValue61.Text);
			byte[] Value62= new UnicodeEncoding().GetBytes(this.txtValue62.Text);
			byte[] Value63= new UnicodeEncoding().GetBytes(this.txtValue63.Text);
			byte[] Value64= new UnicodeEncoding().GetBytes(this.txtValue64.Text);


			BookShop.Model.InstancePromotedPropertiesTable model=new BookShop.Model.InstancePromotedPropertiesTable();
			model.SurrogateInstanceId=SurrogateInstanceId;
			model.PromotionName=PromotionName;
			model.Value1=Value1;
			model.Value2=Value2;
			model.Value3=Value3;
			model.Value4=Value4;
			model.Value5=Value5;
			model.Value6=Value6;
			model.Value7=Value7;
			model.Value8=Value8;
			model.Value9=Value9;
			model.Value10=Value10;
			model.Value11=Value11;
			model.Value12=Value12;
			model.Value13=Value13;
			model.Value14=Value14;
			model.Value15=Value15;
			model.Value16=Value16;
			model.Value17=Value17;
			model.Value18=Value18;
			model.Value19=Value19;
			model.Value20=Value20;
			model.Value21=Value21;
			model.Value22=Value22;
			model.Value23=Value23;
			model.Value24=Value24;
			model.Value25=Value25;
			model.Value26=Value26;
			model.Value27=Value27;
			model.Value28=Value28;
			model.Value29=Value29;
			model.Value30=Value30;
			model.Value31=Value31;
			model.Value32=Value32;
			model.Value33=Value33;
			model.Value34=Value34;
			model.Value35=Value35;
			model.Value36=Value36;
			model.Value37=Value37;
			model.Value38=Value38;
			model.Value39=Value39;
			model.Value40=Value40;
			model.Value41=Value41;
			model.Value42=Value42;
			model.Value43=Value43;
			model.Value44=Value44;
			model.Value45=Value45;
			model.Value46=Value46;
			model.Value47=Value47;
			model.Value48=Value48;
			model.Value49=Value49;
			model.Value50=Value50;
			model.Value51=Value51;
			model.Value52=Value52;
			model.Value53=Value53;
			model.Value54=Value54;
			model.Value55=Value55;
			model.Value56=Value56;
			model.Value57=Value57;
			model.Value58=Value58;
			model.Value59=Value59;
			model.Value60=Value60;
			model.Value61=Value61;
			model.Value62=Value62;
			model.Value63=Value63;
			model.Value64=Value64;

			BookShop.BLL.InstancePromotedPropertiesTableService bll=new BookShop.BLL.InstancePromotedPropertiesTableService();
			bll.Update(model);

		}

    }
}
