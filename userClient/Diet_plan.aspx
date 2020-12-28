<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Diet_plan.aspx.cs" Inherits="userClient.Diet_plan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p style="height: 43px">
            Diet Plan</p>
        <p style="height: 77px">
            Breakfast options:<asp:Label ID="breakfast_txt" runat="server" Text="Label"></asp:Label>
        </p>
        <p style="height: 77px">
            lunch options:<asp:Label ID="lunch_txt" runat="server" Text="Label"></asp:Label>
        </p>
        <p style="height: 77px">
            Dinner options:<asp:Label ID="dinner_txt" runat="server" Text="Label"></asp:Label>
        </p>
        <p style="height: 77px">
            Notes:<asp:Label ID="notes_txt" runat="server" Text="Label"></asp:Label>
        </p>
        <asp:Button ID="sendbtn" runat="server" OnClick="sendbtn_Click" Text="Send it to my mail" />
        <br />
        <asp:Button ID="backbtn" runat="server" OnClick="backbtn_Click" Text="Back" />
    </form>
</body>
</html>
