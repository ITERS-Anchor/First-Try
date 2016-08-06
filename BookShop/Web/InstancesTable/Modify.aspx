<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="BookShop.Web.InstancesTable.Modify" Title="ÐÞ¸ÄÒ³" %>
<%@ MasterType VirtualPath="~/MasterPage.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		Id
	£º</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtId" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SurrogateInstanceId
	£º</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblSurrogateInstanceId" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SurrogateLockOwnerId
	£º</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSurrogateLockOwnerId" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PrimitiveDataProperties
	£º</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPrimitiveDataProperties" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ComplexDataProperties
	£º</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtComplexDataProperties" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WriteOnlyPrimitiveDataProperties
	£º</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWriteOnlyPrimitiveDataProperties" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WriteOnlyComplexDataProperties
	£º</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWriteOnlyComplexDataProperties" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MetadataProperties
	£º</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMetadataProperties" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DataEncodingOption
	£º</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDataEncodingOption" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MetadataEncodingOption
	£º</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMetadataEncodingOption" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Version
	£º</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtVersion" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PendingTimer
	£º</td>
	<td height="25" width="*" align="left">
		<INPUT onselectstart="return false;" onkeypress="return false" id="txtPendingTimer" onfocus="setday(this)"
		 readOnly type="text" size="10" name="Text1" runat="server">
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CreationTime
	£º</td>
	<td height="25" width="*" align="left">
		<INPUT onselectstart="return false;" onkeypress="return false" id="txtCreationTime" onfocus="setday(this)"
		 readOnly type="text" size="10" name="Text1" runat="server">
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LastUpdated
	£º</td>
	<td height="25" width="*" align="left">
		<INPUT onselectstart="return false;" onkeypress="return false" id="txtLastUpdated" onfocus="setday(this)"
		 readOnly type="text" size="10" name="Text1" runat="server">
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WorkflowHostType
	£º</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWorkflowHostType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ServiceDeploymentId
	£º</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtServiceDeploymentId" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SuspensionExceptionName
	£º</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSuspensionExceptionName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SuspensionReason
	£º</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSuspensionReason" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BlockingBookmarks
	£º</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBlockingBookmarks" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LastMachineRunOn
	£º</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtLastMachineRunOn" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ExecutionStatus
	£º</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtExecutionStatus" runat="server" Width="200px"></asp:TextBox>
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
	<tr>
	<td height="25" colspan="2"><div align="center">
		<asp:Button ID="btnUpdate" runat="server" Text="¡¤ Ìá½» ¡¤" OnClick="btnUpdate_Click" ></asp:Button>
	</div></td></tr>
</table>

</asp:Content>
