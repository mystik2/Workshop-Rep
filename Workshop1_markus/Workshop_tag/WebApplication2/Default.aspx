<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="WebApplication2._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:Label ID="lbl_Name" runat="server" Text="Name:"></asp:Label>
    <asp:TextBox ID="txt_Name" runat="server" Width="210px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lbl_Beschreibung" runat="server" Text="Beschreibung:"></asp:Label>
    <asp:TextBox ID="txt_Beschreibung" runat="server" Width="210px"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="bt_drueck_Mich" runat="server" Text="Drück mich!" />
</asp:Content>
