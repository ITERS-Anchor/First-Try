<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="BookShop.Web.InstancesTable.Show" Title="ÏÔÊ¾Ò³" %>
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
		SurrogateInstanceId
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSurrogateInstanceId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SurrogateLockOwnerId
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSurrogateLockOwnerId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PrimitiveDataProperties
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPrimitiveDataProperties" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ComplexDataProperties
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblComplexDataProperties" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WriteOnlyPrimitiveDataProperties
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWriteOnlyPrimitiveDataProperties" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WriteOnlyComplexDataProperties
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWriteOnlyComplexDataProperties" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MetadataProperties
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMetadataProperties" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DataEncodingOption
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDataEncodingOption" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MetadataEncodingOption
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMetadataEncodingOption" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Version
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblVersion" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PendingTimer
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPendingTimer" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CreationTime
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCreationTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LastUpdated
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLastUpdated" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WorkflowHostType
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWorkflowHostType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ServiceDeploymentId
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblServiceDeploymentId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SuspensionExceptionName
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSuspensionExceptionName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SuspensionReason
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSuspensionReason" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BlockingBookmarks
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBlockingBookmarks" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LastMachineRunOn
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLastMachineRunOn" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ExecutionStatus
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblExecutionStatus" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsInitialized
	£º</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsInitialized" Text="IsInitialized" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsSuspended
	£º</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsSuspended" Text="IsSuspended" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsReadyToRun
	£º</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsReadyToRun" Text="IsReadyToRun" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsCompleted
	£º</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsCompleted" Text="IsCompleted" runat="server" Checked="False" />
	</td></tr>
</table>

</asp:Content>
