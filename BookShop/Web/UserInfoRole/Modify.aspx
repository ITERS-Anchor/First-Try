<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="BookShop.Web.UserInfoRole.Modify" Title="�޸�ҳ" %>
<%@ MasterType VirtualPath="~/MasterPage.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		UserInfo_ID
	��</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblUserInfo_ID" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Role_ID
	��</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblRole_ID" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" colspan="2"><div align="center">
		<asp:Button ID="btnUpdate" runat="server" Text="�� �ύ ��" OnClick="btnUpdate_Click" ></asp:Button>
	</div></td></tr>
</table>

</asp:Content>