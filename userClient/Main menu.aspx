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
    <form id="form1" runat="server" style="background-image: url('WhatsApp%20Image%202020-12-28%20at%207.40.29%20PM.jpeg'); background-size:100% 100%; background-repeat: no-repeat; background-attachment: fixed; height: 975px;">
        <asp:TextBox ID="idtxt" runat="server" ReadOnly="True" Width="25px"></asp:TextBox>
        <br />
        <asp:Button style="border-radius: 10px;" BackColor="Black" BorderStyle="Ridge" Height="56px" Font-Size="Large" ForeColor="White" ID="view" runat="server" OnClick="view_Click" Text="View personal information" Width="434px" />
            <asp:Button style="border-radius: 10px;" BackColor="Black" BorderStyle="Ridge" Height="55px" Font-Size="Large" ForeColor="White" ID="dietPlan" runat="server" OnClick="dietPlan_Click" Text="View diet plan" Width="408px" />
            <asp:Button style="border-radius: 10px;" BackColor="Black" BorderStyle="Ridge" Height="55px" Font-Size="Large" ForeColor="White" ID="logoutbtn" runat="server" OnClick="logoutbtn_Click" Text="Logout" Width="410px" />
        <p style="margin-top: 30px" >
            &nbsp;</p>
        <p style="margin-top: 30px" >
            &nbsp;</p>
        <p style="margin-top: 30px; font-size: large;" >
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label style="color:red" ID="warninglbl" runat="server" Text="You need to update your blood pressure reading - lastest reading since " Visible="False"></asp:Label>
        &nbsp;&nbsp;
        </p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="bptxt" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button style="border-radius: 10px;" BackColor="Black" BorderStyle="Ridge" Height="39px" Font-Size="Large" ForeColor="White" ID="update" runat="server" Text="Update Blood Pressure" OnClick="update_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <br />
        <br />
        <p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Chart ID="graph" runat="server" Width="675px">

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
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
