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
namespace BookShop.Web.Order
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
			if(this.txtID.Text =="")
			{
				strErr+="ID����Ϊ�գ�\\n";	
			}
			if(this.txtOrderNum.Text =="")
			{
				strErr+="OrderNum����Ϊ�գ�\\n";	
			}
			if(!PageValidate.IsDateTime(txtSubDateTime.Text))
			{
				strErr+="SubDateTime����ʱ���ʽ��\\n";	
			}
			if(!PageValidate.IsNumber(txtCustomerID.Text))
			{
				strErr+="CustomerID�������֣�\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string ID=this.txtID.Text;
			string OrderNum=this.txtOrderNum.Text;
			DateTime SubDateTime=DateTime.Parse(this.txtSubDateTime.Text);
			int CustomerID=int.Parse(this.txtCustomerID.Text);

			BookShop.Model.Order model=new BookShop.Model.Order();
			model.ID=ID;
			model.OrderNum=OrderNum;
			model.SubDateTime=SubDateTime;
			model.CustomerID=CustomerID;

			BookShop.BLL.OrderService bll=new BookShop.BLL.OrderService();
			bll.Add(model);

		}

    }
}
