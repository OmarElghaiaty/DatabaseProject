<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="MileStone3.admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Welcome Admin<br />
            <br />
            Adding Club<br />
            Name:<br />
            <asp:TextBox ID="Name" runat="server"></asp:TextBox>
            <br />
            Location:</div>
        <asp:TextBox ID="Location" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="AddClub" Text="Add" />
        <br />
        <br />
        Deleting Club<br />
        <br />
            Name:<br />
            <asp:TextBox ID="Name0" runat="server"></asp:TextBox>
            <br />
        <asp:Button ID="Button2" runat="server" OnClick="DeleteClub" Text="Delete" />
        <br />
        <br />
        Adding Stadium<br />
        <div>
            Name:<br />
            <asp:TextBox ID="Name1" runat="server"></asp:TextBox>
            <br />
            Location:</div>
        <asp:TextBox ID="Location0" runat="server"></asp:TextBox>
        <br />
        Capacity:<br />
        <asp:TextBox ID="Location1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="AddStadium" Text="Add" />
        <br />
        <br />
        Deleting Stadium<br />
        Name:<br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button4" runat="server" OnClick="deleteStadium" Text="delete" />
        <br />
        <br />
        Blocking Fan<br />
        National_Id:<br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Block" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
