<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="personalInfo.aspx.cs" Inherits="userClient.personalInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 554px">
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="User ID"></asp:Label>
        <asp:TextBox ID="idtxt" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        Name<asp:TextBox ID="nametxt" runat="server" ></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <p>
            Gender<asp:TextBox ID="gendertxt" runat="server" ReadOnly="True"></asp:TextBox>
        </p>
        Age<asp:TextBox ID="agetxt" runat="server"></asp:TextBox>
        <p>
            Weight<asp:TextBox ID="weighttxt" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Height"></asp:Label>
            <asp:TextBox ID="Heighttxt" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="BMI :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="bmilbl" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        Blood Pressure<asp:TextBox ID="bptxt" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="category" runat="server" Text="Label"></asp:Label>
&nbsp;<p>
            <asp:Label ID="Label4" runat="server" Text="Gmail"></asp:Label>
            <asp:TextBox ID="gmailtxt" runat="server"></asp:TextBox>
        </p>
        <p>
            Username<asp:TextBox ID="usernametxt" runat="server"></asp:TextBox>
        </p>
        Password<asp:TextBox ID="passwordtxt" runat="server"></asp:TextBox>
        <div style="margin-left: 960px">
        </div>
        <p>
            <asp:Button ID="update" runat="server" OnClick="update_Click" Text="Save" />
            <asp:Button ID="Backbtn" runat="server" OnClick="Backbtn_Click" style="height: 29px" Text="Back" />
        </p>
    </form>
</body>
</html>
