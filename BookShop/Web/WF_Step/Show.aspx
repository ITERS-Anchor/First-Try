<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="BookShop.Web.WF_Step.Show" Title="��ʾҳ" %>
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
		subTime
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsubTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ProcessTime
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblProcessTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ProcessBy
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblProcessBy" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StepName
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStepName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Comment
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblComment" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FlowTo
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFlowTo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsStart
	��</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsStart" Text="IsStart" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsEnd
	��</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsEnd" Text="IsEnd" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		State
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblState" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ParentStepId
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblParentStepId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Sort
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSort" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WF_InstanceID
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWF_InstanceID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InstanceId
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInstanceId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsProcessed
	��</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsProcessed" Text="IsProcessed" runat="server" Checked="False" />
	</td></tr>
</table>

</asp:Content>
