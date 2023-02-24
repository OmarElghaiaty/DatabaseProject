<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AssociationManger.aspx.cs" Inherits="MileStone3.AssociationManger" %>

<!DOCTYPE html>
<script runat="server">

    

    
</script>


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
            Registring Sports Asssociation Manager<br />
            Name:</div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <p>
            Username:</p>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        Password:<br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" />
        <br />
        <br />
        Adding New Match<br />
        Host Club Name:<br />
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        Guest Club Name:<br />
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        Start Time:<br />
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        End Time:<br />
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Add"  />
        <br />
        <br />
        Deleting Match<br />
        Host Club Name:<br />
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        <br />
        Guest Club Name:<br />
        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        <br />
        Start Time:<br />
        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
        <br />
        End Time:<br />
        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button3" runat="server" Text="Delete" />
        <br />
        <br />
        Upcoming Matches<br />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="View"  />
        <br />
        <asp:Panel ID="Panel1" runat="server">
        </asp:Panel>
        <br />
        <br />
        Already Played Matches<br />
        <asp:Button ID="Button5" runat="server" Text="View" />
        <br />
        <asp:Panel ID="Panel2" runat="server">
        </asp:Panel>
        <br />
        <br />
        Names Of Pair Of Club Never Played With Each Other<br />
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="View"  />
        <br />
        <asp:Panel ID="Panel3" runat="server">
        </asp:Panel>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
