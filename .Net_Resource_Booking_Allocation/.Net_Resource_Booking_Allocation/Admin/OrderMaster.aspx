<%@ Page Language="C#" MasterPageFile="~/Admin/AdminResourceAllocation.Master" AutoEventWireup="true"
    CodeBehind="OrderMaster.aspx.cs" Inherits="Net_Resource_Booking_Allocation.OrderMaster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div id="validate" class="orderForm">
        <table style="margin: 12px,12px,12px,12px">
            <tr>
                <td>
                    <asp:Label ID="lblProjID" runat="server" Text="Project ID"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtProjID" class="txtProjID" runat="server"></asp:TextBox>
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
                    <asp:DropDownList ID="ddlOnShoreEMSDM" class="drpValidation" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblOffShoreEM" runat="server" Text="OffShore EM/SDM"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlOffShoreEM" class="drpValidation" runat="server">
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
                    <input type="text" name="date2" value=""  id="IDdatepicker2"
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
                    <asp:Label ID="OrdActive" runat="server" Text="Order Active"></asp:Label>
                </td>
                <td>
                    <asp:CheckBox ID="chkOrdActive" class="chkValidator chkActive" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblOrdDel" runat="server" Text="Order Delete"></asp:Label>
                </td>
                <td>
                    <asp:CheckBox ID="chkOrdDel"  class="chkValidator chkDelete" runat="server" />
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
                <td>
                    <asp:Label ID="lblStatus" runat="server" Text="Status"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlStatus" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="btnAdd" runat="server" class="btn btn-info" Text="New" OnClick="dtynAdd_Click" 
                    OnClientClick="return onAdd();"/>
                    <asp:Button ID="btnSubmit" runat="server" class="btn btn-success" Text="Update" OnClick="dtynSubmit_Click" 
                    OnClientClick="return onSubmit();"/>
                   <!-- <asp:Button ID="dtynEdit" runat="server"  Text="Search" OnClick="dtynEdit_Click" />-->
                    <button class="btn btn-default" type="button">Search</button>
                    <asp:Button ID="btngto" runat="server" class="btn btn-success" 
                        Text="Go to Resource Form" onclick="btngto_Click"  />
                </td>
            </tr>
        </table>
    </div>
    <div class="orderList hide">
    

<asp:Repeater ID="rptrDetails" runat="server" onitemcommand="rptrDetails_ItemCommand">
<HeaderTemplate>
<table>
<tr style="background-color:Aqua;">
<td >
 <asp:Label ID="Label11" runat="server" Text="Project ID"></asp:Label>
</td>
<td>
 <asp:Label ID="Label2" runat="server" Text="Client Details"></asp:Label>
</td>
<td>
 <asp:Label ID="Label3" runat="server" Text="Name of Project"></asp:Label>
</td>
</tr>
</HeaderTemplate>
<ItemTemplate>
<tr>
<td>


<asp:LinkButton ID="lnkbtn" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Project ID") %>'></asp:LinkButton>
</td>
<td>
<asp:Label ID="Label6" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Client Details") %>'></asp:Label>
</td>
<td>
<asp:Label ID="Label4" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Name Of Project") %>'></asp:Label>
</td>
</tr> 
</ItemTemplate>
<FooterTemplate>
</table>
</FooterTemplate>
</asp:Repeater>
 </div>

   <%--  <table>
        <tr>
        <td>
            <asp:Label ID="Label11" runat="server" Text="Project ID"></asp:Label>
        </td>
        <td>
           <asp:Label ID="Label12" runat="server" Text="Client Details"></asp:Label>
        </td>
        <td>
           <asp:Label ID="Label13" runat="server" Text="Name of Project"></asp:Label>
        </td>
        </tr>
        <tr>
        <td>
         
       <asp:LinkButton ID="LinkButton1" class="hyperLink" runat="server" Text="1" OnClick="dtynEdit_Click" OnClientClick="return orderForm();"/>
        
        </td>
        <td>
          <asp:Label ID="Label22" runat="server" Text="Sweden"></asp:Label>
        </td>
        <td>
          <asp:Label ID="Label23" runat="server" Text="Telia Sonera"></asp:Label>
        </td>
        </tr>
        <tr>
        <td>
       
            <asp:LinkButton ID="LinkButton2" class="hyperLink" runat="server" Text="2" OnClick="dtynEdit_Click" OnClientClick="return orderForm();"/>
            
        
        </td>
        <td>
          <asp:Label ID="Label32" runat="server" Text="Sweden"></asp:Label>
        </td>
        <td>
         <asp:Label ID="Label1" runat="server" Text="MHC"></asp:Label>
        </td>
        </tr>
     </table>--%>

   
    <link href="/Styles/jquery.datetimepicker.css" rel="stylesheet" type="text/css" />
    <script src="../Scripts/Validation.js" type="text/javascript"></script>
    <script src="../Scripts/jquery.js" type="text/javascript"></script>
    <script src="../Scripts/jquery.datetimepicker.full.js" type="text/javascript"></script>
    <script type="text/javascript">

        $('.btn-default').click(function () {

            $('.orderForm').addClass('hide');

            $('.orderList').removeClass('hide');
        });
      
        jQuery('#<%=IDdatepicker1.ClientID%>').datetimepicker({

            inline: false,
            timepicker: false
        });

        jQuery('#<%=IDdatepicker2.ClientID%>').datetimepicker({

            inline: false,
            timepicker: false
        });
       
    </script>
</asp:Content>
