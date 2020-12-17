<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main menu.aspx.cs" Inherits="userClient.Main_menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1 {
            width: 425px;
        }
    </style>
</head>
<body style="height: 430px">
    <form id="form1" runat="server">
        <asp:Button ID="view" runat="server" OnClick="view_Click" Text="View personal information" />
        <asp:TextBox ID="idtxt" runat="server" ReadOnly="True"></asp:TextBox>
        <p style="margin-top: 30px" >
            <asp:Label style="color:red" ID="warninglbl" runat="server" Text="You need to update your blood pressure reading - lastest reading since " Visible="False"></asp:Label>
        </p>
            <asp:Button ID="update" runat="server" Text="Update Blood Pressure" OnClick="update_Click" />
            <asp:TextBox ID="bptxt" runat="server"></asp:TextBox>
    </form>
</body>
</html>
