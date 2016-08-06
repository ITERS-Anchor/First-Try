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
namespace BookShop.Web.WF_Instance
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
					//ShowInfo(ID);
				}
			}
		}
			
	private void ShowInfo(int ID)
	{
		BookShop.BLL.WF_InstanceService bll=new BookShop.BLL.WF_InstanceService();
		BookShop.Model.WF_Instance model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtTitle.Text=model.Title;
		this.txtSubBy.Text=model.SubBy.ToString();
		this.txtSubTime.Text=model.SubTime.ToString();
		this.txtOutTime.Text=model.OutTime.ToString();
		this.txtstate.Text=model.state.ToString();
		this.txtResult.Text=model.Result.ToString();
		this.txtContent.Text=model.Content;
		this.txtLevel.Text=model.Level.ToString();
		this.txtWF_TempID.Text=model.WF_TempID.ToString();
		this.txtInstanceId.Text=model.InstanceId;

	}

		public void btnUpdate_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtTitle.Text =="")
			{
				strErr+="Title����Ϊ�գ�\\n";	
			}
			if(!PageValidate.IsNumber(txtSubBy.Text))
			{
				strErr+="SubBy�������֣�\\n";	
			}
			if(!PageValidate.IsDateTime(txtSubTime.Text))
			{
				strErr+="SubTime����ʱ���ʽ��\\n";	
			}
			if(!PageValidate.IsDateTime(txtOutTime.Text))
			{
				strErr+="OutTime����ʱ���ʽ��\\n";	
			}
			if(!PageValidate.IsNumber(txtstate.Text))
			{
				strErr+="state�������֣�\\n";	
			}
			if(!PageValidate.IsNumber(txtResult.Text))
			{
				strErr+="Result�������֣�\\n";	
			}
			if(this.txtContent.Text =="")
			{
				strErr+="Content����Ϊ�գ�\\n";	
			}
			if(!PageValidate.IsNumber(txtLevel.Text))
			{
				strErr+="Level�������֣�\\n";	
			}
			if(!PageValidate.IsNumber(txtWF_TempID.Text))
			{
				strErr+="WF_TempID�������֣�\\n";	
			}
			if(this.txtInstanceId.Text =="")
			{
				strErr+="InstanceId����Ϊ�գ�\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string Title=this.txtTitle.Text;
			int SubBy=int.Parse(this.txtSubBy.Text);
			DateTime SubTime=DateTime.Parse(this.txtSubTime.Text);
			DateTime OutTime=DateTime.Parse(this.txtOutTime.Text);
			int state=int.Parse(this.txtstate.Text);
			int Result=int.Parse(this.txtResult.Text);
			string Content=this.txtContent.Text;
			int Level=int.Parse(this.txtLevel.Text);
			int WF_TempID=int.Parse(this.txtWF_TempID.Text);
			string InstanceId=this.txtInstanceId.Text;


			BookShop.Model.WF_Instance model=new BookShop.Model.WF_Instance();
			model.Title=Title;
			model.SubBy=SubBy;
			model.SubTime=SubTime;
			model.OutTime=OutTime;
			model.state=state;
			model.Result=Result;
			model.Content=Content;
			model.Level=Level;
			model.WF_TempID=WF_TempID;
			model.InstanceId=InstanceId;

			BookShop.BLL.WF_InstanceService bll=new BookShop.BLL.WF_InstanceService();
			bll.Update(model);

		}

    }
}
