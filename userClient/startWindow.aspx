<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="startWindow.aspx.cs" Inherits="userClient.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Username</p>
        <p>
            <asp:TextBox ID="usernametxt" runat="server"></asp:TextBox>
        </p>
        <p>
            Password</p>
        <p>
            <asp:TextBox ID="passwordtxt" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="loginButton" runat="server" OnClick="loginButton_Click" Text="Login" Width="138px" />
        </p>
        <p>
            <asp:Button ID="registerbtn" runat="server" Text="Register" Width="138px" OnClick="registerbtn_Click" />
        </p>
    </form>
</body>
</html>
