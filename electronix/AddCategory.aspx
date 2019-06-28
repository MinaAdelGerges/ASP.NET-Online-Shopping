<%@ Page Title="" Language="C#" MasterPageFile="~/electronix.Master" AutoEventWireup="true" CodeBehind="AddCategory.aspx.cs" Inherits="electronix.AddCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    .<table style="width: 100%">
    <tr>
        <td style="width: 237px">Category Name:</td>
        <td>
            <asp:TextBox ID="txt_categoryName" runat="server"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 237px">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 237px">&nbsp;</td>
        <td>
            <asp:Button ID="btn_add" runat="server" OnClick="btn_add_Click" Text="Add" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 237px">&nbsp;</td>
        <td>
            <asp:Label ID="lbl_status" runat="server"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
