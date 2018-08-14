<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="CPRG214_Lab1._default" %>

<!DOCTYPE html>

<!-- 
     CPRG214 Lab1
     Author:  Corinne Mullan
     Date:    July 19, 2018     
-->

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Temperature Conversion</h1>
            <img alt="thermometer image" class="auto-style1" src="img/thermometer.png" /><br />
            <asp:TextBox ID="txtFromTemperature" class="control" runat="server"></asp:TextBox>
            <asp:DropDownList ID="ddlFromUnits" class="control" runat="server">
                <asp:ListItem Selected="True">Celsius</asp:ListItem>
                <asp:ListItem>Fahrenheit</asp:ListItem>
                <asp:ListItem>Kelvin</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" class="validator" runat="server" ControlToValidate="txtFromTemperature" Display="Dynamic" ErrorMessage="Enter a temperature value"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator1" runat="server" class="validator" ControlToValidate="txtFromTemperature" Display="Dynamic" ErrorMessage="Enter a value between -1000 and 1000" MaximumValue="1000" MinimumValue="-1000" Type="Double"></asp:RangeValidator>
            <br />
            <asp:TextBox ID="txtToTemperature" class="control readonly" runat="server" ReadOnly="True"></asp:TextBox>
            <asp:DropDownList ID="ddlToUnits" class="control" runat="server">
                <asp:ListItem>Celsius</asp:ListItem>
                <asp:ListItem Selected="True">Fahrenheit</asp:ListItem>
                <asp:ListItem>Kelvin</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Button ID="btnConvert" class="button" runat="server" OnClick="btnConvert_Click" Text="Convert" />
            <asp:Button ID="btnClear" class="button" runat="server" CausesValidation="False" OnClick="btnClear_Click" Text="Clear" />
        </div>
        <asp:Label ID="lblError" class="error" runat="server"></asp:Label>
    </form>
</body>
</html>
