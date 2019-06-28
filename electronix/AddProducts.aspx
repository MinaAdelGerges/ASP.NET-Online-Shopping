<%@ Page Title="" Language="C#" MasterPageFile="~/electronix.Master" AutoEventWireup="true" CodeBehind="AddProducts.aspx.cs" Inherits="electronix.AddProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%">
    <tr>
        <td style="height: 18px">Name:</td>
        <td style="height: 18px">
            <asp:TextBox ID="txt_productName" runat="server"></asp:TextBox>
            .</td>
        <td style="height: 18px"></td>
        <td style="height: 18px"></td>
    </tr>
    <tr>
        <td style="height: 18px">Type:</td>
        <td style="height: 18px">
            <asp:DropDownList ID="ddl_type" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Id">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:electronixConnectionString %>" SelectCommand="SELECT * FROM [Category] ORDER BY [Name]"></asp:SqlDataSource>
            .</td>
        <td style="height: 18px"></td>
        <td style="height: 18px"></td>
    </tr>
    <tr>
        <td>Price</td>
        <td>
            <asp:TextBox ID="txt_price" runat="server"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>Image:</td>
        <td>
            <asp:FileUpload ID="fup_image" runat="server" />
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>Description:</td>
        <td>
            <asp:TextBox ID="txt_desc" runat="server" Height="66px" TextMode="MultiLine" Width="238px"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="height: 18px"></td>
        <td style="height: 18px"></td>
        <td style="height: 18px"></td>
        <td style="height: 18px"></td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Button ID="btn_add" runat="server" OnClick="btn_add_Click" Text="Add Product" />
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Label ID="lbl_status" runat="server"></asp:Label>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
