<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="BookShop.Web.ActionInfo.Show" Title="��ʾҳ" %>
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
		ActionInfoName
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblActionInfoName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Url
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUrl" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HttpMethod
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHttpMethod" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Remark
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRemark" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DelFalg
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDelFalg" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SubTime
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSubTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsMenu
	��</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsMenu" Text="IsMenu" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		R_UserInfo_ActionInfoID
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblR_UserInfo_ActionInfoID" runat="server"></asp:Label>
	</td></tr>
</table>

</asp:Content>
