<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main menu.aspx.cs" Inherits="userClient.Main_menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 430px">
    <form id="form1" runat="server">
        <asp:Button ID="view" runat="server" OnClick="view_Click" Text="View personal information" />
        <asp:TextBox ID="idtxt" runat="server" ReadOnly="True"></asp:TextBox>
    </form>
</body>
</html>
