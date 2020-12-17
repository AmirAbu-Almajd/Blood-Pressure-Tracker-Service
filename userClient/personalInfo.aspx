<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="personalInfo.aspx.cs" Inherits="userClient.personalInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 554px">
    <form id="form1" runat="server">
        Name<asp:TextBox ID="nametxt" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <p>
            Gender<asp:TextBox ID="gendertxt" runat="server" ReadOnly="True"></asp:TextBox>
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
            <asp:Button ID="update" runat="server" OnClick="update_Click" Text="Save" />
        </p>
    </form>
</body>
</html>
