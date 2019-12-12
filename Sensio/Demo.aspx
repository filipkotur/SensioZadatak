<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo.aspx.cs" Inherits="Sensio.Demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <asp:Label ID="IdTekst" runat="server" Text="Unesi parametar/re"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <p>
            <asp:Button ID="IdSpremi" runat="server" Text="Spremi" OnClick="IdSpremi_Click" />
            <asp:Button ID="IdPosalji" runat="server" Text="Pošalji" OnClick="IdPosalji_Click" />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Tablica]"></asp:SqlDataSource>
        </p>
        <asp:Label ID="Label1" runat="server" Text="Status code:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </form>
</body>
</html>
