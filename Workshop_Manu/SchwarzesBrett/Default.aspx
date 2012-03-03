<%@ Page Title="Startseite" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="SchwarzesBrett._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    
    <asp:Label ID="lblName" runat="server" Text="Name: "></asp:Label> 
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <br />
    
    <asp:Label ID="lblBeschreibung" runat="server" Text="Beschreib: "></asp:Label> 
    <asp:TextBox ID="txtBeschreibung" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btSend" runat="server" Text="Senden" onclick="btSend_Click" />
    
</asp:Content>
