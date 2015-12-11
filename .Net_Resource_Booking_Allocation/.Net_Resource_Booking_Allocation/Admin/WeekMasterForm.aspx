<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminResourceAllocation.Master" AutoEventWireup="true" CodeBehind="WeekMasterForm.aspx.cs" Inherits="Net_Resource_Booking_Allocation.Admin.WeekMasterForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<script src="/Scripts/Validation.js" type="text/javascript"></script>
<div>
<table style="margin:12px,12px,12px,12px">

<tr>
<td>
<asp:Label ID="lblWeekName" runat="server" Text="Week Name"></asp:Label></td>
<td>
<asp:TextBox ID="txtWeekName" class="" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblWeekStartDate" runat="server" Text="Week Start Date"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtWeekStartDate"  runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblWeekEndDate" runat="server" Text="Week End Date"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtWeekEndDate" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblWeekYrId" runat="server" Text="Week Yr ID"></asp:Label>
</td>
<td>
<asp:DropDownList ID="drpWeekYrId" runat="server"></asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblWeekActive" runat="server" Text="Week Active"></asp:Label>
</td>
<td>
<asp:CheckBox ID="chkWeekActive" runat="server" />
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblWeekDelete" runat="server" Text="Week Delete"></asp:Label>
</td>
<td>
<asp:CheckBox ID="chkWeekDelete" runat="server" />
</td>
</tr>

<tr>
<td>
<asp:Label ID="lblInsertUseID" runat="server" Text="Resource Insert User ID"></asp:Label>
</td>
<td>
<asp:DropDownList ID="drpInsertUserID" runat="server"></asp:DropDownList>
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
<td></td>
<td></td>
</tr>
<tr>
<td colspan="2" align="center">
<asp:Button ID="btnAdd" runat="server" class="btn btn-info" Text="Add"/>
<asp:Button ID="btnSubmit" runat="server" class="btn btn-success" Text="Submit" />

<asp:Button ID="dtynEdit" runat="server" class="btn btn-default" Text="Edit" />
</td></tr>
</table>


</div>
<link href="/Styles/jquery.datetimepicker.css" rel="stylesheet"
        type="text/css" />
    <script src="/Scripts/jquery.js" type="text/javascript"></script>
    <script src="/Scripts/jquery.datetimepicker.full.js" type="text/javascript"></script>
    <script type="text/javascript">
      
    </script>
</asp:Content>
