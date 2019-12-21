<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS56_._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

  <h3>訂單管理系統</h3>
    <asp:Button ID="Button1" runat="server" Text="建立訂單" OnClick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" Text="新增採購項目" OnClick="Button2_Click" />
</asp:Content>
