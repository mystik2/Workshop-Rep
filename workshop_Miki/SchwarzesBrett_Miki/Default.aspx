<%@ Page Title="Startseite" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="SchwarzesBrett_Miki._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    
        <asp:Label ID="lblName" runat="server" Text="Name:"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" Height="22px" Width="250" 
            style="margin-left: 77px"></asp:TextBox>
    <br />
    <br />
        <asp:Label ID="lblBeschreibung" runat="server" Text="Beschreibung:"></asp:Label>
        <asp:TextBox ID="txtBeschreibung" runat="server" Height="22px" Width="500" 
            style="margin-left: 33px"></asp:TextBox>
    <br />
    <br />
        <asp:Button ID="btAbsenden" runat="server" Text="Absenden" 
            onclick="btAbsenden_Click" />

    
    </asp:Content>
