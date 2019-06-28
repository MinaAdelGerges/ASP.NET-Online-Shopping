<%@ Page Title="" Language="C#" MasterPageFile="~/electronix.Master" AutoEventWireup="true" CodeBehind="cart.aspx.cs" Inherits="electronix.cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     ..<br />
<br />
<br />
<table class="auto-style7">
    <tr>
        <td colspan="3">
            &nbsp;</td>
    </tr>
    <tr>
        <td style="height: 236px">
            <asp:Image ID="img_product" runat="server" CssClass="detailsImage" />
        </td>
        <td style="height: 236px">Product Description:<br />
&nbsp;<asp:Label ID="lbl_desc" runat="server" CssClass="detailsDescription"></asp:Label>
        </td>
        <td style="height: 236px"></td>
    </tr>
    <tr>
        <td class="auto-style14">
            &nbsp;</td>
        <td class="auto-style14">
            &nbsp;</td>
        <td class="auto-style14">
            <asp:Label ID="Available" runat="server" CssClass="productPrice"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style14">Product Name:
            <br />
            <asp:Label ID="lbl_title" runat="server"></asp:Label>
        </td>
        <td class="auto-style14">
            &nbsp;</td>
        <td class="auto-style14">Quantity :</td>
    </tr>
    <tr>
        <td style="height: 29px">Price<br />
            :
            <asp:Label ID="lbl_price" runat="server" CssClass="detialsPrice"></asp:Label>
        </td>
        <td style="height: 29px">&nbsp;</td>
        <td style="height: 29px">
            <asp:DropDownList ID="ddl_amount" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style14">&nbsp;</td>
        <td class="auto-style14">
            &nbsp;</td>
        <td class="auto-style14">Product Number:
            <asp:Label ID="lbl_item" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style14"></td>
        <td class="auto-style14">
            <asp:Label ID="lbl_result" runat="server"></asp:Label>
        </td>
        <td class="auto-style14">
            <asp:Button ID="btn_addCart" runat="server" OnClick="btn_addCart_Click" Text="Add To Cart" CssClass="button" />
        </td>
    </tr>
</table>
<br />
<br />
<br />
<br />
    </asp:Content>
