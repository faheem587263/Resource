<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminResourceAllocation.Master" AutoEventWireup="true" CodeBehind="ProjectMasterForm.aspx.cs" Inherits="Net_Resource_Booking_Allocation.Admin.ProjectMasterForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>
<table style="margin:12px,12px,12px,12px">

<tr>
<td>
<asp:Label ID="lblPrjName" runat="server" Text="Project Name"></asp:Label></td>
<td>
<asp:TextBox ID="txtPrjName" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblPrjClientName" runat="server" Text="Project Client Name"></asp:Label></td>
<td>
<asp:TextBox ID="txtPrjClientName" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblPrjDetails" runat="server" Text="Project Details"></asp:Label></td>
<td>
<asp:TextBox ID="txtPrjDetails" runat="server" TextMode="MultiLine"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblPrjOnShoreEMSDM" runat="server" Text="Project OnShore EM SDM"></asp:Label></td>
<td>
<asp:TextBox ID="txtPrjOnShoreENSDM" runat="server" ></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblPrjOffShoreEMSDM" runat="server" Text="Project OffShore EM SDM"></asp:Label></td>
<td>
<asp:TextBox ID="txtPrjOffShoreENSDM" runat="server" ></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblPrjExpStartDate" runat="server" Text="Project Expected Start Date"></asp:Label></td>
<td>
<asp:TextBox ID="txtPrjExpStartDate" runat="server" ></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblPrjExpEndDate" runat="server" Text="Project Expected End Date"></asp:Label></td>
<td>
<asp:TextBox ID="txtPrjExpEndDate" runat="server" ></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblPrjEffort" runat="server" Text="Project Effort"></asp:Label></td>
<td>
<asp:TextBox ID="txtPrjEffort" runat="server" ></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblPrjFTE" runat="server" Text="Project FTE"></asp:Label></td>
<td>
<asp:TextBox ID="txtPrjFTE" runat="server" ></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="PrjActive" runat="server" Text="Project Active"></asp:Label>
</td>
<td>
<asp:CheckBox ID="chkPrjActive" runat="server" />
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblPrjDel" runat="server" Text="Project Delete"></asp:Label>
</td>
<td>
<asp:CheckBox ID="chkPrjDel" runat="server" />
</td>
</tr>





<tr>
<td>
<asp:Label ID="lblInsertUseID" runat="server" Text="Project Insert User ID"></asp:Label>
</td>
<td>
<asp:DropDownList ID="drpInsertUserID" runat="server"></asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblUpdateUseID" runat="server" Text="Project Update User ID"></asp:Label>
</td>
<td>
<asp:DropDownList ID="drpUpdateuserId" runat="server"></asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblPrjYrId" runat="server" Text="Project Yr ID"></asp:Label>
</td>
<td>
<asp:DropDownList ID="drpPrjYrId" runat="server"></asp:DropDownList>
</td>
</tr>
<tr>
<td></td>
<td></td>
</tr>
<tr>
<td colspan="2" align="center">
<asp:Button ID="btnAdd" runat="server" class="btn btn-info" Text="Add"/>
<asp:Button ID="btnSubmit" runat="server" Text="Submit" class="btn btn-success"  OnClick="projectMFSubmit" />

<asp:Button ID="dtynEdit" runat="server" Text="Edit" class="btn btn-default" OnClick="projectMFEdit" />
</td></tr>
</table>


</div>
</asp:Content>
