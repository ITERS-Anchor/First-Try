<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="BookShop.Web.UserInfo.Modify" Title="�޸�ҳ" %>
<%@ MasterType VirtualPath="~/MasterPage.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		ID
	��</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblID" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UserName
	��</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUserName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UserPass
	��</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUserPass" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RegTime
	��</td>
	<td height="25" width="*" align="left">
		<INPUT onselectstart="return false;" onkeypress="return false" id="txtRegTime" onfocus="setday(this)"
		 readOnly type="text" size="10" name="Text1" runat="server">
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Email
	��</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtEmail" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" colspan="2"><div align="center">
		<asp:Button ID="btnUpdate" runat="server" Text="�� �ύ ��" OnClick="btnUpdate_Click" ></asp:Button>
	</div></td></tr>
</table>

</asp:Content>