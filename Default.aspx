<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        CALCULADORA EN F#</div>
        Numero 1:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<p>
            Numero 2:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            resultado:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="SUMAR" Width="135px" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="RESTAR" Width="137px" />
        <p>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="MULTIPLICAR" Width="131px" />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="DIVIDIR" Width="143px" />
        </p>
    </form>
</body>
</html>
