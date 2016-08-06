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
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.TabTitle="信息添加，请详细填写下列信息";            
        }

        		protected void btnAdd_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtTitle.Text =="")
			{
				strErr+="Title不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtSubBy.Text))
			{
				strErr+="SubBy不是数字！\\n";	
			}
			if(!PageValidate.IsDateTime(txtSubTime.Text))
			{
				strErr+="SubTime不是时间格式！\\n";	
			}
			if(!PageValidate.IsDateTime(txtOutTime.Text))
			{
				strErr+="OutTime不是时间格式！\\n";	
			}
			if(!PageValidate.IsNumber(txtstate.Text))
			{
				strErr+="state不是数字！\\n";	
			}
			if(!PageValidate.IsNumber(txtResult.Text))
			{
				strErr+="Result不是数字！\\n";	
			}
			if(this.txtContent.Text =="")
			{
				strErr+="Content不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtLevel.Text))
			{
				strErr+="Level不是数字！\\n";	
			}
			if(!PageValidate.IsNumber(txtWF_TempID.Text))
			{
				strErr+="WF_TempID不是数字！\\n";	
			}
			if(this.txtInstanceId.Text =="")
			{
				strErr+="InstanceId不能为空！\\n";	
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
			bll.Add(model);

		}

    }
}
