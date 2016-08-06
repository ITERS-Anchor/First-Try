<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="BookShop.Web.InstancesTable.Show" Title="��ʾҳ" %>
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
		SurrogateInstanceId
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSurrogateInstanceId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SurrogateLockOwnerId
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSurrogateLockOwnerId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PrimitiveDataProperties
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPrimitiveDataProperties" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ComplexDataProperties
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblComplexDataProperties" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WriteOnlyPrimitiveDataProperties
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWriteOnlyPrimitiveDataProperties" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WriteOnlyComplexDataProperties
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWriteOnlyComplexDataProperties" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MetadataProperties
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMetadataProperties" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DataEncodingOption
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDataEncodingOption" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MetadataEncodingOption
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMetadataEncodingOption" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Version
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblVersion" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PendingTimer
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPendingTimer" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CreationTime
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCreationTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LastUpdated
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLastUpdated" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WorkflowHostType
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWorkflowHostType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ServiceDeploymentId
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblServiceDeploymentId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SuspensionExceptionName
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSuspensionExceptionName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SuspensionReason
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSuspensionReason" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BlockingBookmarks
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBlockingBookmarks" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LastMachineRunOn
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLastMachineRunOn" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ExecutionStatus
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblExecutionStatus" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsInitialized
	��</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsInitialized" Text="IsInitialized" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsSuspended
	��</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsSuspended" Text="IsSuspended" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsReadyToRun
	��</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsReadyToRun" Text="IsReadyToRun" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsCompleted
	��</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsCompleted" Text="IsCompleted" runat="server" Checked="False" />
	</td></tr>
</table>

</asp:Content>
