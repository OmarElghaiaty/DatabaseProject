<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StadiumManger.aspx.cs" Inherits="MileStone3.StadiumManger" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Registering<br />
            <br />
            Name:<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Username:<br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            Password:<br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            Stadium name:<br />
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Reg" Text="Register" />
            <br />
            <br />
            Stadium Info<br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="View"  />
            <br />
            <asp:Panel ID="Panel1" runat="server">
            </asp:Panel>

            <br />
            Recieved Requests<br />
            <br />
            <asp:Button ID="Button4" runat="server" OnClick="Req" Text="View" />
            <br />
            <asp:Panel ID="Panel2" runat="server">
            </asp:Panel>
            <br />
            Accept Requests<br />
            <br />
            Host Name:<br />
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            Guest Name:<br />
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <br />
            Start time:<br />
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button5" runat="server" OnClick="Acc" Text="Accept" />
            <br />
            <br />
            Reject Requests<br />
            <br />
            Host Name:<br />
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            <br />
            Guest Name:<br />
            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
            <br />
            Start time:<br />
            <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button6" runat="server" Text="Reject" OnClick="Button6_Click" />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>