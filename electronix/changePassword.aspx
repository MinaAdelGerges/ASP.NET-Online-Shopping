<%@ Page Title="" Language="C#" MasterPageFile="~/electronix.Master" AutoEventWireup="true" CodeBehind="changePassword.aspx.cs" Inherits="electronix.changePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%">
        <tr>
            <td style="height: 32px">Old Password:</td>
            <td style="height: 32px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txt_old" runat="server" TextMode="Password">
</asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_old" Display="Dynamic" ErrorMessage="Enter all fields" ForeColor="Red">Please Enter Old Password</asp:RequiredFieldValidator>
            </td>
            <td style="height: 32px"></td>
        </tr>
        <tr>
            <td>New Password:</td>
            <td>
                <asp:TextBox ID="txt_new" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_new" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Enter New Password!</asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Confirm New Password:</td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txt_confirm" runat="server" TextMode="Password"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txt_new" ControlToValidate="txt_confirm" Display="Dynamic" ErrorMessage="Password Not Matched!" ForeColor="Red"></asp:CompareValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txt_confirm" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Confirm Password!</asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Label ID="lbl_save" runat="server" Font-Bold="True" ForeColor="#66FF33"></asp:Label>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
            </td>
            <td>
                <asp:LinkButton ID="btn_save" runat="server" OnClick="btn_save_Click">Save</asp:LinkButton>
            </td>
        </tr>
    </table>
</asp:Content>
