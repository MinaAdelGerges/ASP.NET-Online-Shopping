<%@ Page Title="" Language="C#" MasterPageFile="~/electronix.Master" AutoEventWireup="true" CodeBehind="editProfile.aspx.cs" Inherits="electronix.editProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style7">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Name:</td>
            <td>
                <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 18px">Age:</td>
            <td style="height: 18px">
                <asp:TextBox ID="txt_age" runat="server"></asp:TextBox>
            </td>
            <td style="height: 18px"></td>
        </tr>
        <tr>
            <td style="height: 18px">Email:</td>
            <td style="height: 18px">
                <asp:TextBox ID="txt_email" runat="server"></asp:TextBox>
            </td>
            <td style="height: 18px"></td>
        </tr>
        <tr>
            <td>Gender:</td>
            <td>
                <asp:TextBox ID="txt_gender" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Photo: </td>
            <td>
                <asp:FileUpload ID="fu_img" runat="server" />
                .</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                <asp:LinkButton ID="btn_save" runat="server" OnClick="btn_save_Click">Save Changes</asp:LinkButton>
            </td>
        </tr>
    </table>
</asp:Content>
