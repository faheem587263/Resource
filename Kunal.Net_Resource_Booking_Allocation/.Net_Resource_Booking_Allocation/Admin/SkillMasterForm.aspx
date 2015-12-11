<%--<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminResourceAllocation.Master" AutoEventWireup="true" CodeBehind="SkillMasterForm.aspx.cs" Inherits="Net_Resource_Booking_Allocation.Admin.SkillMasterFrom" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<script src="../Scripts/Validation.js" type="text/javascript"></script> 

<div>
<table style="margin:12px,12px,12px,12px">
<tr>
<td>
<asp:Label ID="lblID" runat="server" Text="Skill ID"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtSkillId" runat="server" class="numValidator"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblName" runat="server" Text="Skill Name"></asp:Label></td>
<td>
<asp:TextBox ID="txtSkillName" runat="server" class="txtValidator"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="SkillActive" runat="server" Text="Skill Active"></asp:Label>
</td>
<td>
<asp:CheckBox ID="chkSkillActive" runat="server" class="chkValidator chkActive" />
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblSkillDel" runat="server" Text="Skill Delete"></asp:Label>
</td>
<td>
<asp:CheckBox ID="chkSkillDel" runat="server" class="chkValidator chkDelete"/>
</td>
</tr>

<tr>
<td>
<asp:Label ID="lblInsertUseID" runat="server" Text="Resource Insert User ID"></asp:Label>
</td>
<td>
<asp:DropDownList ID="drpInsertUserID" runat="server" ></asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblUpdateUseID" runat="server" Text="Resource Update User ID"></asp:Label>
</td>
<td>
<asp:DropDownList ID="drpUpdateuserId" runat="server"></asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblSkillYrId" runat="server" Text="Skill Yr ID"></asp:Label>
</td>
<td>
<asp:DropDownList ID="DrpSkillYrId" runat="server" class="drpValidation"></asp:DropDownList>
</td>
</tr>
<tr>
<td></td>
<td></td>
</tr>
<tr>
<td colspan="2" align="center">
<asp:Button ID="btnAdd" runat="server" class="btn btn-success" Text="Add" 
        onclick="btnAdd_Click"  OnClientClick="return callMethod();" />
<asp:Button ID="btnSubmit" runat="server" class="btn btn-success" Text="Submit" 
        onclick="btnSubmit_Click" OnClientClick="return callMethod();" />
<asp:Button ID="dtynEdit" runat="server" class="btn btn-default" Text="Edit" 
        onclick="dtynEdit_Click"/>
</td></tr>
</table>
</div>
    
</asp:Content>
--%>