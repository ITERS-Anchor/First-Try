<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="BookShop.Web.ServiceDeploymentsTable.Show" Title="��ʾҳ" %>
<%@ MasterType VirtualPath="~/MasterPage.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		Id
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ServiceDeploymentHash
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblServiceDeploymentHash" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SiteName
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSiteName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RelativeServicePath
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRelativeServicePath" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RelativeApplicationPath
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRelativeApplicationPath" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ServiceName
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblServiceName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ServiceNamespace
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblServiceNamespace" runat="server"></asp:Label>
	</td></tr>
</table>

</asp:Content>
