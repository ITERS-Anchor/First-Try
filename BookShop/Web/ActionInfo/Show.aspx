<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="BookShop.Web.ActionInfo.Show" Title="ÏÔÊ¾Ò³" %>
<%@ MasterType VirtualPath="~/MasterPage.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		ID
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ActionInfoName
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblActionInfoName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Url
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUrl" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HttpMethod
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHttpMethod" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Remark
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRemark" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DelFalg
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDelFalg" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SubTime
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSubTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsMenu
	£º</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsMenu" Text="IsMenu" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		R_UserInfo_ActionInfoID
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblR_UserInfo_ActionInfoID" runat="server"></asp:Label>
	</td></tr>
</table>

</asp:Content>
