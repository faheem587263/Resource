<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminResourceAllocation.Master" AutoEventWireup="true" CodeBehind="GroupMasterForm.aspx.cs" Inherits="Net_Resource_Booking_Allocation.Admin.GroupMasterForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="/Scripts/Validation.js" type="text/javascript"></script>
<div>
<table style="margin:12px,12px,12px,12px">
<tr>
<td>
<asp:Label ID="lblGroupID" runat="server" Text="Group ID"></asp:Label></td>
<td>
<asp:TextBox ID="txtGroupID" runat="server" class="numValidator"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblGrpName" runat="server" Text="Group Name"></asp:Label></td>
<td>
<asp:TextBox ID="txtGrpName" runat="server" class="txtValidator"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblGrpDescription" runat="server" Text="Group Description"></asp:Label></td>
<td>
<asp:TextBox ID="txtGrpDescription" runat="server" class="txtValidator"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="GrpActive" runat="server" Text="Group Active"></asp:Label>
</td>
<td>
<asp:CheckBox ID="chkGrpActive" runat="server" class="chkValidator chkActive" />
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblGrpDel" runat="server" Text="Group Delete" ></asp:Label>
</td>
<td>
<asp:CheckBox ID="chkGrpDel" runat="server" class="chkValidator chkDelete"/>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblInsertUseID" runat="server" Text="Group Insert User ID"></asp:Label>
</td>
<td>
<asp:DropDownList ID="drpInsertUserID" runat="server" class="drpInsert"></asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblUpdateUseID" runat="server" Text="Group Update User ID"></asp:Label>
</td>
<td>
<asp:DropDownList ID="drpUpdateuserId" runat="server" class="drpUpdate"></asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblGrpYrId" runat="server" Text="Group Yr ID"></asp:Label>
</td>
<td>
<asp:DropDownList ID="DrpGrpYrId" runat="server" class="drpValidation"></asp:DropDownList>
</td>
</tr>

<tr>
<td></td>
<td></td>
</tr>
<tr>
<td colspan="2" align="center">
<asp:Button ID="btnAdd" runat="server" class="btn btn-info" Text="Add" 
        onclick="btnAdd_Click" OnClientClick="return onAdd();" />
<asp:Button ID="btnSubmit" runat="server" class="btn btn-success" Text="Submit" 
        onclick="btnSubmit_Click" OnClientClick="return onSubmit();"/>
<asp:Button ID="dtynEdit" runat="server" class="btn btn-default" Text="Edit" 
        onclick="dtynEdit_Click" />
</td></tr>
</table>


</div>
    

</asp:Content>
