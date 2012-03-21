<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrierung.aspx.cs" Inherits="Blackboard_Website_Vorlage.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Registrierung</h1>
        <p>&nbsp;</p>
            <table border= "1">
                <tr style ="width: 150px">
                    <td><b>Nachname:</b></td>
                    <td> <asp:TextBox ID="txtRegistNachname" runat="server" Width="280px"></asp:TextBox></td>
                </tr>

                <tr>
                 <td><b>Vorname:</b></td>
                    <td> <asp:TextBox ID="txtRegistVorname" runat="server" Width="280px"></asp:TextBox></td>
                </tr>

                <tr>
                 <td><b>Geburtsdatum:</b></td>
                    <td> <asp:TextBox ID="txtRegistGebdatum" runat="server" Width="280px"
                            ToolTip="Bitte Geburtsdatum folgendermaßen eingeben: dd.mm.jjjj"></asp:TextBox></td>
                </tr>

                <tr>
                 <td><b>Username:</b></td>
                    <td> <asp:TextBox ID="txtRegistUsername" runat="server" Width="280px"></asp:TextBox></td>
                </tr>

                <tr>
                 <td><b>Email:</b></td>
                    <td> <asp:TextBox ID="txtRegistEmail" runat="server"  Width="280px" 
                            AutoCompleteType="Email" ReadOnly="True" 
                            >@hm.edu</asp:TextBox></td>
                </tr>

                <tr>
                 <td><b>Passwort:</b></td>
                    <td> <asp:TextBox ID="txtRegistPasswort" runat="server" Width="280px" TextMode="Password"></asp:TextBox></td>
                </tr>

                <tr>
                 <td><b>Wiederhole Passwort:</b></td>
                    <td> <asp:TextBox ID="txtRegistWdhPasswort" runat="server" Width="280px" TextMode="Password"></asp:TextBox></td>
                </tr>

                <tr>
                 <td><b>Sicherheitsfrage:</b></td>
                    <td> 
                        <asp:DropDownList ID="dropdownSicherheitsfrage" runat="server" 
                            DataTextField="wer is deine mudda?">
                            <asp:ListItem>Wie heißt deine Mutter mit Mädchennamen?</asp:ListItem>
                            <asp:ListItem>was?</asp:ListItem>
                            </asp:DropDownList>
                    </td>
                </tr>

                <tr>
                 <td><b>Sicherheitsantwort:</b></td>
                    <td> <asp:TextBox ID="txtSicherheitsAntwort" runat="server" Width="280px"></asp:TextBox></td>
                </tr>

            </table>
    
    </div>
    <asp:Button ID="btbRegistrieren" runat="server" Text="Registrieren" 
        onclick="btbRegistrieren_Click" />
    </form>
</body>
</html>
