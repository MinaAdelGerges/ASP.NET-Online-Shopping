<%@ Page Title="" Language="C#" MasterPageFile="~/electronix.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="electronix.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%; border-left-style: solid; border-left-width: 1px; border-right: 1px solid #C0C0C0; border-top-style: solid; border-top-width: 1px; border-bottom: 1px solid #C0C0C0">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Image ID="img_profile" runat="server" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 18px">Name:</td>
            <td style="height: 18px">
                <asp:Label ID="lbl_name" runat="server"></asp:Label>
                .</td>
            <td style="height: 18px"></td>
            <td style="height: 18px">
                <asp:LinkButton ID="btn_logout" runat="server" OnClick="btn_logout_Click" >logout</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td style="height: 18px">Age:</td>
            <td style="height: 18px">
                <asp:Label ID="lbl_age" runat="server"></asp:Label>
                .</td>
            <td style="height: 18px"></td>
            <td style="height: 18px">
                <asp:LinkButton ID="btn_edit" runat="server" PostBackUrl="~/editProfile.aspx" >Edit Profile</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td>Email:</td>
            <td>.<asp:Label ID="lbl_email" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:LinkButton ID="btn_change" runat="server" PostBackUrl="~/changePassword.aspx" >Change Password</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td>Gender:</td>
            <td>
                <asp:Label ID="lbl_gender" runat="server"></asp:Label>
                .</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
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
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
