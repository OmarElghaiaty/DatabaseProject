<head runat="server">
    <title></title>
</head>
<html xmlns="http://www.w3.org/1999/xhtml">
<body>
    <form id="form1" runat="server">
        <p>
            Pleas Log In<br />
            <br />
            Username:<br />
            <asp:TextBox ID="username" runat="server"></asp:TextBox>
            <br />
            Password:<br />
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick ="login" Text="Log In" />
        </p>
    </form>
</body>
</html>
