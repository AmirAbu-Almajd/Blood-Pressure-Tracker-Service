<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registerationWindow.aspx.cs" Inherits="userClient.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 497px">
    <form id="form1" runat="server">
        Name<asp:TextBox ID="nametxt" runat="server"></asp:TextBox>
        <p>
            Gender<asp:DropDownList ID="gendercmb" runat="server">
                <asp:ListItem Value="M">Male</asp:ListItem>
                <asp:ListItem Value="F">Female</asp:ListItem>
            </asp:DropDownList>
        </p>
        Age<asp:TextBox ID="agetxt" runat="server"></asp:TextBox>
        <p>
            Weight<asp:TextBox ID="weighttxt" runat="server"></asp:TextBox>
        </p>
        Blood Pressure<asp:TextBox ID="bptxt" runat="server"></asp:TextBox>
        <p>
            Username<asp:TextBox ID="usernametxt" runat="server"></asp:TextBox>
        </p>
        Password<asp:TextBox ID="passwordtxt" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="registerbtn" runat="server" OnClick="registerbtn_Click" Text="Register" />
        </p>
    </form>
</body>
</html>
