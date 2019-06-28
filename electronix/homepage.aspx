<%@ Page Title="" Language="C#" MasterPageFile="~/electronix.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="electronix.homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="style.css" rel="stylesheet"/>
    <div id="main_container" style="height: 940px">
  <div class="top_bar">
      <span style="background-repeat: no-repeat; background-position: center">.</span></div>
  <div id="main_content">
    <div id="menu_tab">
      <ul class="menu">
      
      </ul>
    </div>
    <!-- end of menu tab -->
    <div class="left_content">
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </div>
      <div class="center_content" style="width: 737px">
          <div class="center_title_bar" style="width: 696px; margin-bottom: 0">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Products<br />
              <br />
              To Add to Cart Click on the picture of product you want to Buy!<br />
              <br />
              <asp:Image ID="img_url" runat="server" />
              <asp:Panel ID="pnl_products" runat="server" Height="579px" style="margin-left: 0px" Width="698px">
              </asp:Panel>
              <div style="clear:both;"></div>
          </div>
    </div>
    <!-- end of center content -->
    <!-- end of right content -->
  </div>
  <!-- end of main content -->
</div>
</asp:Content>

