<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AssociationManger.aspx.cs" Inherits="MileStone3.AssociationManger" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 253px;
        }
    </style>
</head>
<body style="height: 423px">
    <form id="form1" runat="server">
        <div>
            Register<br />
            <br />
            Name:</div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Username:<br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        Password:<br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" />
    </form>
</body>
</html>
