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
namespace BookShop.Web.InstancePromotedPropertiesTable
{
    public partial class Show : System.Web.UI.Page
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
		this.lblSurrogateInstanceId.Text=model.SurrogateInstanceId;
		this.lblPromotionName.Text=model.PromotionName;
		this.lblValue1.Text=model.Value1;
		this.lblValue2.Text=model.Value2;
		this.lblValue3.Text=model.Value3;
		this.lblValue4.Text=model.Value4;
		this.lblValue5.Text=model.Value5;
		this.lblValue6.Text=model.Value6;
		this.lblValue7.Text=model.Value7;
		this.lblValue8.Text=model.Value8;
		this.lblValue9.Text=model.Value9;
		this.lblValue10.Text=model.Value10;
		this.lblValue11.Text=model.Value11;
		this.lblValue12.Text=model.Value12;
		this.lblValue13.Text=model.Value13;
		this.lblValue14.Text=model.Value14;
		this.lblValue15.Text=model.Value15;
		this.lblValue16.Text=model.Value16;
		this.lblValue17.Text=model.Value17;
		this.lblValue18.Text=model.Value18;
		this.lblValue19.Text=model.Value19;
		this.lblValue20.Text=model.Value20;
		this.lblValue21.Text=model.Value21;
		this.lblValue22.Text=model.Value22;
		this.lblValue23.Text=model.Value23;
		this.lblValue24.Text=model.Value24;
		this.lblValue25.Text=model.Value25;
		this.lblValue26.Text=model.Value26;
		this.lblValue27.Text=model.Value27;
		this.lblValue28.Text=model.Value28;
		this.lblValue29.Text=model.Value29;
		this.lblValue30.Text=model.Value30;
		this.lblValue31.Text=model.Value31;
		this.lblValue32.Text=model.Value32;
		this.lblValue33.Text=model.Value33.ToString();
		this.lblValue34.Text=model.Value34.ToString();
		this.lblValue35.Text=model.Value35.ToString();
		this.lblValue36.Text=model.Value36.ToString();
		this.lblValue37.Text=model.Value37.ToString();
		this.lblValue38.Text=model.Value38.ToString();
		this.lblValue39.Text=model.Value39.ToString();
		this.lblValue40.Text=model.Value40.ToString();
		this.lblValue41.Text=model.Value41.ToString();
		this.lblValue42.Text=model.Value42.ToString();
		this.lblValue43.Text=model.Value43.ToString();
		this.lblValue44.Text=model.Value44.ToString();
		this.lblValue45.Text=model.Value45.ToString();
		this.lblValue46.Text=model.Value46.ToString();
		this.lblValue47.Text=model.Value47.ToString();
		this.lblValue48.Text=model.Value48.ToString();
		this.lblValue49.Text=model.Value49.ToString();
		this.lblValue50.Text=model.Value50.ToString();
		this.lblValue51.Text=model.Value51.ToString();
		this.lblValue52.Text=model.Value52.ToString();
		this.lblValue53.Text=model.Value53.ToString();
		this.lblValue54.Text=model.Value54.ToString();
		this.lblValue55.Text=model.Value55.ToString();
		this.lblValue56.Text=model.Value56.ToString();
		this.lblValue57.Text=model.Value57.ToString();
		this.lblValue58.Text=model.Value58.ToString();
		this.lblValue59.Text=model.Value59.ToString();
		this.lblValue60.Text=model.Value60.ToString();
		this.lblValue61.Text=model.Value61.ToString();
		this.lblValue62.Text=model.Value62.ToString();
		this.lblValue63.Text=model.Value63.ToString();
		this.lblValue64.Text=model.Value64.ToString();

	}


    }
}
