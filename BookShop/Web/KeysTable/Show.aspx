<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="BookShop.Web.KeysTable.Show" Title="ÏÔÊ¾Ò³" %>
<%@ MasterType VirtualPath="~/MasterPage.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		Id
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SurrogateKeyId
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSurrogateKeyId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SurrogateInstanceId
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSurrogateInstanceId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EncodingOption
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblEncodingOption" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Properties
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblProperties" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsAssociated
	£º</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsAssociated" Text="IsAssociated" runat="server" Checked="False" />
	</td></tr>
</table>

</asp:Content>
