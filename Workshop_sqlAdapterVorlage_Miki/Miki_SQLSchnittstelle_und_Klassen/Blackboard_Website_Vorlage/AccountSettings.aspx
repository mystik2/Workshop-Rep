

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccountSettings.aspx.cs" Inherits="Blackboard_Website_Vorlage.AccountSettings" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1> Account Settings</h1> <br />
    <table border= "1">
       <tr style ="width: 150px">
                    <td><b>UserID 'Später ersetzt durch Login:</b></td> 
                    <td> <asp:TextBox ID="txtSettingsNamenAendernUserID" runat="server"></asp:TextBox></td>
                </tr>

                <tr>
                    <td><b>Nachname:</b></td>
                    <td> <asp:TextBox ID="txtSettingsNachname" runat="server"></asp:TextBox></td>
                </tr>

                <tr>
                    <td><b>Vorname:</b></td>
                    <td> <asp:TextBox ID="txtSettingsVorname" runat="server"></asp:TextBox></td>
                </tr>
    </table>
    <br />
        <asp:Button ID="btbSettingsNamenAendern" runat="server" Text="Namen aendern" 
            onclick="btbSettingsNamenAendern_Click" />
    <h2>Passwort aendern</h2>
     <table border= "1">
     <tr style ="width: 150px">
                    <td><b>UserID 'Später ersetzt durch Login:</b></td> 
                    <td> <asp:TextBox ID="txtSettingsPWaendernUserID" runat="server"></asp:TextBox></td>
                </tr>
       <tr >
                    <td><b>Passwort alt:</b></td>
                    <td> <asp:TextBox ID="txtSettingsPasswortalt" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>

                <tr>
                    <td><b>Passwort neu:</b></td>
                    <td> <asp:TextBox ID="txtSettingsPasswortNeu" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>

                <tr>
                    <td><b>Wiederholen Passwort neu:</b></td>
                    <td> <asp:TextBox ID="txtSettingsPasswortNeuWdh" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
    </table>
    </div>
    <asp:Button ID="btbSettingsPasswortAendern" runat="server"  
        Text="Passwort aendern" onclick="btbSettingsPasswortAendern_Click" />
    </form>
</body>
</html>
