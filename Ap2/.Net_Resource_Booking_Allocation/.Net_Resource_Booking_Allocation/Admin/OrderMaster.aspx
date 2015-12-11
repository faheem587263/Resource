<%@ Page Language="C#" MasterPageFile="~/Admin/AdminResourceAllocation.Master" AutoEventWireup="true"
    CodeBehind="OrderMaster.aspx.cs" Inherits="Net_Resource_Booking_Allocation.OrderMaster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="validate">
        <table style="margin: 12px,12px,12px,12px">
            <tr>
                <td>
                    <asp:Label ID="lblProjID" runat="server" Text="Project ID"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtProjID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblClientDetails" runat="server" Text="Client Details"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtClientDetails" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblProjectName" runat="server" Text="Name of Project" class="abc"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtProjectName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblProjectOverView" runat="server" Text="Project OverView"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtProjectOverView" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblOnShoreEMSDM" runat="server" Text="OnShore EM/SDM"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlOnShoreEMSDM" runat="server" >
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblOffShoreEM" runat="server" Text="OffShore EM/SDM"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlOffShoreEM" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblRevenue" runat="server" Text="Revenue (SEK millions)"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtRevenue" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblContributionMargin" runat="server" Text="Contribution Margin(%)"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtContributionMargin" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblpenetration" runat="server" Text="Expected Rightshore® penetration (%)"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtpenetration" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblStartDate" runat="server" Text="Expected Start Date"></asp:Label>
                </td>
                <td>
                    <input type="text" name="date2" value="" id="IDdatepicker1" runat="server" clientidmode="Static" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblEndDate" runat="server" Text="Expected End Date"></asp:Label>
                </td>
                <td>
                    <div id="date_picker2">
                    </div>
                    <input type="text" name="date2" value="" id="IDdatepicker2" runat="server" clientidmode="Static" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblEfforts" runat="server" Text="Efforts (in Hrs)"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEfforts" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblFTE" runat="server" Text="FTE's"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtFTE" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblComment" runat="server" Text="Comment"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtComment" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="dtynAdd_Click" />
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="dtynSubmit_Click" />
                    <asp:Button ID="dtynEdit" runat="server" Text="Edit" OnClick="dtynEdit_Click" />
                </td>
            </tr>
        </table>
    </div>
    <link href="http://localhost:35344/Styles/jquery.datetimepicker.css" rel="stylesheet"
        type="text/css" />
    <script src="http://localhost:35344/Scripts/jquery.js" type="text/javascript"></script>
    <script src="http://localhost:35344/Scripts/jquery.datetimepicker.full.js" type="text/javascript"></script>
    
    <script type="text/javascript">
        jQuery('#<%=IDdatepicker1.ClientID%>').datetimepicker({

            inline: false
        });

        jQuery('#<%=IDdatepicker2.ClientID%>').datetimepicker({

            inline: false
        });
       
    </script>
</asp:Content>
