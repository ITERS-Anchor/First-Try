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
namespace BookShop.Web.KeysTable
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.TabTitle="��Ϣ��ӣ�����ϸ��д������Ϣ";            
        }

        		protected void btnAdd_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtId.Text =="")
			{
				strErr+="Id����Ϊ�գ�\\n";	
			}
			if(this.txtSurrogateInstanceId.Text =="")
			{
				strErr+="SurrogateInstanceId����Ϊ�գ�\\n";	
			}
			if(!PageValidate.IsNumber(txtEncodingOption.Text))
			{
				strErr+="EncodingOption�������֣�\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string Id=this.txtId.Text;
			string SurrogateInstanceId=this.txtSurrogateInstanceId.Text;
			int EncodingOption=int.Parse(this.txtEncodingOption.Text);
			byte[] Properties= new UnicodeEncoding().GetBytes(this.txtProperties.Text);
			bool IsAssociated=this.chkIsAssociated.Checked;

			BookShop.Model.KeysTable model=new BookShop.Model.KeysTable();
			model.Id=Id;
			model.SurrogateInstanceId=SurrogateInstanceId;
			model.EncodingOption=EncodingOption;
			model.Properties=Properties;
			model.IsAssociated=IsAssociated;

			BookShop.BLL.KeysTableService bll=new BookShop.BLL.KeysTableService();
			bll.Add(model);

		}

    }
}
