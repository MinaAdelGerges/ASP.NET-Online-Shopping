<%@ Page Title="" Language="C#" MasterPageFile="~/electronix.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="electronix.register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%">
        <tr>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>Name</td>
            <td>
                <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_name" ErrorMessage="please enter your name" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>age</td>
            <td>
                <asp:TextBox ID="txt_age" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txt_age" Display="Dynamic" ErrorMessage="RangeValidator" ForeColor="Red" MaximumValue="60" MinimumValue="20">age must between 20 and 60</asp:RangeValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_age" Display="Dynamic" ErrorMessage="please enter your age" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>password</td>
            <td>
                <asp:TextBox ID="txt_pass" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>confirm-password</td>
            <td>
                <asp:TextBox ID="txt_confirm" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txt_pass" ControlToValidate="txt_confirm" ErrorMessage="CompareValidator" ForeColor="Red">pass not confirm</asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td>E-mail</td>
            <td>
                <asp:TextBox ID="txt_email" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt_email" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">invalid email</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>gender</td>
            <td>
                <asp:RadioButtonList ID="rbl_gender" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem>male</asp:ListItem>
                    <asp:ListItem>female</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            </td>
        </tr>
        <tr>
            <td>photo</td>
            <td>
                <asp:FileUpload ID="fu_photo" runat="server" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 29px">.</td>
            <td style="height: 29px">
                .</td>
            <td style="height: 29px"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btn_register" runat="server"  Text="register" OnClick="btn_register_Click" />
                <asp:Label ID="lbl_status" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Button ID="btn_login" runat="server"  Text="login" ValidationGroup="lo" />
            </td>
        </tr>
    </table>
</asp:Content>
