<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="BookShop.Web.R_UserInfo_ActionInfo.Show" Title="��ʾҳ" %>
<%@ MasterType VirtualPath="~/MasterPage.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		ID
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsPass
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsPass" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ActionInfoID
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblActionInfoID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UserInfoID
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUserInfoID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ActionInfo_ID
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblActionInfo_ID" runat="server"></asp:Label>
	</td></tr>
</table>

</asp:Content>
