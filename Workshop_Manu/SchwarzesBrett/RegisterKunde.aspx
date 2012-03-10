<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterKunde.aspx.cs" Inherits="SchwarzesBrett.RegisterKunde" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <h1>Kunde</h1><br />
        <table border="1">
            <tr style="width: 150px">
                <td><b>Name:</b></td>
                <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>                
            </tr>
            <tr>
                <td><b>Vorname:</b></td>
                <td><asp:TextBox ID="txtVorname" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2"><asp:Button ID="btButton" runat="server" Text="Speichern" 
                        onclick="btButton_Click" /></td>
            </tr>
        </table>
       
        
        <br />
        </div>
    </form>
</body>
</html>
