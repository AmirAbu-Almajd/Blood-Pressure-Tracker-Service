<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main menu.aspx.cs" Inherits="userClient.Main_menu" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

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
        <p>
    <asp:Chart ID="graph" runat="server" Width="488px">

            <series>

                <asp:Series ChartType="Line" Name="Series1" XValueMember="1" YValueMembers="0">

                </asp:Series>

            </series>

            <chartareas>

                <asp:ChartArea Name="ChartArea1">

                </asp:ChartArea>

            </chartareas>

        </asp:Chart>

        </p>
    </form>
</body>
</html>
