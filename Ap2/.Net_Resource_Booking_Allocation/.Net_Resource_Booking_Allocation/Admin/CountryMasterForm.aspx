<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminResourceAllocation.Master" AutoEventWireup="true" CodeBehind="CountryMasterForm.aspx.cs" Inherits="Net_Resource_Booking_Allocation.Admin.CountryMasterForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>
<table style="margin:12px,12px,12px,12px">

<tr>
<td>
<asp:Label ID="lblCountyName" runat="server" Text="County Name"></asp:Label></td>
<td>
<asp:TextBox ID="txtCountryName" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="CountryActive" runat="server" Text="Country Active"></asp:Label>
</td>
<td>
<asp:CheckBox ID="chkCountryActive" runat="server" />
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblCountryDel" runat="server" Text="Country Delete"></asp:Label>
</td>
<td>
<asp:CheckBox ID="chkCountryDel" runat="server" />
</td>
</tr>



<tr>
<td>
<asp:Label ID="lblInsertUseID" runat="server" Text="Country Insert User ID"></asp:Label>
</td>
<td>
<asp:DropDownList ID="drpInsertUserID" runat="server"></asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblUpdateUseID" runat="server" Text="Country Update User ID"></asp:Label>
</td>
<td>
<asp:DropDownList ID="drpUpdateuserId" runat="server"></asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblCountryYrId" runat="server" Text="Country Yr ID"></asp:Label>
</td>
<td>
<asp:DropDownList ID="drpCountryYrId" runat="server"></asp:DropDownList>
</td>
</tr>
<tr>
<td></td>
<td></td>
</tr>
<tr>
<td colspan="2" align="center">
<asp:Button ID="btnSubmit" runat="server" class="btn btn-success" Text="Submit" />

<asp:Button ID="dtynEdit" runat="server" class="btn btn-default" Text="Edit" />
</td></tr>
</table>


</div>
</asp:Content>
