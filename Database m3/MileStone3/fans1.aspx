<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fans1.aspx.cs" Inherits="MileStone3.fans1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            Registering</p>
        <p>
            Name</p>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        UserName<br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        Password<br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        National Id Number<br />
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        Phone Number<br />
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        Birth Date<br />
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        Address<br />
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Register" />
        <br />
    </form>
</body>
</html>
