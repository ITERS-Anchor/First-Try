<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="BookShop.Web.InstanceMetadataChangesTable.Show" Title="��ʾҳ" %>
<%@ MasterType VirtualPath="~/MasterPage.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		SurrogateInstanceId
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSurrogateInstanceId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ChangeTime
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblChangeTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EncodingOption
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblEncodingOption" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Change
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblChange" runat="server"></asp:Label>
	</td></tr>
</table>

</asp:Content>
