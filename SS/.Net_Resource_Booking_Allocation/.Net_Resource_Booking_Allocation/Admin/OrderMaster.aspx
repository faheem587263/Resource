<%@ Page Language="C#" MasterPageFile="~/Admin/AdminResourceAllocation.Master" AutoEventWireup="true"
    CodeBehind="OrderMaster.aspx.cs" Inherits="Net_Resource_Booking_Allocation.OrderMaster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="/Scripts/Validation.js" type="text/javascript"></script>
    <div id="validate">
        <table style="margin: 12px,12px,12px,12px">
            <tr>
                <td>
                    <asp:Label ID="lblProjID" runat="server" Text="Project ID"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtProjID" class="numValidator" runat="server"></asp:TextBox>
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
                    <asp:TextBox ID="txtProjectName" class="txtValidator" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblProjectOverView" runat="server" Text="Project OverView"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtProjectOverView" class="txtValidator" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblOnShoreEMSDM" runat="server" Text="OnShore EM/SDM"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlOnShoreEMSDM" runat="server">
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
                    <asp:TextBox ID="txtRevenue" class="numValidator" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblContributionMargin" runat="server" Text="Contribution Margin(%)"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtContributionMargin" class="numValidator" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblpenetration" runat="server" Text="Expected Rightshore® penetration (%)"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtpenetration" class="numValidator" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblStartDate" runat="server" Text="Expected Start Date"></asp:Label>
                </td>
                <td>
                    <input type="text" name="date2" value="" id="IDdatepicker1" class="dateValidator"
                        runat="server" clientidmode="Static" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblEndDate" runat="server" Text="Expected End Date"></asp:Label>
                </td>
                <td>
                    <div id="date_picker2">
                    </div>
                    <input type="text" name="date2" value="" class="dateValidator" id="IDdatepicker2"
                        runat="server" clientidmode="Static" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblEfforts" runat="server" Text="Efforts (in Hrs)"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEfforts" class="numValidator" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblFTE" runat="server" Text="FTE's"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtFTE" class="numValidator" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblComment" runat="server" Text="Comment"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtComment" class="txtValidator" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="btnAdd" runat="server" class="btn btn-info" Text="Add" OnClick="dtynAdd_Click" />
                    <asp:Button ID="btnSubmit" runat="server" class="btn btn-success" Text="Submit" OnClick="dtynSubmit_Click"
                        OnClientClick="return callMethod();" />
                    <asp:Button ID="dtynEdit" runat="server" class="btn btn-default" Text="Edit" OnClick="dtynEdit_Click" />
                </td>
            </tr>
        </table>
    </div>
    <link href="/Styles/jquery.datetimepicker.css" rel="stylesheet" type="text/css" />
    <script src="/Scripts/jquery.js" type="text/javascript"></script>
    <script src="/Scripts/jquery.datetimepicker.full.js" type="text/javascript"></script>
    <script type="text/javascript">
        jQuery('#<%=IDdatepicker1.ClientID%>').datetimepicker({

            inline: false
        });

        jQuery('#<%=IDdatepicker2.ClientID%>').datetimepicker({

            inline: false
        });
       
    </script>
</asp:Content>
