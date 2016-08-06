<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    Codebehind="Add.aspx.cs" Inherits="BookShop.Web.InstancesTable.Add" Title="增加页" %>
<%@ MasterType VirtualPath="~/MasterPage.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		Id
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtId" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SurrogateLockOwnerId
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSurrogateLockOwnerId" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PrimitiveDataProperties
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPrimitiveDataProperties" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ComplexDataProperties
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtComplexDataProperties" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WriteOnlyPrimitiveDataProperties
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWriteOnlyPrimitiveDataProperties" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WriteOnlyComplexDataProperties
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWriteOnlyComplexDataProperties" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MetadataProperties
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMetadataProperties" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DataEncodingOption
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDataEncodingOption" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MetadataEncodingOption
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMetadataEncodingOption" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Version
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtVersion" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PendingTimer
	：</td>
	<td height="25" width="*" align="left">
		<INPUT onselectstart="return false;" onkeypress="return false" id="txtPendingTimer" onfocus="setday(this)"
		 readOnly type="text" size="10" name="Text1" runat="server">
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CreationTime
	：</td>
	<td height="25" width="*" align="left">
		<INPUT onselectstart="return false;" onkeypress="return false" id="txtCreationTime" onfocus="setday(this)"
		 readOnly type="text" size="10" name="Text1" runat="server">
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LastUpdated
	：</td>
	<td height="25" width="*" align="left">
		<INPUT onselectstart="return false;" onkeypress="return false" id="txtLastUpdated" onfocus="setday(this)"
		 readOnly type="text" size="10" name="Text1" runat="server">
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WorkflowHostType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWorkflowHostType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ServiceDeploymentId
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtServiceDeploymentId" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SuspensionExceptionName
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSuspensionExceptionName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SuspensionReason
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSuspensionReason" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BlockingBookmarks
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBlockingBookmarks" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LastMachineRunOn
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtLastMachineRunOn" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ExecutionStatus
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtExecutionStatus" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsInitialized
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsInitialized" Text="IsInitialized" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsSuspended
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsSuspended" Text="IsSuspended" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsReadyToRun
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsReadyToRun" Text="IsReadyToRun" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsCompleted
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsCompleted" Text="IsCompleted" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" colspan="2"><div align="center">
		<asp:Button ID="btnAdd" runat="server" Text="· 提交 ·" OnClick="btnAdd_Click" ></asp:Button>
	</div></td></tr>
</table>

</asp:Content>
