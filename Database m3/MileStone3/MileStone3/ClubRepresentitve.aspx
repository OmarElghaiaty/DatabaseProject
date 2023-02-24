<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClubRepresentitve.aspx.cs" Inherits="MileStone3.ClubRepresentitve" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Registring<br />
            name:<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            username:<br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            password:<br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            club name:<br />
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Register" Text="Register" />
            <br />
            <br />
            Viewing Info<br />
            <asp:Button ID="Button2" runat="server" OnClick="ViewInfo" Text="View" />
            <br />
            <asp:Panel ID="Panel1" runat="server">
            </asp:Panel>
            <br />
            Viewing Upcoming Matches<br />
            <asp:Button ID="Button3" runat="server" Onclick="ViewMatch" Text="View" />
            <br />
            <asp:Panel ID="Panel2" runat="server">
            </asp:Panel>
            <br />
            View Stadiums<br />
            Date:<br />
            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button4" runat="server" OnClick="viewStadium" Text="View" />
            <br />
            <asp:Panel ID="Panel3" runat="server">
            </asp:Panel>
            <br />
            Sending Request<br />
            Club Name:<br />
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <br />
            Stadium Name:<br />
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            <br />
            StartTime:<br />
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button5" runat="server" OnClick="SendReq" Text="Send" />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
